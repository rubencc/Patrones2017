using Business.Interfaces;

namespace Business.Implementations
{
    public class ExcelDocConfigurationFactory : AbstractFactory
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
            return type == DocType.XLS ? "xls" : "xlsx";
        }
    }
}
