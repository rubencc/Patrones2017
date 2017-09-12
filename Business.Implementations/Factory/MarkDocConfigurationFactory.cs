using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business.Implementations
{
    public class MarkDocConfigurationFactory : AbstractFactory
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

            switch (type)
            {
                case DocType.XML:
                    config.Extension = "xml";
                    break;
                case DocType.CSV:
                    config.Extension = "csv";
                    break;
                case DocType.JSON:
                    config.Extension = "json";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            config.Padding = "0";
            config.Type = type;

            return config;
        }
    }
}
