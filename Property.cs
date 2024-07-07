using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyhousingSolution_WebAPI.Model
{
    public partial class Property
    {
        public Property()
        {
            Cart = new HashSet<Cart>();
            Images = new HashSet<Images>();
        }

        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public string PropertyOption { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal PriceRange { get; set; }
        public decimal InitialDeposit { get; set; }
        public string LandMark { get; set; }
        public bool IsActive { get; set; }
        public int SellerId { get; set; }

        public virtual Seller Seller { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Images> Images { get; set; }
    }
}
