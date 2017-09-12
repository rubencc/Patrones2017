using Business.Interfaces;

namespace Business.Implementations
{
    public class DocExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "doc";
        public DocType Type => DocType.DOC;
    }
}
