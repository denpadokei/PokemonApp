//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonApp.DataBase.Models
{
    [Table("type")]
    public class type
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int type_id { get; set; }

        [Required]
        public string type_name { get; set; }

        [Required]
        public string eng_type_name { get; set; }
    }
}
