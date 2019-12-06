using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Interface
{
    public interface IDataBaseService
    {
        void Regist(Func<bool> func);
        void Load(Action action);
    }
}
