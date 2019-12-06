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
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<JsonSerchView, JsonSerchViewModel>();
        }
    }
}