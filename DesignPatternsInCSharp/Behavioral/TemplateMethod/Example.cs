namespace DesignPatternsInCSharp.Behavioral.TemplateMethod;

public abstract class ReportGenerator
{
    public string Generate()
    {
        string header = BuildHeader();
        string body = BuildBody();
        string footer = BuildFooter();

        return $"{header}
{body}
{footer}";
    }

    protected abstract string BuildHeader();
    protected abstract string BuildBody();

    protected virtual string BuildFooter()
    {
        return "-- End of report --";
    }
}

public sealed class SalesReportGenerator : ReportGenerator
{
    protected override string BuildHeader()
    {
        return "Sales Report";
    }

    protected override string BuildBody()
    {
        return "Total revenue: 12500";
    }
}

public static class Example
{
    public static string Run()
    {
        var generator = new SalesReportGenerator();
        return generator.Generate();
    }
}
