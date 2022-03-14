using System;
using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }
    public string NameOfCourse { get; set; }
    public DateTime Time { get; set; }
    public int CourseId { get; set; }

    public virtual ICollection<CourseStudent> JoinEntities { get; }
  }
}