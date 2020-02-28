using Microsoft.Xaml.Behaviors;
using PokemonApp.Core.Interfaces;
using System.Windows;

namespace PokemonApp.Core.Actions
{
    public class DataContextInitialize : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            if (this.AssociatedObject.DataContext is IInitialize context) {
                context.OnInitialize();
            }
        }
    }
}
