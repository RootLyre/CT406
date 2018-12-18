using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//This class defines what the Job object is and what information is associated with it
namespace MorrisonResume.Models
{
    public class Job
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //Primary key Job ID
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        //Date/month I started the job
        public string StartDate { get; set; }
        //Date/month I left
        public string EndDate { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
