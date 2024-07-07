using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyhousingSolution_WebAPI.Model
{
    public partial class City
    {
        public City()
        {
            Seller = new HashSet<Seller>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }

        public virtual States State { get; set; }
        public virtual ICollection<Seller> Seller { get; set; }
    }
}
