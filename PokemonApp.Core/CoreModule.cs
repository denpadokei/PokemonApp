using PokemonApp.Core.Actions;
using PokemonApp.Core.Interface;
using PokemonApp.Core.Models;
using PokemonApp.Core.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.Core
{
    public class CoreModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IWindowManager, WindowManager>();
            containerRegistry.Register<IDataBaseService, DataBaseService>();
        }
    }
}