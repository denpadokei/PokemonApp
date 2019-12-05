using PokemonApp.DataBase.Models;
using PokemonApp.PictureBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.PictureBook.DataBase
{
    public static class PicturBookDataBase
    {
        public static List<PokemonEntity> FindPokemon(LocalDbContext context)
        {
            var query = (from pokemon in context.pokemons
                         join type1 in context.types on pokemon.type_1_id equals type1.type_id
                         let type2 = context.types.FirstOrDefault(x => x.type_id == pokemon.type_2_id)
                         join characteristic1 in context.characteristics on pokemon.characteristic1_id equals characteristic1.characteristic_id
                         let characteristic2 = context.characteristics.FirstOrDefault(x => x.characteristic_id == pokemon.characteristic2_id)
                         let dreamcharacteristic = context.characteristics.FirstOrDefault(x => x.characteristic_id == pokemon.dream_characteristic_id)
                         select new PokemonEntity()
                         {
                             No = pokemon.pokemon_no,
                             Name = pokemon.name,
                             Height = pokemon.height,
                             Weight = pokemon.weight,
                             Type1 = type1.type_name,
                             Type2 = type2.type_name ?? "",
                             Characteristic1 = characteristic1.characteristic_name,
                             Characteristic2 = characteristic2.characteristic_name ?? "",
                             DreamCharacteristic = dreamcharacteristic.characteristic_name ?? "",
                             Hp = pokemon.hp,
                             Attack = pokemon.attack,
                             Block = pokemon.block,
                             Contact = pokemon.contact,
                             Defence = pokemon.defence,
                             Speed = pokemon.speed,
                         });
            return query.ToList();
        }
    }
}
