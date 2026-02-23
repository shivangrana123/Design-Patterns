using System.Collections.Generic;

namespace DesignPatternsInCSharp.Behavioral.Command;

public interface ICommand { void Execute(); }
public sealed class Light { public bool IsOn { get; private set; } public void On()=>IsOn=true; }
public sealed class LightOnCommand : ICommand { private readonly Light _light; public LightOnCommand(Light light)=>_light=light; public void Execute()=>_light.On(); }
public sealed class RemoteControl { private readonly List<ICommand> _history = new(); public void Press(ICommand cmd){ cmd.Execute(); _history.Add(cmd);} }

public static class Example
{
    public static bool Run() { var light=new Light(); new RemoteControl().Press(new LightOnCommand(light)); return light.IsOn; }
}
