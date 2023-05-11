using System.ComponentModel.DataAnnotations;

namespace renovering.Dtos;

public class Users
{
    [Key]
    public int UserId {get;set;}
    public string UserName { get; set; }
    public string email { get; set; }
    public string password { get; set; }
}
