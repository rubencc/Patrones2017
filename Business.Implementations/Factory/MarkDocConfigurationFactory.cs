using System.Collections.Generic;
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

        public override bool IsValidFor(DocType type)
        {
            return DocType.CSV == type || DocType.JSON == type || DocType.XML == type;
        }

        public MarkDocConfigurationFactory(IEnumerable<IExtensionStrategy> strategies) : base(strategies)
        {
        }
    }
}
