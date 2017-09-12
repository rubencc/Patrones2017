namespace Business.Implementations
{
    public class WordDocConfigurationFactory :AbstractFactory
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
