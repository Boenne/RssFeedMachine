using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using RssFeedMachine.ViewModels.Interfaces;

namespace RssFeedMachine.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        public ICommand LoadedCommand => new RelayCommand(async () => await Loaded());

        public async Task Loaded()
        {
            //TODO load data from repo
        }
    }
}