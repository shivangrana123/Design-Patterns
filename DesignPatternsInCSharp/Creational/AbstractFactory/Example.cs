namespace DesignPatternsInCSharp.Creational.AbstractFactory;

public interface IButton
{
    string Render();
}

public interface IModal
{
    string Render();
}

public interface IUiFactory
{
    IButton CreateButton();
    IModal CreateModal();
}

public sealed class LightButton : IButton
{
    public string Render() => "Light Button";
}

public sealed class LightModal : IModal
{
    public string Render() => "Light Modal";
}

public sealed class DarkButton : IButton
{
    public string Render() => "Dark Button";
}

public sealed class DarkModal : IModal
{
    public string Render() => "Dark Modal";
}

public sealed class LightThemeFactory : IUiFactory
{
    public IButton CreateButton() => new LightButton();
    public IModal CreateModal() => new LightModal();
}

public static class Example
{
    public static string Run()
    {
        IUiFactory factory = new LightThemeFactory();
        IButton button = factory.CreateButton();
        IModal modal = factory.CreateModal();

        return $"{button.Render()} + {modal.Render()}";
    }
}
