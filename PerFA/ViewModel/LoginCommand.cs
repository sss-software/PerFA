﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using PerFA.Model;
using PerFA.View;

namespace PerFA.ViewModel
{
    class LoginCommand : ICommand
    {
        private readonly ViewModelLogin context;
        private readonly Login login;

        public LoginCommand(Login example, ViewModelLogin context)
        {
            login = example;
            this.context = context;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (login.TryLogin())
            {
                context.CreateTransactionWindowAction(context.Login.UserId);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
