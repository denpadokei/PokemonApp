using System.Threading.Tasks;
using System.Windows;

namespace PokemonApp.Core.Interfaces
{
    public interface ICustomDialogService
    {
        bool IsOpen { get; set; }
        Task<bool> ShowMessege(string messege, string identifir = "");
        Task ShowProgress();
        void CloseDialog(object parameter, IInputElement target);
    }
}
