using Avalonia;
using Avalonia.Controls;
using Provalenko43P_UP.ViewModels;
using Avalonia.Markup.Xaml;

namespace Provalenko43P_UP;

public partial class AddUpdate : UserControl
{
    public AddUpdate()
    {
        InitializeComponent();
        DataContext = new AddUpdateVM();
    }

    public AddUpdate(int id)
    {
        InitializeComponent();
        DataContext = new AddUpdateVM(id);
    }
}