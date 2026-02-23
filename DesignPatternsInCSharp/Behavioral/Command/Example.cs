using System.Collections.Generic;

namespace DesignPatternsInCSharp.Behavioral.Command;

public interface ICommand
{
    void Execute();
}

public sealed class Light
{
    public bool IsOn { get; private set; }

    public void TurnOn()
    {
        IsOn = true;
    }
}

public sealed class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

public sealed class RemoteControl
{
    private readonly List<ICommand> _history = new();

    public void Press(ICommand command)
    {
        command.Execute();
        _history.Add(command);
    }
}

public static class Example
{
    public static bool Run()
    {
        var livingRoomLight = new Light();
        var command = new LightOnCommand(livingRoomLight);
        var remote = new RemoteControl();

        remote.Press(command);

        return livingRoomLight.IsOn;
    }
}
