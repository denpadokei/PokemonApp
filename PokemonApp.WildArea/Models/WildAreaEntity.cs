using PokemonApp.Core.Enum;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.WildArea.Models
{
    class WildAreaEntity : BindableBase
    {
        private string name_;
        public string Name
        {
            get { return this.name_; }
            set { this.SetProperty(ref this.name_, value); }
        }

        private int? probability_;
        public int? Probability
        {
            get { return this.probability_; }
            set { this.SetProperty(ref this.probability_, value); }
        }

        private WildAreaEnum area_;
        public WildAreaEnum Area
        {
            get { return this.area_; }
            set { this.SetProperty(ref this.area_, value); }
        }

        private Wether wether_;
        public Wether Wether
        {
            get { return this.wether_; }
            set { this.SetProperty(ref this.wether_, value); }
        }

        public WildAreaEntity()
        {
            
        }
    }
}
