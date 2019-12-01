using PokemonApp.WildArea.ViewModels;
using PokemonApp.WildArea.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.WildArea
{
    public class WildAreaModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("WildAreaUraraka", typeof(WildAreaUraraka));
            regionManager.RegisterViewWithRegion("WildAreaKomorebi", typeof(WildAreaKomorebi));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<WildAreaView, WildAreaViewModel>();
            //containerRegistry.RegisterForNavigation<WildAreaUraraka, WildAreaUrarakaViewModel>();
            //containerRegistry.RegisterForNavigation<WildAreaKomorebi, WildAreaKomorebiViewModel>();
        }
    }
}