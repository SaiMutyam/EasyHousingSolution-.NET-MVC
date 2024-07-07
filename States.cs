using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyhousingSolution_WebAPI.Model
{
    public partial class States
    {
        public States()
        {
            City = new HashSet<City>();
            Seller = new HashSet<Seller>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Seller> Seller { get; set; }
    }
}
