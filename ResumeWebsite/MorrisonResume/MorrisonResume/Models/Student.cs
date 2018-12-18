using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This is the Student Model which defines what a Student object is 
//But in this case,the Student Database will just contain me 
namespace MorrisonResume.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
