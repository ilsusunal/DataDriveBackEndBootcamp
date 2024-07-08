using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
    }
}