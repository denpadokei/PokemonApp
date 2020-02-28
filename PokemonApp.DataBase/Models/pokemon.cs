//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonApp.DataBase.Models
{
    [Table("pokemon")]
    public class pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pokemon_id { get; set; }

        [Required]
        public string pokemon_no { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public double height { get; set; }
        [Required]
        public double weight { get; set; }
        [Required]
        public int type_1_id { get; set; }

        public int? type_2_id { get; set; }

        [Required]
        public int characteristic1_id { get; set; }

        public int? characteristic2_id { get; set; }

        public int? dream_characteristic_id { get; set; }

        [Required]
        public int hp { get; set; }

        [Required]
        public int attack { get; set; }

        [Required]
        public int block { get; set; }

        [Required]
        public int contact { get; set; }

        [Required]
        public int defence { get; set; }

        [Required]
        public int speed { get; set; }

        public pokemon()
        {

        }
    }
}
