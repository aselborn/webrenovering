using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace renovering.Models;

[Table("Post")]
public partial class PostDto
{
    [Key]
    public long PostId { get; set; }

    public int UserId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime startDateTime { get; set; } 

    public DateTime endDateTime { get; set; }
}
