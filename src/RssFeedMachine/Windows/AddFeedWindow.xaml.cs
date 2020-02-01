using System.Windows;
using RssFeedMachine.Wrappers.Interfaces;

namespace RssFeedMachine.Windows
{
    public partial class AddFeedWindow : Window, IClosable
    {
        public AddFeedWindow()
        {
            InitializeComponent();
        }
    }
}