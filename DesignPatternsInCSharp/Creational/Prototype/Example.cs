namespace DesignPatternsInCSharp.Creational.Prototype;

public sealed class DocumentPrototype
{
    public string Title { get; init; } = string.Empty;
    public string Body { get; init; } = string.Empty;

    public DocumentPrototype CloneWithTitle(string title)
    {
        return new DocumentPrototype
        {
            Title = title,
            Body = Body
        };
    }
}

public static class Example
{
    public static string Run()
    {
        var template = new DocumentPrototype
        {
            Title = "Template",
            Body = "Shared introduction section"
        };

        var proposal = template.CloneWithTitle("Client Proposal");
        return proposal.Title;
    }
}
