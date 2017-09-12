using Business.Interfaces;

namespace Business.Implementations
{
    public class CsvExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "csv";
        public DocType Type => DocType.CSV;
    }
}
