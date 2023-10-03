using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College2
{
    public static class ConfigurationData
    {
        private static string _appName = "Cool app";
        private static double _version = 1.2;
        private static int _maxUsers = 500;

        public static string AppName
        {
            get => ConfigurationData._appName;
        }
        public static double Version
        {
            get => ConfigurationData._version;
        }
        public static int MaxUsers
        {
            get => ConfigurationData._maxUsers;
        }

    }
}
