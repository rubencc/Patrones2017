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

        protected override string GetExtension(DocType type)
        {
            return type == DocType.DOC ? "doc" : "docx";
        }
    }
}
