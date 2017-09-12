using Autofac;

namespace ConfigurationIoC
{
    public interface IConfigIoC
    {
        void Configure(ContainerBuilder container);
    }
}
