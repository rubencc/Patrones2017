using Business.Interfaces;

namespace Business.Implementations
{
    public class XmlExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "xml";
        public DocType Type => DocType.XML;
    }
}
