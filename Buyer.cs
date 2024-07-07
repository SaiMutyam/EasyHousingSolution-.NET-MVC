using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyhousingSolution_WebAPI.Model
{
    public partial class Buyer
    {
        public Buyer()
        {
            Cart = new HashSet<Cart>();
        }

        public int BuyerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
    }
}
