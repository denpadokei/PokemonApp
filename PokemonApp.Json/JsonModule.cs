using PokemonApp.Json.ViewModels;
using PokemonApp.Json.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.Json
{
    public class JsonModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("Pokemon", typeof(JsonPokemonView));
            regionManager.RegisterViewWithRegion("Trick", typeof(JsonTrickView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<JsonSerchBaseView, JsonSerchBaseViewModel>();
            containerRegistry.RegisterForNavigation<JsonTrickView>();
            containerRegistry.RegisterForNavigation<JsonPokemonView>();
        }
    }
}