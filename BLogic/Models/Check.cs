namespace BLogic.Models {
    public class Check {
        public int CheckID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerID { get; set; }
        public virtual Seller Seller { get; set; }
        public System.DateTime Created { get; set; }
        public virtual System.Collections.Generic.ICollection<Sell> Sells { get; set; }

        public override string ToString() {
            return $"№{CheckID} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
