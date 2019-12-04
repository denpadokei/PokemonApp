using PokemonApp.Main.ViewModels;
using PokemonApp.Main.Views;
using PokemonApp.PictureBook.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //var region = containerProvider.Resolve<IRegionManager>();
            //region.RegisterViewWithRegion("ShellRegion", typeof(MainWindowView));
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindowView, MainWindowViewModel>(nameof(MainWindowView));
            containerRegistry.Register<MainWindowButtonViewModel>();
        }
    }
}