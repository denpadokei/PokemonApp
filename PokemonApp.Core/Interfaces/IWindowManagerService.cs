using Prism.Services.Dialogs;
using System;

namespace PokemonApp.Core.Interfaces
{
    public interface IWindowManagerService
    {
        IDialogService DialogService { get; set; }
        ICustomDialogService CustomDialogService { get; set; }
        void Show(string windowname, IDialogParameters parameter, Action<IDialogResult> action);
        void Show(object viewmodel, string title, string content);
        void ShowMessage(string message);
        void ShowDialog(string windowname, IDialogParameters parameter, Action<IDialogResult> action);
    }
}
