using System;
using System.Collections.Generic;

namespace School_Information_System.DataModels;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Class { get; set; }

    public string? Section { get; set; }
    //public int Rollno { get; set; }
   public string RollNo { get; internal set; }
    public string? Gender { get; set; }
    public int Marks { get; set; }
    public DateOnly? Dob { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    public object Id { get; internal set; }

    //  public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();
}
