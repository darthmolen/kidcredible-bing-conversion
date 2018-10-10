using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bing.Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            Console.WriteLine("Hello World!");
            var foundIds = new List<string>();


            // Select a record
            var sql = $"SELECT * FROM Location WHERE Id not in ({foundIds.ToCommaDelimited()}) Limit 1;";

            // Query Bing
            // https://msdn.microsoft.com/en-us/library/hh478192.aspx#How%20to%20query%20the%20NAVTEQNA%20data%20source

        }
    }
}
