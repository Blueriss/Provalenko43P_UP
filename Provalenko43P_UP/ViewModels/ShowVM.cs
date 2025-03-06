using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;
using Provalenko43P_UP.Models;
using ReactiveUI;

namespace Provalenko43P_UP.ViewModels
{
    public class ShowVM : ViewModelBase
    {
        private List<Partner> part;

        public List<Partner> Part { get => part; set { this.RaiseAndSetIfChanged(ref part, value); } }

        public ShowVM()
        {
            Part = MainWindowViewModel.connection.Partners.Include(x => x.TypeNavigation).Include(x =>x.PartnerProducts).ToList();
        }

        public async void PageAdd()
        {
            ButtonResult result = await MessageBoxManager.GetMessageBoxStandard("Вы уверенны?", "Вы хотите перейти на страницу добавления партнёра?", ButtonEnum.YesNo).ShowAsync();
            if (result == ButtonResult.Yes)
            {
                MainWindowViewModel.Instance.Page1 = new AddUpdate();
            }
            else { }

        }

        public async void PageUpdate(int id)
        {
            ButtonResult result = await MessageBoxManager.GetMessageBoxStandard("Вы уверенны?", "Вы хотите перейти на страницу изменения?", ButtonEnum.YesNo).ShowAsync();
            if (result == ButtonResult.Yes)
            {
                MainWindowViewModel.Instance.Page1 = new AddUpdate(id);
            }
            else
            { }            
        }

        public async void PageProduct(int id)
        {
            ButtonResult result = await MessageBoxManager.GetMessageBoxStandard("Вы уверенны?", "Вы хотите перейти на страницу реализации продукции?", ButtonEnum.YesNo).ShowAsync();
            if (result == ButtonResult.Yes)
            {
                MainWindowViewModel.Instance.Page1 = new Products(id);
            }
            else
            { }
        }
    }
}
