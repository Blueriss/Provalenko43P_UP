using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Provalenko43P_UP.ViewModels;

namespace Provalenko43P_UP;

public partial class Products : UserControl
{
    public Products(int id)
    {
        InitializeComponent();
        DataContext = new ProductsVM(id);
    }
}