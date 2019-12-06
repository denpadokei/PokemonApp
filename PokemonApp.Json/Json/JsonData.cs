using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using PokemonApp.Json.Models;
using Newtonsoft.Json;

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

        /// <summary>
        /// Listオブジェクト用
        /// </summary>
        /// <typeparam name="TYpe">任意の型</typeparam>
        /// <returns></returns>
        public static DataContractJsonSerializer SerializerList<TYpe>() => new DataContractJsonSerializer(typeof(List<TYpe>));
    }
}
