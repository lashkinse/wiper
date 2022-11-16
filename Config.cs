using System.Collections.Generic;

namespace Wiper
{
    // Config myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Config
    {
        public List<string> temporary_files { get; set; }
        public List<Cluster> clusters { get; set; }
        public List<Server> servers { get; set; }
    }

    public class Cluster
    {
        public string name { get; set; }
        public string root { get; set; }
    }

    public class Server
    {
        public string name { get; set; }
        public string root { get; set; }
    }
}