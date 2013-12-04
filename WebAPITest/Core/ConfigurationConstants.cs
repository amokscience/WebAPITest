using System;
using System.Collections.Generic;
using System.Configuration;

namespace WebAPITest.Core
{
    public class ConfigurationConstants
    {
        public static string DatabaseConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["sql2013"].ConnectionString; }
        }
    }
}

