using PokemonApp.Damage.Views;
using PokemonApp.WildArea.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand OpenCommand { get; private set; }
        public DelegateCommand WildAreaCommand { get; private set; }

        private void Open()
        {
            this.dialog_.Show(nameof(DamageWindow), new DialogParameters(), _ => { });
        }
        private void OpenWildArea()
        {
            this.dialog_.Show(nameof(WildAreaView), new DialogParameters(), _ => { });
        }

        private readonly IDialogService dialog_;

        public MainWindowViewModel(IDialogService service)
        {
            this.OpenCommand = new DelegateCommand(this.Open);
            this.WildAreaCommand = new DelegateCommand(this.OpenWildArea);
            this.dialog_ = service;
        }
    }
}
