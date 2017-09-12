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
    }
}
