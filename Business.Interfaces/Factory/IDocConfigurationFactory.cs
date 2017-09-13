using System;

namespace Business.Interfaces
{
    public interface IDocConfigurationFactory : IDisposable
    {
        IDocConfiguration CreateConfiguration(DocType type);
        bool IsValidFor(DocType type);
    }
}
