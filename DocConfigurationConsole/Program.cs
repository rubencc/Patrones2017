using System;
using System.Security.Cryptography;
using System.Text;
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



            IDocConfiguration config;

            IDocConfigurationFactory wordFactory = new WordDocConfigurationFactory();
            IDocConfigurationFactory excelFactory = new ExcelDocConfigurationFactory();
            IDocConfigurationFactory markFactory = new MarkDocConfigurationFactory();
            IDocConfigurationFactory pdfFactory = new PdfDocConfigurationFactory();

            DocType type = (DocType)Enum.Parse(typeof(DocType), key, true);
            switch (type)
            {
                case DocType.XML:
                    config = markFactory.CreateConfiguration(type);
                    break;
                case DocType.CSV:
                    config = markFactory.CreateConfiguration(type);
                    break;
                case DocType.JSON:
                    config = markFactory.CreateConfiguration(type);
                    break;
                case DocType.DOC:
                    config = wordFactory.CreateConfiguration(type);
                    break;
                case DocType.DOCX:
                    config = wordFactory.CreateConfiguration(type);
                    break;
                case DocType.XLS:
                    config = excelFactory.CreateConfiguration(type);
                    break;
                case DocType.XLSX:
                    config = excelFactory.CreateConfiguration(type);
                    break;
                case DocType.PDF:
                    config = pdfFactory.CreateConfiguration(type);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Console.Clear();
            Console.WriteLine(config.ToString());
            Console.ReadLine();
        }

        
    }
}
