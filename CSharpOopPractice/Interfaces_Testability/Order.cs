namespace CSharpIntermediate
{
    public class Order
    {
        public int ID { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }
       
        

    }
}