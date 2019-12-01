using Prism.Ioc;
using Prism.Modularity;
using PokemonApp.Damage.Views;
using PokemonApp.Damage.ViewModels;

namespace PokemonApp.Damage
{
    public class DamageModule : IModule
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
