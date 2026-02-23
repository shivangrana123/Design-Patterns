using System.Collections.Generic;

namespace DesignPatternsInCSharp.Behavioral.Mediator;

public interface IChatMediator
{
    void Register(User user);
    void Send(string from, string to, string message);
}

public sealed class ChatRoomMediator : IChatMediator
{
    private readonly Dictionary<string, User> _users = new();

    public void Register(User user)
    {
        _users[user.Name] = user;
    }

    public void Send(string from, string to, string message)
    {
        if (_users.TryGetValue(to, out var receiver))
        {
            receiver.Receive($"{from}: {message}");
        }
    }
}

public sealed class User
{
    private readonly IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public string Name { get; }
    public string Inbox { get; private set; } = string.Empty;

    public void SendTo(string to, string message)
    {
        _mediator.Send(Name, to, message);
    }

    public void Receive(string message)
    {
        Inbox = message;
    }
}

public static class Example
{
    public static string Run()
    {
        var room = new ChatRoomMediator();
        var sara = new User("Sara", room);
        var leo = new User("Leo", room);

        room.Register(sara);
        room.Register(leo);

        sara.SendTo("Leo", "Standup at 10");

        return leo.Inbox;
    }
}
