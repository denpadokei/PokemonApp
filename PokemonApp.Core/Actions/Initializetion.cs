using PokemonApp.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interactivity;

namespace PokemonApp.Core.Actions
{
    public class Initializetion : TriggerAction<DependencyObject>, IInitialize
    {
        public virtual void OnInitialize()
        {
            
        }

        protected override void Invoke(object parameter)
        {
            this.OnInitialize();
        }
    }
}
