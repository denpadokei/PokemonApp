﻿using Prism.Ioc;
using Prism.Modularity;

namespace PokemonApp.Style
{
    public class StyleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterDialogWindow<TabWindow>();
        }
    }
}