//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerFA.Model
{
    using System;
    using System.Collections.Generic;
    using PropertyChanged;
    
    [ImplementPropertyChanged]
    public partial class User
    {
        public User()
        {
            this.Transactions = new HashSet<Transaction>();
            this.TransactionUsers = new HashSet<TransactionUser>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<TransactionUser> TransactionUsers { get; set; }
    }
}
