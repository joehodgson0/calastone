using Autofac;
using Services;

namespace TextFilterApplication
{
    internal class ContainerConfiguration
    {
        public static IContainer BuildContainer()
        {
            var containerBuilder = new ContainerBuilder();
            
            containerBuilder.RegisterType<TextFilterApp>().As<ITextFilterApp>();

            containerBuilder.RegisterModule<ServicesAutofacModule>();

            return containerBuilder.Build();
        }
    }
}
