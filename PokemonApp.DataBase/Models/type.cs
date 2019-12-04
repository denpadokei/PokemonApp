using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.DataBase.Models
{
    [Table(Name = "type")]
    public class type
    {
        [Column(Name = "type_id", IsPrimaryKey = true, CanBeNull = false)]
        public int Id { get; set; }
        [Column(Name = "type_name", CanBeNull = false)]
        public string Name { get; set; }
    }
}
