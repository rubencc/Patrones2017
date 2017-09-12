using Business.Interfaces;

namespace Business.Implementations
{
    public class WordDocConfigurationFactory :AbstractFactory
    {
        protected override string GetFont()
        {
            return "Arial";
        }

        protected override string GetPadding()
        {
            return "1";
        }

        public override bool IsValidFor(DocType type)
        {
            return DocType.DOC == type || DocType.DOCX == type;
        }
    }
}
