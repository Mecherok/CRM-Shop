namespace BLogic.Models {
    public class Customer {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public virtual System.Collections.Generic.ICollection<Check> Checks { get; set; }
        public override string ToString() {
            return Name;
        }
    }
}
