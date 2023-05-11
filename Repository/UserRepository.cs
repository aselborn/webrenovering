
using System;
using renovering.Dtos;
using renovering.Models;

public interface IUserRepository
{
    List<Users> Get();
}

public class UserRepository : IUserRepository
{
    private readonly ModelContext _modelDbContext;
    private readonly ILogger _logger;
    public UserRepository(ModelContext dbContext, ILogger<UserRepository> logger)
    {
        _modelDbContext = dbContext;
        _logger = logger;
    }
    public List<Users> Get()
    {
        _logger.LogInformation("UserRepository was called.");
        var data = _modelDbContext.userDtos.ToList();

        return data!;
    }
}