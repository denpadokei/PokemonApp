using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonApp.DataBase.Models
{
    [Table("categories")]
    public class category
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int category_id { get; set; }

        public string category_name { get; set; }
        public string c_category_name { get; set; }
    }
}
