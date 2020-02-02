using LightInject;
using RssFeedMachine.Data.Repositories;
using RssFeedMachine.Data.Repositories.Interfaces;
using RssFeedMachine.Services;
using RssFeedMachine.Services.Interfaces;
using RssFeedMachine.ViewModels;
using RssFeedMachine.ViewModels.Interfaces;
using RssFeedMachine.Wrappers;
using RssFeedMachine.Wrappers.Interfaces;
using RssFeedMachine.Wrappers.Messenger;

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
            RegisterRepositories(serviceContainer);
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
            serviceContainer.Register<IDispatcherWrapper, DispatcherWrapper>();
            serviceContainer.Register<IMessenger, Messenger>();
            serviceContainer.Register<IFeedReaderService, FeedReaderService>();
        }

        private static void RegisterRepositories(ServiceContainer serviceContainer)
        {
            serviceContainer.Register<IFeedRepository, FeedRepository>();
        }
    }
}