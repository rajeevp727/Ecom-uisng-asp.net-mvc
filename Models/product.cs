//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecomm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int id { get; set; }
        public string prodName { get; set; }
        public Nullable<int> categId { get; set; }
        public Nullable<int> brandId { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> price { get; set; }
    
        public virtual brand brand { get; set; }
        public virtual category category { get; set; }
    }
}