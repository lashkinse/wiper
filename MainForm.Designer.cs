namespace Wiper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigjsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeDataButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.findFilesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigjsonToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openConfigjsonToolStripMenuItem
            // 
            this.openConfigjsonToolStripMenuItem.Name = "openConfigjsonToolStripMenuItem";
            this.openConfigjsonToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openConfigjsonToolStripMenuItem.Text = "Open config.json";
            this.openConfigjsonToolStripMenuItem.Click += new System.EventHandler(this.openConfigToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // wipeDataButton
            // 
            this.wipeDataButton.Location = new System.Drawing.Point(93, 305);
            this.wipeDataButton.Name = "wipeDataButton";
            this.wipeDataButton.Size = new System.Drawing.Size(75, 23);
            this.wipeDataButton.TabIndex = 2;
            this.wipeDataButton.Text = "Wipe Data";
            this.wipeDataButton.UseVisualStyleBackColor = true;
            this.wipeDataButton.Click += new System.EventHandler(this.wipeDataButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(427, 272);
            this.textBox.TabIndex = 1;
            // 
            // findFilesButton
            // 
            this.findFilesButton.Location = new System.Drawing.Point(12, 305);
            this.findFilesButton.Name = "findFilesButton";
            this.findFilesButton.Size = new System.Drawing.Size(75, 23);
            this.findFilesButton.TabIndex = 0;
            this.findFilesButton.Text = "Find Files";
            this.findFilesButton.UseVisualStyleBackColor = true;
            this.findFilesButton.Click += new System.EventHandler(this.findFilesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 341);
            this.Controls.Add(this.findFilesButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.wipeDataButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 380);
            this.MinimumSize = new System.Drawing.Size(465, 380);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigjsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button wipeDataButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button findFilesButton;
    }
}

