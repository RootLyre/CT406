using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MorrisonResume.Models;
namespace MorrisonResume.ViewModels
{

    //I assumed I would need a viewModel to help display my database, so I created this reference class
    public class JobIndexData
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Company> Companies { get; set; }
    }
}
