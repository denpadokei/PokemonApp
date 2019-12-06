using PokemonApp.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;
using PokemonApp.Core;
using PokemonApp.Damage;
using PokemonApp.WildArea;
using PokemonApp.PictureBook;
using Prism.Regions;
using PokemonApp.Main.Views;
using PokemonApp.PictureBook.Views;
using PokemonApp.Main;
using PokemonApp.WindowManage;
using Prism.Services.Dialogs;
using PokemonApp.AbilityValueConverter;
using PokemonApp.Json;

namespace PokemonApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication 
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            var region = this.Container.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("ShellRegion", typeof(MainWindowView));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialogWindow<CustomDialogWindow>();
            containerRegistry.RegisterDialog<ConfirmationWindowView>();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<CoreModule>();
            moduleCatalog.AddModule<DamageModule>();
            moduleCatalog.AddModule<WildAreaModule>();
            moduleCatalog.AddModule<PictureBookModule>();
            moduleCatalog.AddModule<MainModule>();
            moduleCatalog.AddModule<WindowModule>();
            moduleCatalog.AddModule<AbilityValueConverterModule>();
            moduleCatalog.AddModule<JsonModule>();
        }
    }
}
