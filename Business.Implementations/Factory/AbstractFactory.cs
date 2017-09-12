using System;
using System.Security.Cryptography;
using System.Text;
using Business.Interfaces;

namespace Business.Implementations
{
    public abstract class AbstractFactory : IDocConfigurationFactory
    {
        public IDocConfiguration CreateConfiguration(DocType type)
        {
            IDocConfiguration config = new DocConfiguration();

            config.Font = this.GetFont();
            config.Padding = this.GetPadding();
            config.Owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            config.Hash = this.CalculateHash($"{config.Owner} - {DateTime.UtcNow}");
            config.Extension = this.GetExtension(type);
            config.Type = type;
            return config;
        }

        protected abstract string GetFont();

        protected abstract string GetPadding();
        protected abstract string GetExtension(DocType type);


        protected virtual string CalculateHash(string input)
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
