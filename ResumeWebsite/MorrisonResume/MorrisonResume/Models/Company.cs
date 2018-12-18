using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This class Company connects the Student and the Job entities, creating a relationship between them
namespace MorrisonResume.Models
{
    public class Company
    {
        //primary key
        public int CompanyId { get; set; }
        //Company Name
        public string CompanyName { get; set; }
        //Foreign key
        public int StudentId { get; set; }
        //Foreign key
        public int JobId { get; set;}

        //Reference to Job and Student databases
        public Job Job { get; set; }
        public Student Student { get; set; }
    }
}
