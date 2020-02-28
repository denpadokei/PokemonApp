using Prism.Commands;

namespace PokemonApp.Core.Interfaces
{
    public interface IButtonMenu
    {
        string Name { get; set; }

        DelegateCommand Command { get; set; }

        void OpenWindow();
    }
}
