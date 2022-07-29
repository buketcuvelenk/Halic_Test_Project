using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Halic_Test_Project.Models
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }

        [Required]
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Class { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //public String DateTime  { get; set; } 

    }
}
