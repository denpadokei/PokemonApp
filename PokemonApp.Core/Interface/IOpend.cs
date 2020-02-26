using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Interface
{
    public interface IOpend : INotifyPropertyChanged
    {
        bool IsOpen { get; set; }
        bool IsLoading { get; set; }
    }
}
