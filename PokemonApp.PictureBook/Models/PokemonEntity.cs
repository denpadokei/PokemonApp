using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.PictureBook.Models
{
    public class PokemonEntity
    {
        public string No { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Characteristic1 { get; set; }
        public string Characteristic2 { get; set; }
        public string DreamCharacteristic { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Block { get; set; }
        public int Contact { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public int SumAll => this.Hp + this.Attack + this.Block + this.Contact + this.Defence + this.Speed;
    }
}
