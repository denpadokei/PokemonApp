using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.DataBase.Models
{
    [Table("characteristic")]
    public class characteristic
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int characteristic_id { get; set; }
        
        [Required]
        public string characteristic_name { get; set; }
        public string detials { get; set; }
    }
}
