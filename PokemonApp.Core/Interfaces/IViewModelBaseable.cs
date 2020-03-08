using PokemonApp.Core.Models;
using Prism.Services.Dialogs;
using System;
using System.ComponentModel;

namespace PokemonApp.Core.Interfaces
{
    public interface IViewModelBaseable : IInitialize, IDisposable, IDialogAware, INotifyPropertyChanged
    {
        bool IsOpen { get; set; }
        bool IsLoading { get; set; }
        object CurrentView { get; set; }
        Master Master { get; }
    }
}
