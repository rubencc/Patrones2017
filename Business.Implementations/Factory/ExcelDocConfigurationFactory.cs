using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business.Implementations
{
    public class ExcelDocConfigurationFactory : IDocConfigurationFactory
    {
        public IDocConfiguration CreateConfiguration(DocType type)
        {
            return this.Create(type);
        }

        private IDocConfiguration Create(DocType type)
        {
            IDocConfiguration config = new DocConfiguration();

            config.Font = "Arial";
            config.Owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            config.Hash = this.CalculateHash($"{config.Owner} - {DateTime.UtcNow}");
            config.Extension = type == DocType.XLS ? "xls" : "xlsx";
            config.Padding = "1";
            config.Type = type;

            return config;
        }

        private string CalculateHash(string input)
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
