using Microsoft.EntityFrameworkCore;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;
using Provalenko43P_UP.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provalenko43P_UP.ViewModels
{
    public class ProductsVM : ViewModelBase
    {
        private List<PartnerProduct> part;

        private Partner _part;

        public List<PartnerProduct> Part { get => part; set { this.RaiseAndSetIfChanged(ref part, value); } }

        public Partner Part1 { get => _part; set => _part = value; }

        public ProductsVM(int id)
        {
            Part = MainWindowViewModel.connection.PartnerProducts.Where(x => x.IdPartner == id).Include(x => x.IdPartnerNavigation).Include(x => x.IdProductNavigation).ToList();
            Part1 = MainWindowViewModel.connection.Partners.FirstOrDefault(x => x.Id == id);
        }

        public async void Back()
        {
            ButtonResult result = await MessageBoxManager.GetMessageBoxStandard("Вы уверенны?", "Вы хотите покинуть страницу?", ButtonEnum.YesNo).ShowAsync();
            if (result == ButtonResult.Yes)
            {
                MainWindowViewModel.Instance.Page1 = new Show();
            }
            else
            { }

        }
    }
}
