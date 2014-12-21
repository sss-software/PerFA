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
    public partial class Transaction
    {
        public Transaction()
        {
            this.TransactionUsers = new HashSet<TransactionUser>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Description { get; set; }
        public int Author_ID { get; set; }
    
        public virtual Credit Credit { get; set; }
        public virtual Deposit Deposit { get; set; }
        public virtual Grant Grant { get; set; }
        public virtual HouseholdExpence HouseholdExpence { get; set; }
        public virtual LongTermExpence LongTermExpence { get; set; }
        public virtual OtherExpence OtherExpence { get; set; }
        public virtual OtherIncome OtherIncome { get; set; }
        public virtual Rent Rent { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TransactionUser> TransactionUsers { get; set; }
        public virtual Wage Wage { get; set; }
    }
}
