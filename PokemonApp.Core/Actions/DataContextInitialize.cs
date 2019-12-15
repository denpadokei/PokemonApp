﻿using Microsoft.Xaml.Behaviors;
using PokemonApp.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
