using System;

namespace PokemonApp.Core.Interfaces
{
    public interface IDataBaseService
    {
        bool IsLoading { get; set; }
        void Regist(Func<bool> func);
        void Load(Action action);
    }
}
