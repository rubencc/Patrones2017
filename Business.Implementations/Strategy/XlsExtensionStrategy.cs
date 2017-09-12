using Business.Interfaces;

namespace Business.Implementations
{
    public class XlsExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "xls";
        public DocType Type => DocType.XLS;
    }
}
