using Prism.Ioc;
using Prism.Modularity;

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