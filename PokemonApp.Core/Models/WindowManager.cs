﻿using PokemonApp.Core.Interface;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PokemonApp.Core.Models
{
    public class WindowManager : IWindowManager
    {
        [Dependency]
        public IDialogService DialogService { get; set; }

        public void Show(string windowname, IDialogParameters parameter, Action<IDialogResult> action)
        {
            this.DialogService.Show(windowname, parameter, action);
        }

        public void ShowDialog(string windowname, IDialogParameters parameter, Action<IDialogResult> action)
        {
            this.DialogService.ShowDialog(windowname, parameter, action);
        }

        public WindowManager()
        {

        }
    }
}