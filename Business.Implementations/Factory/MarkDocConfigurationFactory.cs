using System;
using Business.Interfaces;

namespace Business.Implementations
{
    public class MarkDocConfigurationFactory : AbstractFactory
    {
        protected override string GetFont()
        {
            return "Arial";
        }

        protected override string GetPadding()
        {
            return "0";
        }

        protected override string GetExtension(DocType type)
        {
            switch (type)
            {
                case DocType.XML:
                    return "xml";
                    break;
                case DocType.CSV:
                    return "csv";
                    break;
                case DocType.JSON:
                    return "json";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
