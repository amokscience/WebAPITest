using System;
using System.Collections.Generic;
using System.Configuration;

namespace WebAPITest.Core
{
    public class ConfigurationConstants : IConfigurationConstants
    {
        public string DatabaseConnectionString {
            get { return ConfigurationManager.ConnectionStrings["sql2013"].ConnectionString; } }
    }
}

