
using PokemonApp.Core.Interface;
using PokemonApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.PictureBook.Models
{
    public class PokemonEntity : EntityBase, IUpdatable
    {
        public int Id { get; set; }
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

        /// <summary>更新フラグ を取得、設定</summary>
        private bool isUpdated_;
        /// <summary>更新フラグ を取得、設定</summary>
        public bool IsUpdated
        {
            get { return this.isUpdated_; }
            set { this.SetProperty(ref isUpdated_, value); }
        }

        public ObservableCollection<TrickEntity> LearnTrickList { get; set; }
        public PokemonEntity()
        {
            this.LearnTrickList = new ObservableCollection<TrickEntity>();
        }
    }
}
