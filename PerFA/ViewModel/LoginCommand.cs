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
            this.login = example;
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
                context.TransactionsClass = new TransactionsClass(context.Login);
                var binding = new Binding() { Source = context.TransactionsClass.Transactions };
                var transactionWindow = new TransactionWindow
                {
                    DataContext = context//new ViewModelTransactions(context.Login)
                };
                BindingOperations.SetBinding(
                    transactionWindow.TransactionDataGrid, ItemsControl.ItemsSourceProperty, binding);
                transactionWindow.Show();
            };
        }

        public event EventHandler CanExecuteChanged;
    }
}
