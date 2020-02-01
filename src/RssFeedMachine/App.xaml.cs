using System.Windows;
using RssFeedMachine.IoC;

namespace RssFeedMachine
{
    public partial class App : Application
    {
        public App()
        {
            DependencyRegistration.Register();
        }
    }
}