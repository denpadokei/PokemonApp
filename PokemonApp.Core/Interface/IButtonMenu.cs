using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Interface
{
    public interface IButtonMenu
    {
        string Name { get; set; }

        DelegateCommand Command { get; set; }

        void OpenWindow();
    }
}
