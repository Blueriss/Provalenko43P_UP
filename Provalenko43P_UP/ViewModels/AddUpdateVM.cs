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
using Tmds.DBus.Protocol;

namespace Provalenko43P_UP.ViewModels
{
    public class AddUpdateVM : ViewModelBase
    {
        private Partner newPartner;
        private String textButton;
        private String message;
        private String message1;
        private String textPage;
        public Partner NewPartner { get => newPartner; set {this.RaiseAndSetIfChanged(ref newPartner, value); } }

        public List<PartnerType> types => MainWindowViewModel.connection.PartnerTypes.ToList();

        public string TextButton { get => textButton; set => textButton = value; }
        public string TextPage { get => textPage; set => textPage = value; }
        public string Message { get => message; set => message = value; }
        public string Message1 { get => message1; set => message1 = value; }

        public AddUpdateVM()
        {
            NewPartner = new Partner();
            TextButton = "Добавить";
            TextPage = "Добавление";
            Message = "Вы точно хотите добавить партнёра?";
            Message1 = "Партнёр " + NewPartner.Name + " добавлен";
        }

        public AddUpdateVM(int id)
        {
            NewPartner = MainWindowViewModel.connection.Partners.Include(x => x.TypeNavigation).FirstOrDefault(x => x.Id == id);
            TextButton = "Изменить";
            TextPage = "Изменение";
            Message = "Вы точно хотите изменить партнёра " + NewPartner.Name + "?";
            Message1 = "Партнёр " + NewPartner.Name + " изменён";
        }

        public async void Add()
        {
            if (NewPartner.Rating >= 0)
            {
                ButtonResult result = await MessageBoxManager.GetMessageBoxStandard("Вы уверенны?", Message, ButtonEnum.YesNo).ShowAsync();
            if (result == ButtonResult.Yes)
            {
                
                    if (NewPartner.Id == 0)
                    {
                        MainWindowViewModel.connection.Partners.Add(newPartner);
                    }
                    MainWindowViewModel.connection.SaveChanges();
                    MainWindowViewModel.Instance.Page1 = new Show();
                    ButtonResult result1 = await MessageBoxManager.GetMessageBoxStandard("Успешно", Message1, ButtonEnum.Ok).ShowAsync();
                }
                else
                {
                  
                }
            }
            else { ButtonResult result1 = await MessageBoxManager.GetMessageBoxStandard("Ошибка", "Вы ввели отрицательный рейтинг.", ButtonEnum.Ok).ShowAsync(); }          

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
