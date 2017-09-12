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
            
            DocType type = (DocType)Enum.Parse(typeof(DocType), key, true);
            switch (type)
            {
                case DocType.XML:
                    config = SetConfiguration("xml", "0", DocType.XML);
                    break;
                case DocType.CSV:
                    config = SetConfiguration("csv", "0", DocType.CSV);
                    break;
                case DocType.JSON:
                    config = SetConfiguration("json", "0", DocType.JSON);
                    break;
                case DocType.DOC:
                    config = SetConfiguration("doc", "1", DocType.DOC);
                    break;
                case DocType.DOCX:
                    config = SetConfiguration("docx", "1", DocType.DOCX);
                    break;
                case DocType.XLS:
                    config = SetConfiguration("xls", "1", DocType.XLS);
                    break;
                case DocType.XLSX:
                    config = SetConfiguration("xlsx", "1", DocType.XLSX);
                    break;
                case DocType.PDF:
                    config = SetConfiguration("pfd", "2", DocType.PDF);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine(config.ToString());
        }

        private static IDocConfiguration SetConfiguration(string extension, string padding, DocType type)
        {
            IDocConfiguration config = CreateConfiguration();

            config.Extension = extension;
            config.Padding = padding;
            config.Type = type;

            return config;
        }

        private static IDocConfiguration CreateConfiguration()
        {
            IDocConfiguration config = new DocConfiguration();

            config.Font = "Arial";
            config.Owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            config.Hash = CalculateHash($"{config.Owner} - {DateTime.UtcNow}");

            return config;
        }

        private static string CalculateHash(string input)
        {
            byte[] hash;
            using (MD5 md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            }

            StringBuilder sb = new StringBuilder();

            foreach (byte t in hash)
            {
                sb.Append(t.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
