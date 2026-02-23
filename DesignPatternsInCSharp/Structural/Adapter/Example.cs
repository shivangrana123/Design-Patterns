namespace DesignPatternsInCSharp.Structural.Adapter;

public interface IPaymentGateway
{
    string Pay(decimal amount);
}

public sealed class LegacyPaymentService
{
    public string MakePayment(decimal value)
    {
        return $"Legacy payment processed: {value:0.00}";
    }
}

public sealed class LegacyPaymentAdapter : IPaymentGateway
{
    private readonly LegacyPaymentService _legacy;

    public LegacyPaymentAdapter(LegacyPaymentService legacy)
    {
        _legacy = legacy;
    }

    public string Pay(decimal amount)
    {
        return _legacy.MakePayment(amount);
    }
}

public static class Example
{
    public static string Run()
    {
        IPaymentGateway gateway = new LegacyPaymentAdapter(new LegacyPaymentService());
        return gateway.Pay(75m);
    }
}
