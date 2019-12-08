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
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("PictureBookRegion", typeof(PictureBookView));
            region.RegisterViewWithRegion("TrickRegion", typeof(TrickView));
            region.RegisterViewWithRegion("CharacteristicRegion", typeof(CharacteristicView));
            region.RegisterViewWithRegion("TypeRegion", typeof(TypesView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<PokemonDataView, PokemonDataViewModel>(nameof(PokemonDataView));
            containerRegistry.RegisterDialog<LearnTrickLink, LearnTrickLinkViewModel>(nameof(LearnTrickLink));
            containerRegistry.RegisterForNavigation<PictureBookView>();
        }
    }
}