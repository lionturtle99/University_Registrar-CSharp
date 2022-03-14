using System;
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities= new HashSet<CourseStudent>();
    }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public int StudentId { get; set; }

    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
  }
}