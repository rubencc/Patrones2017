namespace Business.Interfaces
{
    public interface IDocConfigurationFactory
    {
        IDocConfiguration CreateConfiguration(DocType type);
        bool IsValidFor(DocType type);
    }
}
