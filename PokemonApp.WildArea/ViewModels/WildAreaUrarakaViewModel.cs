using PokemonApp.Core.ViewModels;
using PokemonApp.WildArea.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.WildArea.ViewModels
{
    public class WildAreaUrarakaViewModel : BaseWindowViewModel
    {
        private string text_;
        public string Text
        {
            get { return this.text_; }
            set { this.SetProperty(ref this.text_, value); }
        }

        private readonly WildAreaDomain domain_;

        public WildAreaUrarakaViewModel()
        {
            this.domain_ = new WildAreaDomain();
            this.Text = nameof(WildAreaUrarakaViewModel);
        }
    }
}
