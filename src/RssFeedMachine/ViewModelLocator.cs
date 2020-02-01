using LightInject;
using RssFeedMachine.IoC;
using RssFeedMachine.ViewModels.Interfaces;

namespace RssFeedMachine
{
    public class ViewModelLocator
    {
        public IMainViewModel MainViewModel => DependencyRegistration.Container.GetInstance<IMainViewModel>();
        public IFeedListViewModel FeedListViewModel => DependencyRegistration.Container.GetInstance<IFeedListViewModel>();
        public IAddFeedViewModel AddFeedViewModel => DependencyRegistration.Container.GetInstance<IAddFeedViewModel>();
    }
}