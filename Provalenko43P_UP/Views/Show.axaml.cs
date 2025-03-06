using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Provalenko43P_UP.ViewModels;

namespace Provalenko43P_UP;

public partial class Show : UserControl
{
    public Show()
    {
        InitializeComponent();
        DataContext = new ShowVM();
    }
}