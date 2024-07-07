using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyhousingSolution_WebAPI.Model
{
    public partial class Seller
    {
        public Seller()
        {
            Property = new HashSet<Property>();
        }

        public int SellerId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string EmailId { get; set; }

        public virtual City City { get; set; }
        public virtual States State { get; set; }
        public virtual ICollection<Property> Property { get; set; }
    }
}
