namespace DesignPatternsInCSharp.Creational.Singleton;

public sealed class AppConfig
{
    private AppConfig(){}
    public static AppConfig Instance { get; } = new();
    public string EnvironmentName { get; set; } = "Development";
}

public static class Example
{
    public static string Run() => AppConfig.Instance.EnvironmentName;
}
