using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.DataBase.Models
{
    [Table("link_trick")]
    public class link_trick
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int link_trick_id { get; set; }
        [Required]
        public int pokemon_id { get; set; }
        [Required]
        public int trick_id { get; set; }
    }
}
