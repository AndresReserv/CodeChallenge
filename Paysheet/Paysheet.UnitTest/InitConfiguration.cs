using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paysheet.UnitTest
{
    public class InitConfiguration
    {
        public static IConfiguration GetConfiguration(string path)
        {
            var config = new ConfigurationBuilder()
             .AddJsonFile(path)
             .Build();
            return config;
        }
    }
}
