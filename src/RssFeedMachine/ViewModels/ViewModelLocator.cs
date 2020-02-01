using LightInject;
using RssFeedMachine.IoC;

namespace RssFeedMachine.ViewModels
{
    public class ViewModelLocator
    {
        public IMainViewModel MainViewModel => DependencyRegistration.Container.GetInstance<IMainViewModel>();
    }
}