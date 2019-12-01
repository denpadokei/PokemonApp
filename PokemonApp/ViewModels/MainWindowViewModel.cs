using PokemonApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PokemonApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }




        private DelegateCommand _openWindow;
        public DelegateCommand OpenWindowCommand { get { return this._openWindow ?? new DelegateCommand(this.OpenWindow); } }

        private void OpenWindow()
        {
            this.dialogservice_.Show(nameof(DamageUserControl), new DialogParameters(), _ => { });
        }

        private readonly IDialogService dialogservice_;

        public MainWindowViewModel(IDialogService service)
        {
            this.dialogservice_ = service;
        }
    }
}
