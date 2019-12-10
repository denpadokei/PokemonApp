using PokemonApp.Style.Controls;
using PokemonApp.Style.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.Style
{
    public class StyleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<CustomDataGrid>();
        }
    }
}