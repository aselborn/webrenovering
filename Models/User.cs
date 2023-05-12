using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace renovering.Models;

[Index("UserId", IsUnique = true)]
public partial class User
{
    [Key]
    public long UserId { get; set; }

    [Display(Name ="Användarnamn")]
    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    [Column("picture")]
    public byte[]? Picture { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
