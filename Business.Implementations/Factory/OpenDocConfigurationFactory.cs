using System.Collections.Generic;
using Business.Interfaces;

namespace Business.Implementations
{
    public class OpenDocConfigurationFactory : AbstractFactory
    {
        public OpenDocConfigurationFactory(IEnumerable<IExtensionStrategy> strategies) : base(strategies)
        {
        }

        protected override string GetFont()
        {
            return "Times";
        }

        protected override string GetPadding()
        {
            return "0";
        }

        protected override string GetExtension(DocType type)
        {
            return "odf";
        }

        public override bool IsValidFor(DocType type)
        {
            return DocType.ODF == type;
        }
    }
}
