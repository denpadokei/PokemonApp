using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.DataBase.Models
{
    [Table(Name = "characteristic")]
    public class characteristic
    {
        [Column(Name = "characteristic_id", IsPrimaryKey = true, CanBeNull = false)]
        public int Id { get; set; }
        [Column(Name = "characteristic_name", CanBeNull = false)]
        public string Name { get; set; }
        [Column(Name = "detials", CanBeNull = false)]
        public string Detials { get; set; }
    }
}
