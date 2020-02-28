using PokemonApp.Json.Models;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PokemonApp.Json.Json
{
    public static class JsonData
    {
        public static List<JsonTrickEntity> FindTrick()
        {
            using (var fs = new FileStream(@".\moves.json", FileMode.Open, FileAccess.Read)) {
                return (List<JsonTrickEntity>)SerializerList<JsonTrickEntity>().ReadObject(fs);
            }
        }

        public static List<JsonPokemonEntity> FindPokemon()
        {
            using (var fs = new FileStream(@".\pokedex.json", FileMode.Open, FileAccess.Read)) {
                return (List<JsonPokemonEntity>)SerializerList<JsonPokemonEntity>().ReadObject(fs);
            }
        }

        /// <summary>
        /// Listオブジェクト用
        /// </summary>
        /// <typeparam name="TYpe">任意の型</typeparam>
        /// <returns></returns>
        public static DataContractJsonSerializer SerializerList<TYpe>() => new DataContractJsonSerializer(typeof(List<TYpe>));
    }
}
