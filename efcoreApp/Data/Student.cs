using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentPhone { get; set; }
    }
}