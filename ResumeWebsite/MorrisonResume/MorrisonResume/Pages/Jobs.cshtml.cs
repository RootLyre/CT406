using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MorrisonResume.Models;
namespace MorrisonResume.Pages
{//The jobs model to interact with the database for placing information on the Jobs Index razor page
    //However I did not figure out how to get my database into the razor page 
    public class JobsModel : PageModel
    {
       
       // private readonly MorrisonResumeContext context;
        public void OnGet()
        {

        }
    }
}