using PokemonApp.PictureBook.ViewModels;
using PokemonApp.PictureBook.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokemonApp.PictureBook
{
    public class PictureBookModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<PictureBookView, PictureBookViewModel>(nameof(PictureBookView));
        }
    }
}