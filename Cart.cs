using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyhousingSolution_WebAPI.Model
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int BuyerId { get; set; }
        public int PropertyId { get; set; }

        public virtual Buyer Buyer { get; set; }
        public virtual Property Property { get; set; }
    }
}
