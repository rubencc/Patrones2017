using Business.Interfaces;

namespace Business.Implementations.Strategy
{
    public class CsvExtensionStrategy : IExtensionStrategy
    {
        public string Extension => "csv";
        public DocType Type => DocType.CSV;
    }
}
