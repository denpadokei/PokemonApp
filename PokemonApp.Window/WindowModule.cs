using PokemonApp.WindowManage;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.WindowManage
{
    public class WindowModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register(typeof(WindowType));
        }
    }
}