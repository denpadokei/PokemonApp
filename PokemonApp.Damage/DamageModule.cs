using PokemonApp.Damage.ViewModels;
using PokemonApp.Damage.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.Damage
{
    public class DamageModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<DamageSimView, DamageSimViewModel>(nameof(DamageSimView));
        }
    }
}