using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CONGNGHENET
{
    internal class LuuAppConfig
    {
        Configuration config;
        public LuuAppConfig()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
        public string GetConnectionString(string name)
        {
            return config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }
        public void SetConnectionString(string name, string value)
        {
            config.ConnectionStrings.ConnectionStrings[name].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[name].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
        public void setValue(string key, string value)
        {
            ConfigurationManager.AppSettings[key] = value;
            config.Save(ConfigurationSaveMode.Full);
        }
        public string getValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
