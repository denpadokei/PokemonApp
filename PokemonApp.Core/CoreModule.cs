using Dragablz;
using PokemonApp.Core.Dialogs;
using PokemonApp.Core.Interfaces;
using PokemonApp.Core.Models;
using PokemonApp.Core.Services;
using Prism.Ioc;
using Prism.Modularity;

namespace PokemonApp.Core
{
    public class CoreModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IWindowManagerService, WindowManagerService>();
            containerRegistry.Register<IDataBaseService, DataBaseService>();
            containerRegistry.Register<IInterTabClient, InterTabClient>();
            containerRegistry.Register<ICustomDialogService, CustomDialogService>();
            containerRegistry.RegisterDialog<ConfirmationWindowView>();
            containerRegistry.RegisterDialogWindow<TabWindow>();
        }
    }
}