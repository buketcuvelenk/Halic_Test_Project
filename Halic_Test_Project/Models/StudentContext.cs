using Microsoft.EntityFrameworkCore;

namespace Halic_Test_Project.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options): base(options)
        {
               
        }

        public DbSet<Student> Students { get; set; }
    }
}
