using System;
using System.Collections.Generic;
using System.Text;

namespace Count.Model
{
    [Serializable]
    public class Configuration
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Program { get; set; }
    }
}
