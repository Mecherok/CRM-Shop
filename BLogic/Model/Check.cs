using System;
using System.Collections.Generic;

namespace BLogic.Model {
    public class Check {
        public int CheckID { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        public int SellerID { get; set; }
        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public decimal Price { get; set; }

        public override string ToString() {
            return $"№{CheckID} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
