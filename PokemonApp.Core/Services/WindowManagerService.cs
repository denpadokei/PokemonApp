﻿using PokemonApp.Core.Interfaces;
using Prism.Services.Dialogs;
using System;
using Unity;

namespace PokemonApp.Core.Services
{
    public class WindowManagerService : IWindowManagerService
    {
        [Dependency]
        public IDialogService DialogService { get; set; }
        [Dependency]
        public ICustomDialogService CustomDialogService { get; set; }

        /// <summary>
        /// Prismを使った方のダイアログ
        /// </summary>
        /// <param name="windowname"></param>
        /// <param name="parameter"></param>
        /// <param name="action"></param>
        public void Show(string windowname, IDialogParameters parameter, Action<IDialogResult> action)
        {
            this.DialogService.Show(windowname, parameter, action);
        }

        /// <summary>
        /// materialを使った方のメッセージ
        /// </summary>
        /// <param name="message"></param>
        public async void ShowMessage(string message)
        {
            await this.CustomDialogService.ShowMessege(message);
        }

        public void Show(object viewmodel, string title, string content)
        {
            //await this.DialogCoordinator.ShowMessageAsync(viewmodel, title, content);
        }

        public void ShowDialog(string windowname, IDialogParameters parameter, Action<IDialogResult> action)
        {
            this.DialogService?.ShowDialog(windowname, parameter, action);
        }

        public WindowManagerService()
        {

        }
    }
}
