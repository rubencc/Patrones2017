using System;
using System.Collections.Generic;
using System.Linq;
using Business.Implementations;
using Business.Interfaces;

namespace DocConfigurationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un tipo de documento");

            string key = Console.ReadLine();

            List<IDocConfigurationFactory> factories = new List<IDocConfigurationFactory>()
            {
                new WordDocConfigurationFactory(),
                new ExcelDocConfigurationFactory(),
                new MarkDocConfigurationFactory(),
                new PdfDocConfigurationFactory(),
            };

            IDocConfiguration config;           

            DocType type = (DocType)Enum.Parse(typeof(DocType), key, true);
            config = factories.Where(item => item.IsValidFor(type)).FirstOrDefault().CreateConfiguration(type);
            Console.Clear();
            Console.WriteLine(config.ToString());
            Console.ReadLine();
        }

        
    }
}
