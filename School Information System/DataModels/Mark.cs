using System;
using System.Collections.Generic;

namespace School_Information_System.DataModels;

public partial class Mark
{
    public int MarkId { get; set; }

    public int? StudentId { get; set; }

    public string? Subject { get; set; }

    public int? Marks { get; set; }

    public virtual Student? Student { get; set; }
}
