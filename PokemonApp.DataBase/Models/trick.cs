﻿//using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonApp.DataBase.Models
{
    [Table("trick")]
    public class trick
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int trick_id { get; set; }
        public int? power { get; set; }
        public int? accuracy_rate { get; set; }
        [Required]
        public int type_id { get; set; }
        [Required]
        public string trick_name { get; set; }
        [Required]
        public int attribute { get; set; }
        public int? pp { get; set; }
        public string detial { get; set; }
    }
}
