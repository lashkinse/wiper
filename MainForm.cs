using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Wiper
{
    public partial class MainForm : Form
    {
        private Config _config;
        private List<string> _temporaryFiles;

        public MainForm()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig(string path = "")
        {
            if (string.IsNullOrEmpty(path)) path = "config.json";
            if (!File.Exists(path)) return;

            var data = File.ReadAllText(path);
            _config = JsonConvert.DeserializeObject<Config>(data);

            if (_config == null)
            {
                textBox_AppendText("Failed to load config!");
                return;
            }

            textBox_AppendText("Config successfully loaded:");
            textBox_AppendText("\n");

            textBox_AppendText("cluster(s):");
            foreach (var cluster in _config.clusters)
                textBox_AppendText(cluster.name + "\t" + cluster.root);
            textBox_AppendText("\ttotal: " + _config.clusters.Count);
            textBox_AppendText("\n");

            textBox_AppendText("server(s):");
            foreach (var server in _config.servers)
                textBox_AppendText(server.name + "\t" + server.root);
            textBox_AppendText("\ttotal: " + _config.servers.Count);
            textBox_AppendText("\n");
        }

        private void FindTemporaryFiles()
        {
            if (_config == null) return;

            textBox_InvokeAppendText("Searching for temporary files, please wait...");

            var filters = string.Join("|", _config.temporary_files);
            var temporaryFiles = new List<string>();

            foreach (var server in _config.servers)
            {
                var files = Utils.GetFiles(server.root, filters, SearchOption.AllDirectories);
                if (files != null)
                    temporaryFiles.AddRange(files);
            }

            foreach (var cluster in _config.clusters)
            {
                var files = Utils.GetFiles(cluster.root, "*.*", SearchOption.AllDirectories);
                if (files != null)
                    temporaryFiles.AddRange(files);
            }

            _temporaryFiles = temporaryFiles;

            textBox_InvokeAppendText(string.Join(Environment.NewLine, temporaryFiles));
            textBox_InvokeAppendText("Found " + temporaryFiles.Count + " file(s)");
        }

        private void ArchiveTemporaryFiles()
        {
            if (_temporaryFiles.Count == 0) return;

            textBox_InvokeAppendText("Backupping the data now, please wait...");

            var zipFile = "backup_" + Utils.GetDate() + ".zip";
            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
                foreach (var path in _temporaryFiles)
                {
                    archive.CreateEntryFromFile(path, path);
                }

            textBox_InvokeAppendText(zipFile + " created!");
        }

        private void DeleteTemporaryFiles()
        {
            if (_temporaryFiles.Count == 0) return;

            textBox_InvokeAppendText("Cleanup, please wait...");

            foreach (var path in _temporaryFiles)
                File.Delete(path);

            textBox_InvokeAppendText("Wipe Data is complete, " + _temporaryFiles.Count + " file(s) removed");
        }

        private void Exit()
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void openConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var config = "";
            using (var dlg = new OpenFileDialog())
            {
                dlg.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                if (dlg.ShowDialog() == DialogResult.OK)
                    config = dlg.FileName;
            }

            LoadConfig(config);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        private void findFilesButton_Click(object sender, EventArgs e)
        {
            var bw = new BackgroundWorker();
            bw.DoWork += delegate
            {
                buttons_InvokeSetEnabled(false);
                FindTemporaryFiles();
                buttons_InvokeSetEnabled(true);
            };
            bw.RunWorkerAsync();
        }

        private void wipeDataButton_Click(object sender, EventArgs e)
        {
            var dlg = MessageBox.Show("Are you Sure?", "Wipe Data", MessageBoxButtons.YesNo);
            if (dlg != DialogResult.Yes) return;

            var bw = new BackgroundWorker();
            bw.DoWork += delegate
            {
                buttons_InvokeSetEnabled(false);
                ArchiveTemporaryFiles();
                DeleteTemporaryFiles();
                buttons_InvokeSetEnabled(true);
            };
            bw.RunWorkerAsync();
        }

        private void textBox_AppendText(string text)
        {
            this.textBox.Text += text + Environment.NewLine;
            this.textBox.SelectionStart = this.textBox.TextLength;
            this.textBox.ScrollToCaret();
        }

        private void textBox_InvokeAppendText(string text)
        {
            Invoke(new MethodInvoker(delegate
            {
                textBox_AppendText(text);
            }));
        }

        void buttons_InvokeSetEnabled(bool enabled)
        {
            Invoke(new MethodInvoker(delegate
            {
                findFilesButton.Enabled = enabled;
                wipeDataButton.Enabled = enabled;
            }));
        }
    }
}
