using Autofac;
using Business.Interfaces;
using ConfigurationIoC;

namespace Business.Implementations
{
    public class Initialize :IConfigIoC
    {
        public void Configure(ContainerBuilder container)
        {
            container.RegisterType<ExcelDocConfigurationFactory>().As<IDocConfigurationFactory>();
            container.RegisterType<MarkDocConfigurationFactory>().As<IDocConfigurationFactory>();
            container.RegisterType<PdfDocConfigurationFactory>().As<IDocConfigurationFactory>();
            container.RegisterType<WordDocConfigurationFactory>().As<IDocConfigurationFactory>();
            container.RegisterType<OpenDocConfigurationFactory>().As<IDocConfigurationFactory>();

            container.RegisterType<CsvExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<DocExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<DocxExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<JsonExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<PdfExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<XlsExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<XlsxExtensionStrategy>().As<IExtensionStrategy>();
            container.RegisterType<XmlExtensionStrategy>().As<IExtensionStrategy>();
        }
    }
}
