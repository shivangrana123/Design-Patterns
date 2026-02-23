namespace DesignPatternsInCSharp.Behavioral.ChainOfResponsibility;

public interface IExpenseApprover
{
    string Approve(decimal amount);
}

public sealed class TeamLead : IExpenseApprover
{
    public string Approve(decimal amount)
    {
        if (amount <= 1_000m)
        {
            return "Approved by Team Lead";
        }

        return "Escalated";
    }
}

public sealed class Manager : IExpenseApprover
{
    public string Approve(decimal amount)
    {
        if (amount <= 5_000m)
        {
            return "Approved by Manager";
        }

        return "Escalated";
    }
}

public sealed class Director : IExpenseApprover
{
    public string Approve(decimal amount)
    {
        return amount <= 20_000m
            ? "Approved by Director"
            : "Rejected";
    }
}

public static class Example
{
    public static string Run()
    {
        decimal expenseAmount = 4_200m;

        IExpenseApprover[] chain =
        {
            new TeamLead(),
            new Manager(),
            new Director()
        };

        foreach (var approver in chain)
        {
            string result = approver.Approve(expenseAmount);
            if (result != "Escalated")
            {
                return result;
            }
        }

        return "No approver found";
    }
}
