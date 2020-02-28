using PokemonApp.Core.Enums;
using PokemonApp.DataBase.Models;
using PokemonApp.PictureBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.PictureBook.DataBase
{
    public static class PictureBookDataBase
    {
        public static List<PokemonEntity> FindPokemon(LocalDbContext context)
        {
            var query = (from pokemon in context.pokemons
                         join type1 in context.types on pokemon.type_1_id equals type1.type_id
                         let type2 = context.types.FirstOrDefault(x => x.type_id == pokemon.type_2_id)
                         let characteristic1 = context.characteristics.FirstOrDefault(x => pokemon.characteristic1_id == x.characteristic_id)
                         let characteristic2 = context.characteristics.FirstOrDefault(x => x.characteristic_id == pokemon.characteristic2_id)
                         let dreamcharacteristic = context.characteristics.FirstOrDefault(x => x.characteristic_id == pokemon.dream_characteristic_id)
                         select new PokemonEntity()
                         {
                             Id = pokemon.pokemon_id,
                             No = pokemon.pokemon_no,
                             Name = pokemon.name,
                             Height = pokemon.height,
                             Weight = pokemon.weight,
                             Type1 = type1.type_name,
                             Type2 = type2.type_name ?? "",
                             Characteristic1 = characteristic1.characteristic_name ?? "",
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


        public static List<TrickEntity> FindTrickList(LocalDbContext context)
        {
            var query = (from trick in context.tricks
                         let type = context.types.FirstOrDefault(x => x.type_id == trick.type_id)
                         select new TrickEntity()
                         {
                             TrickId = trick.trick_id,
                             Name = trick.trick_name,
                             Type = type.type_name,
                             Power = trick.power,
                             Rate = trick.accuracy_rate,
                             CategoryAttribute = (CategoryAttribute)trick.attribute,
                             Detial = trick.detial
                         }).OrderBy(x => x.Name);
            return query.ToList();
        }

        public static TrickEntity FindTrick(LocalDbContext context, int trickId)
        {
            var query = (from trick in context.tricks.Where(x => x.trick_id == trickId)
                         join type in context.types on trick.type_id equals type.type_id
                         select new TrickEntity()
                         {
                             TrickId = trick.trick_id,
                             Name = trick.trick_name,
                             Power = trick.power,
                             Rate = trick.accuracy_rate,
                             Type = type.type_name,
                             CategoryAttribute = (CategoryAttribute)trick.attribute
                         }).FirstOrDefault();
            return query;
        }


        public static List<TypeEntity> FindType(LocalDbContext context)
        {
            var query = from type in context.types
                        select new TypeEntity()
                        {
                            Name = type.type_name
                        };
            return query.ToList();
        }

        public static List<CharacteristicEntity> FindCharacteristic(LocalDbContext context)
        {
            var query = from characteristic in context.characteristics
                        select new CharacteristicEntity()
                        {
                            Name = characteristic.characteristic_name,
                        };
            return query.ToList();
        }


        public static List<LinkTrickEntity> FindLearnTrick(LocalDbContext context, int pokemonId)
        {
            var query = (from linktrick in context.link_tricks
                         join trick in context.tricks on linktrick.trick_id equals trick.trick_id
                         join type in context.types on trick.type_id equals type.type_id
                         where linktrick.pokemon_id == pokemonId
                         select new LinkTrickEntity()
                         {
                             LinkTrickId = linktrick.trick_id,
                             TrickEntity = new TrickEntity()
                             {
                                 TrickId = trick.trick_id,
                                 Name = trick.trick_name,
                                 Power = trick.power,
                                 Rate = trick.accuracy_rate,
                                 Type = type.type_name,
                                 CategoryAttribute = (CategoryAttribute)trick.attribute,
                             },
                             Level = 10,
                         });

            return query.ToList();
        }

        public static List<PokemonEntity> FindLinkPokemon(LocalDbContext context, int moveId)
        {
            var query = (from linkmove in context.link_tricks
                         join pokemon in context.pokemons on linkmove.pokemon_id equals pokemon.pokemon_id
                         join type1 in context.types on pokemon.type_1_id equals type1.type_id
                         join charact1 in context.characteristics on pokemon.characteristic1_id equals charact1.characteristic_id
                         let type2 = context.types.FirstOrDefault(x => x.type_id == pokemon.type_2_id)
                         let charact2 = context.characteristics.FirstOrDefault(x => x.characteristic_id == pokemon.characteristic2_id)
                         let dreamcharact = context.characteristics.FirstOrDefault(x => x.characteristic_id == pokemon.dream_characteristic_id)
                         where linkmove.trick_id == moveId
                         select new PokemonEntity()
                         {
                             Id = pokemon.pokemon_id,
                             No = pokemon.pokemon_no,
                             Name = pokemon.name,
                             Weight = pokemon.weight,
                             Height = pokemon.height,
                             Type1 = type1.type_name,
                             Type2 = type2.type_name,
                             Characteristic1 = charact1.characteristic_name,
                             Characteristic2 = charact2.characteristic_name,
                             DreamCharacteristic = dreamcharact.characteristic_name,
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
