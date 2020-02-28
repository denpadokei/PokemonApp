using System.ComponentModel;

namespace PokemonApp.Core.Interfaces
{
    public interface IOpend : INotifyPropertyChanged
    {
        bool IsOpen { get; set; }
        bool IsLoading { get; set; }
    }
}
