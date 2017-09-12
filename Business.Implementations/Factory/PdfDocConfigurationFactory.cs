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

        protected override string GetExtension(DocType type)
        {
            return "pdf";
        }
    }
}
