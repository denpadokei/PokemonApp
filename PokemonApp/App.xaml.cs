using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using PokemonApp.AbilityValueConverter;
using PokemonApp.Core;
using PokemonApp.Damage;
using PokemonApp.Json;
using PokemonApp.Main;
using PokemonApp.Main.Views;
using PokemonApp.PictureBook;
using PokemonApp.Style;
using PokemonApp.Views;
using PokemonApp.WildArea;
using PokemonApp.WindowManage;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System.Windows;

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

        protected override void OnStartup(StartupEventArgs e)
        {
            var primaryColor = SwatchHelper.Lookup[MaterialDesignColor.Grey900];
            var accentColor = SwatchHelper.Lookup[MaterialDesignColor.Lime50];
            var theme = Theme.Create(new MaterialDesignDarkTheme(), primaryColor, accentColor);
            Resources.SetTheme(theme);
            base.OnStartup(e);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
            //containerRegistry.RegisterDialog<ConfirmationWindowView>();
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
            moduleCatalog.AddModule<StyleModule>();
        }
    }
}
