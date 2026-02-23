using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsInCSharp.Behavioral.DataAccess;

public sealed record User(int Id, string Name);

public interface IUserRepository
{
    User? FindById(int id);
}

public sealed class InMemoryUserRepository : IUserRepository
{
    private readonly List<User> _users =
    [
        new User(1, "Asha"),
        new User(2, "Noah")
    ];

    public User? FindById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}

public sealed class UserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public string GetDisplayName(int userId)
    {
        User? user = _repository.FindById(userId);
        return user is null ? "Unknown user" : user.Name;
    }
}

public static class Example
{
    public static string Run()
    {
        var service = new UserService(new InMemoryUserRepository());
        return service.GetDisplayName(1);
    }
}
