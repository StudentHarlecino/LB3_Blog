using System;
using System.Collections.Generic;

namespace LB3_Blog;

public partial class Post
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }

    public DateOnly? DateOfPublication { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
