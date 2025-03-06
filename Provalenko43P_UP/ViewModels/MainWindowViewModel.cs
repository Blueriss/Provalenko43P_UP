using Avalonia.Controls;
using Provalenko43P_UP.Models;
using ReactiveUI;

namespace Provalenko43P_UP.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static MainWindowViewModel Instance;

        public static PostgresContext connection = new PostgresContext();

        public MainWindowViewModel()
        {
            Instance = this;
        }

        UserControl page = new Show();

        public UserControl Page1
        {
            get => page;
            set { this.RaiseAndSetIfChanged(ref page, value); }
        }
    }
}
