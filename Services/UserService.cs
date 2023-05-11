
using renovering.Dtos;

namespace renovering.Services;
public interface IUserService
{
    List<Users> Get();

}

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository repository)
    {
        _userRepository = repository;
    }
    public List<Users> Get()
    {
        var data = _userRepository.Get();
        return data;
    }
}