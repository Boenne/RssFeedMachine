using LightInject;
using RssFeedMachine.ViewModels;
using RssFeedMachine.ViewModels.Interfaces;
using RssFeedMachine.Wrappers;

namespace RssFeedMachine.IoC
{
    public class DependencyRegistration
    {
        public static ServiceContainer Container { get; set; }

        public static void Register()
        {
            var serviceContainer = new ServiceContainer();
            RegisterViewModels(serviceContainer);
            RegisterServices(serviceContainer);
            Container = serviceContainer;
        }

        private static void RegisterViewModels(ServiceContainer serviceContainer)
        {
            serviceContainer.Register<IMainViewModel, MainViewModel>();
            serviceContainer.Register<IFeedListViewModel, FeedListViewModel>();
            serviceContainer.Register<IAddFeedViewModel, AddFeedViewModel>();
        }

        private static void RegisterServices(ServiceContainer serviceContainer)
        {
            serviceContainer.Register<IMessageBoxWrapper, MessageBoxWrapper>();
        }
    }
}