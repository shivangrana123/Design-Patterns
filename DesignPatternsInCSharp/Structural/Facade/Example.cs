namespace DesignPatternsInCSharp.Structural.Facade;

public sealed class PaymentService
{
    public bool Charge(decimal amount)
    {
        return amount > 0;
    }
}

public sealed class InventoryService
{
    public bool Reserve(string sku)
    {
        return !string.IsNullOrWhiteSpace(sku);
    }
}

public sealed class ShippingService
{
    public string CreateShipment(string sku)
    {
        return $"Shipment created for {sku}";
    }
}

public sealed class CheckoutFacade
{
    private readonly PaymentService _payment = new();
    private readonly InventoryService _inventory = new();
    private readonly ShippingService _shipping = new();

    public string PlaceOrder(string sku, decimal amount)
    {
        if (!_inventory.Reserve(sku))
        {
            return "Inventory reservation failed";
        }

        if (!_payment.Charge(amount))
        {
            return "Payment failed";
        }

        return _shipping.CreateShipment(sku);
    }
}

public static class Example
{
    public static string Run()
    {
        var checkout = new CheckoutFacade();
        return checkout.PlaceOrder("SKU-100", 49.99m);
    }
}
