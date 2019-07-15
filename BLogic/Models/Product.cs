namespace BLogic.Models {
    public class Product {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual System.Collections.Generic.ICollection<Sell> Sells { get; set; }

        public override string ToString() {
            return Name;
        }
        public override int GetHashCode() {
            return ProductID;
        }
        public override bool Equals(object obj) {
            if (obj is Product product) {
                return ProductID.Equals(product.ProductID);
            }
            return false;
        }
    }
}

