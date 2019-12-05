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
    [Table("trick")]
    public class trick
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int trick_id { get; set; }
        
        [Required]
        public int power { get; set; }
        
        [Required]
        public int accuracy_rate { get; set; }
        
        [Required]
        public int type_id { get; set; }
        
        [Required]
        public string trick_name { get; set; }
        
        [Required]
        public int attribute { get; set; }
        
        public string detial { get; set; }
    }
}
