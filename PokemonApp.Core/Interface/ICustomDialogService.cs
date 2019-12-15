using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PokemonApp.Core.Interface
{
    public interface ICustomDialogService
    {
        bool IsOpen { get; set; }
        Task<bool> ShowMessege(string messege, string identifir = "");
        Task ShowProgress();
        void CloseDialog(object parameter, IInputElement target);
    }
}
