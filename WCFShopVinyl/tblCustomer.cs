//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFShopVinyl
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        public tblCustomer()
        {
            this.tblOrders = new HashSet<tblOrder>();
        }
    
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
    
        public virtual ICollection<tblOrder> tblOrders { get; set; }
    }
}
