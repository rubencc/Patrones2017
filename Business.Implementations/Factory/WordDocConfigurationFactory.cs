using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business.Implementations
{
    public class WordDocConfigurationFactory :AbstractFactory
    {
        public override IDocConfiguration CreateConfiguration(DocType type)
        {
            return this.Create(type);
        }

        private IDocConfiguration Create(DocType type)
        {
            IDocConfiguration config = new DocConfiguration();

            config.Font = "Arial";
            config.Owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            config.Hash = this.CalculateHash($"{config.Owner} - {DateTime.UtcNow}");
            config.Extension = type == DocType.DOC ? "doc" : "docx";
            config.Padding = "1";
            config.Type = type;

            return config;
        }
    }
}
