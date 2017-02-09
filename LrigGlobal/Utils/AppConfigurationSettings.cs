using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LrigGlobal.Utils
{
    public class AppConfigurationSettings
    {
        public MongoDBSettings MongoDB { get; set; }
    }

    public class MongoDBSettings
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
    }
}
