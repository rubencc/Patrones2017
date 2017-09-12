namespace Business.Implementations
{
    public class MarkDocConfigurationFactory : AbstractFactory
    {
        protected override string GetFont()
        {
            return "Arial";
        }

        protected override string GetPadding()
        {
            return "0";
        }
    }
}
