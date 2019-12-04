using PokemonApp.AbilityValueConverter.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.AbilityValueConverter
{
    public class AbilityValueConverterModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<AbilityValueConverterView>(nameof(AbilityValueConverterView));
        }
    }
}