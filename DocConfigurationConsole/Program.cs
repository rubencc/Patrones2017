using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Autofac;
using Business.Interfaces;
using ConfigurationIoC;

namespace DocConfigurationConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            IDocConfiguration config;
            var container = new ContainerBuilder();
            LoadAssemblies(container);
            var builder = container.Build();
            using (var scope = builder.BeginLifetimeScope())
            {
                IEnumerable<IDocConfigurationFactory> factories =
                    scope.Resolve<IEnumerable<IDocConfigurationFactory>>();

                Console.WriteLine("Introduzca un tipo de documento");

                string key = Console.ReadLine();

                DocType type = (DocType)Enum.Parse(typeof(DocType), key, true);

                config = factories.Where(item => item.IsValidFor(type)).FirstOrDefault().CreateConfiguration(type);
            }
       
            Console.Clear();
            Console.WriteLine(config.ToString());
            Console.ReadLine();
        }

        private static void LoadAssemblies(ContainerBuilder container)
        {
            PreloadUnusedAssemblies(AppDomain.CurrentDomain);

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {


                foreach (Type item in assembly.GetTypes())
                {
                    if (!item.IsClass)
                        continue;

                    if (item.IsAbstract)
                        continue;

                    if (item.GetInterfaces().Contains(typeof(IConfigIoC)))
                    {
                        Type[] argTypes = new Type[] { };
                        ConstructorInfo cInfo = item.GetConstructor(argTypes);
                        if (cInfo == null)
                            continue;

                        var config = (IConfigIoC)cInfo.Invoke(new object[] { });
                        config.Configure(container);
                    }
                }
            }
        }

        public static void PreloadUnusedAssemblies(AppDomain appDomain)
        {
            var loaded = appDomain.GetAssemblies();
            var directory = new DirectoryInfo(appDomain.SetupInformation.ApplicationBase);
            var assemblies = directory.GetFiles("*.dll");
            if (!assemblies.Any())
            {
                return;
            }

            foreach (var info in assemblies)
            {
                if (!loaded.Any(assembly => !assembly.IsDynamic && assembly.Location.Contains(info.Name)))
                {
                    appDomain.Load(AssemblyName.GetAssemblyName(info.FullName));
                }
            }
        }

    }
}
