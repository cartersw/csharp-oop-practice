namespace CSharpIntermediate
{
    public class Order
    {
        public int TotalPrice { get; set; } 
        public bool IsShipped { get; set; }
        public Shipment Shipment { get; set; }  

        public Order(Shipment shipment)
        {
            this.Shipment = shipment;
        }

    }
}