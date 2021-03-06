﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerFA.Model;

namespace PerFA.ViewModel
{
    class VMAllTransactions
    {
        public Action<int, int> CreateTransactionWindowAction { get; set; }
        public Action<string> CreateNewTransactionWindowAction { get; set; }
        public Action<string> ShowMessageBoxAction { get; set; }
        public ViewTransactionCommand ViewTransactionCommand { get; set; }
        public RelayCommand ResetDatePickersCommand { get; set; }
        public CreateTransactionCommand CreateTransactionCommand { get; set; }
        public DeleteTransactionCommand DeleteTransactionCommand { get; set; }
        public AllTransactionsClass AllTransactionsClass { get; set; }

        public VMAllTransactions()
        {
            AllTransactionsClass = new AllTransactionsClass();
            AllTransactionsClass.TransactionLoadSucceed +=
                AllTransactionsClass_TransactionLoadSucceed;
            AllTransactionsClass.TransactionLoadFailed += AllTransactionsClass_TransactionLoadFailed;
            AllTransactionsClass.TransactionCreationucceed += AllTransactionsClass_TransactionCreationucceed;
            AllTransactionsClass.TransactionCreationFailed += AllTransactionsClass_TransactionCreationFailed;
            ViewTransactionCommand = new ViewTransactionCommand(AllTransactionsClass);
            CreateTransactionCommand = new CreateTransactionCommand(AllTransactionsClass);
            DeleteTransactionCommand = new DeleteTransactionCommand(AllTransactionsClass);
            ResetDatePickersCommand = new RelayCommand(ExecuteResetDatePickersCommand);
        }

        private void ExecuteResetDatePickersCommand(object o)
        {
            AllTransactionsClass.DateFilter.Reset();
        }

        void AllTransactionsClass_TransactionCreationFailed(string message)
        {
            ShowMessageBoxAction(message);
        }

        void AllTransactionsClass_TransactionCreationucceed(string typeOfTransaction)
        {
            CreateNewTransactionWindowAction(typeOfTransaction);
        }

        void AllTransactionsClass_TransactionLoadFailed(string message)
        {
            ShowMessageBoxAction(message);
        }

        void AllTransactionsClass_TransactionLoadSucceed(int userId, int transactionId)
        {
            CreateTransactionWindowAction(userId, transactionId);
        }

        public void Initialize(int userId)
        {
            AllTransactionsClass.Initialize(userId);
        }

        public void Update()
        {
            AllTransactionsClass.Update();
        }
    }
}
