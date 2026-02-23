using System.Collections.Generic;

namespace DesignPatternsInCSharp.Creational.Builder;

public sealed class Report
{
    public string Title { get; init; } = string.Empty;
    public IReadOnlyList<string> Sections { get; init; } = [];
}

public sealed class ReportBuilder
{
    private string _title = "Untitled";
    private readonly List<string> _sections = new();

    public ReportBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public ReportBuilder AddSection(string section)
    {
        _sections.Add(section);
        return this;
    }

    public Report Build()
    {
        return new Report
        {
            Title = _title,
            Sections = _sections
        };
    }
}

public static class Example
{
    public static string Run()
    {
        var report = new ReportBuilder()
            .WithTitle("Weekly Status")
            .AddSection("Completed tasks")
            .AddSection("Risks")
            .Build();

        return $"{report.Title} ({report.Sections.Count} sections)";
    }
}
