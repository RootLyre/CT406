using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


//This class creates the context to refer and call on in other classes to access data associated with the Databases
namespace MorrisonResume.Models
{
    public class MorrisonResumeContext : DbContext
    {
        public MorrisonResumeContext (DbContextOptions<MorrisonResumeContext> options)
            : base(options)
        {
        }
        //give context reference to the 3 different classes and all of the entities created of each 
        public DbSet<MorrisonResume.Models.Student> Student { get; set; }
        public DbSet<MorrisonResume.Models.Company> Company { get; set; }
        public DbSet<MorrisonResume.Models.Job> Job { get; set; }
    }
}
