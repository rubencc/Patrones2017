namespace Business.Implementations
{
    public class PdfDocConfigurationFactory : AbstractFactory
    {
        protected override string GetFont()
        {
            return "Times";
        }

        protected override string GetPadding()
        {
            return "2";
        }
    }
}
