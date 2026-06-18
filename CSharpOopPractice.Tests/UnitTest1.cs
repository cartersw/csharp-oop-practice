using CSharpIntermediate;
using System.Linq.Expressions;

namespace CSharpOopPractice.Tests;

public class OrderProcessorTests
{
    // METHODNAME_CONDITION_EXPECTATION
    [Fact]

    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        Order order = new Order
        {
            Shipment = new Shipment()
        };

        Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
    }


    [Fact]

    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
    {
        OrderProcessor orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        Order order = new Order();

        orderProcessor.Process(order);

        Assert.True(order.IsShipped);
        Assert.Equal(10, order.Shipment.Cost);
        Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
    }

}




public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 10;
    }
}
