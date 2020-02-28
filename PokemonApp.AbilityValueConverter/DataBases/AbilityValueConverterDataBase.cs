using PokemonApp.DataBase.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.AbilityValueConverter.DataBases
{
    public static class AbilityValueConverterDataBase
    {
        public static IEnumerable<string> FindPokemon(LocalDbContext context)
        {
            var query = from pokemons in context.pokemons
                        select pokemons.name;
            return query.AsEnumerable();
        }
    }
}
