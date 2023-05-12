
//using renovering.Dtos;
using renovering.Models;

namespace renovering.Services;
public interface IUserService
{
    List<User> Get();
    void Add(User theUser);

}

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository repository)
    {
        _userRepository = repository;
    }

    public void Add(User theUser) 
    {
        _userRepository.Add(theUser);
    }

    public List<User> Get()
    {
        var data = _userRepository.Get();
        return data;
    }
}