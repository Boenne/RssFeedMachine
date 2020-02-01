using LightInject;
using RssFeedMachine.ViewModels;
using RssFeedMachine.ViewModels.Interfaces;

namespace RssFeedMachine.IoC
{
    public class DependencyRegistration
    {
        public static ServiceContainer Container { get; set; }

        public static void Register()
        {
            var serviceContainer = new ServiceContainer();
            RegisterViewModels(serviceContainer);
            RegisterServices();
            Container = serviceContainer;
        }

        private static void RegisterViewModels(ServiceContainer serviceContainer)
        {
            serviceContainer.Register<IMainViewModel, MainViewModel>();
            serviceContainer.Register<IFeedListViewModel, FeedListViewModel>();
        }

        private static void RegisterServices()
        {
            //TODO register services, repos and whatnot
        }
    }
}