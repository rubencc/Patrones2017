using Business.Interfaces;

namespace Business.Implementations
{
    public class DocxExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "docx";
        public DocType Type => DocType.DOCX;
    }
}
