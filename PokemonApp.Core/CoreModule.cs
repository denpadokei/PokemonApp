using Prism.Ioc;
using Prism.Modularity;
using PokemonApp.Core.Views;
using PokemonApp.Core.ViewModels;

namespace PokemonApp.Core
{
    public class CoreModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
