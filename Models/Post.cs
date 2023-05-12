using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace renovering.Models;

[Table("Post")]
[Index("PostId", IsUnique = true)]
public partial class Post
{
    [Key]
    public long PostId { get; set; }

    public long UserId { get; set; }

    public string? Content { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Posts")]
    public virtual User User { get; set; } = null!;
}
