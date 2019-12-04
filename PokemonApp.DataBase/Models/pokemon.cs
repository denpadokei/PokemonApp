using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.DataBase.Models
{
    [Table(Name = "pokemon")]
    public class pokemon
    {
        [Column(Name = "pokemon_id", IsPrimaryKey = true, CanBeNull = false)]
        public int Id { get; set; }
        [Column(Name = "pokemon_no", CanBeNull = false)]
        public string No { get; set; }
        [Column(Name = "name", CanBeNull = false)]
        public string Name { get; set; }
        [Column(Name = "type_1_id", CanBeNull = false)]
        public int Type1 { get; set; }
        [Column(Name = "type_2_id", CanBeNull = true)]
        public int? Type2 { get; set; }
        [Column(Name = "characteristic1_id", CanBeNull = false)]
        public int Characteristic1 { get; set; }
        [Column(Name = "characteristic2_id", CanBeNull = true)]
        public int? Characteristic2 { get; set; }
        [Column(Name = "dream_characteristic_id", CanBeNull = true)]
        public int? DreamCharacteristic { get; set; }
        [Column(Name = "hp", CanBeNull = false)]
        public int Hp { get; set; }
        [Column(Name = "attack", CanBeNull = false)]
        public int Attack { get; set; }
        [Column(Name = "block", CanBeNull = false)]
        public int Block { get; set; }
        [Column(Name = "contact", CanBeNull = false)]
        public int Contact { get; set; }
        [Column(Name = "defence", CanBeNull = false)]
        public int Defence { get; set; }
        [Column(Name = "speed", CanBeNull = false)]
        public int Speed { get; set; }
    }
}
