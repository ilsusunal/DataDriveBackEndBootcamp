using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<CourseEnrollment> CourseEnrollments => Set<CourseEnrollment>();
    }
}