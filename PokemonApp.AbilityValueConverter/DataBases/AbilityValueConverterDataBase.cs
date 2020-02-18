using PokemonApp.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
