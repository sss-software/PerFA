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
    
    public partial class Wage
    {
        public int ID { get; set; }
        public string Workplace { get; set; }
        public Nullable<decimal> Wage_rate { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
