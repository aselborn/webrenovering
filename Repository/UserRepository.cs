
using System;
using renovering.Models;


public interface IUserRepository
{
    List<User> Get();
    void Add(User theUser);
}

public class UserRepository : IUserRepository
{
    private readonly RenoveringContext _modelDbContext;
    private readonly ILogger _logger;
    public UserRepository(RenoveringContext dbContext, ILogger<UserRepository> logger)
    {
        _modelDbContext = dbContext;
        _logger = logger;
    }

    public void Add(User theUser) 
    {
        _modelDbContext.Users.Add( new User { Email = theUser.Email, Picture = theUser.Picture, UserName = theUser.UserName});
        _modelDbContext.SaveChanges();
    }

    public List<User> Get()
    {
        _logger.LogInformation("UserRepository was called.");
        var data = _modelDbContext.Users.ToList();
        return data;
    }
}