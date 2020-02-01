using LightInject;
using RssFeedMachine.ViewModels;

namespace RssFeedMachine.IoC
{
    public class DependencyRegistration
    {
        public static ServiceContainer Container { get; set; }

        public static void Register()
        {
            var serviceContainer = new ServiceContainer();
            serviceContainer.Register<IMainViewModel, MainViewModel>();
            Container = serviceContainer;
        }
    }
}