using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data
{
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
    }
}