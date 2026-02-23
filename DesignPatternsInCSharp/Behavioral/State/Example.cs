namespace DesignPatternsInCSharp.Behavioral.State;

public interface IOrderState
{
    string Pay(OrderContext context);
    string Ship(OrderContext context);
}

public sealed class DraftState : IOrderState
{
    public string Pay(OrderContext context)
    {
        context.SetState(new PaidState());
        return "Order paid";
    }

    public string Ship(OrderContext context)
    {
        return "Cannot ship before payment";
    }
}

public sealed class PaidState : IOrderState
{
    public string Pay(OrderContext context)
    {
        return "Already paid";
    }

    public string Ship(OrderContext context)
    {
        context.SetState(new ShippedState());
        return "Order shipped";
    }
}

public sealed class ShippedState : IOrderState
{
    public string Pay(OrderContext context)
    {
        return "Already shipped";
    }

    public string Ship(OrderContext context)
    {
        return "Already shipped";
    }
}

public sealed class OrderContext
{
    private IOrderState _state = new DraftState();

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public string Pay()
    {
        return _state.Pay(this);
    }

    public string Ship()
    {
        return _state.Ship(this);
    }
}

public static class Example
{
    public static string Run()
    {
        var order = new OrderContext();
        order.Pay();
        return order.Ship();
    }
}
