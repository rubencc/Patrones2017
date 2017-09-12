using Business.Interfaces;

namespace Business.Implementations
{
    public class XlsxExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "xslx";
        public DocType Type => DocType.XLSX;
    }
}
