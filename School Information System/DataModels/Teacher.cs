using System;
using System.Collections.Generic;

namespace School_Information_System.DataModels;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string? Name { get; set; }

    public string? Subject { get; set; }

    public string? Phone { get; set; }
}
