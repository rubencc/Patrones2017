using Business.Interfaces;

namespace Business.Implementations
{
    public class PdfExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "pdf";
        public DocType Type => DocType.PDF;
    }
}
