using System.Collections.Generic;
using Business.Interfaces;

namespace Business.Implementations
{
    public class PdfDocConfigurationFactory : AbstractFactory
    {
        protected override string GetFont()
        {
            return "Times";
        }

        protected override string GetPadding()
        {
            return "2";
        }

        public override bool IsValidFor(DocType type)
        {
            return DocType.PDF == type;
        }

        public PdfDocConfigurationFactory(IEnumerable<IExtensionStrategy> strategies) : base(strategies)
        {
        }
    }
}
