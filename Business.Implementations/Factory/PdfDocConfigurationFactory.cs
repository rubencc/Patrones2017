using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business.Implementations
{
    public class PdfDocConfigurationFactory : AbstractFactory
    {
        public override IDocConfiguration CreateConfiguration(DocType type)
        {
            return this.Create(type);
        }

        private IDocConfiguration Create(DocType type)
        {
            IDocConfiguration config = new DocConfiguration();

            config.Font = "Times";
            config.Owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            config.Hash = this.CalculateHash($"{config.Owner} - {DateTime.UtcNow}");
            config.Extension = "pdf";
            config.Padding = "2";
            config.Type = type;

            return config;
        }
    }
}
