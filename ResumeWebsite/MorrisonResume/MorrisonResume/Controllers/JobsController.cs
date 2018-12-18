using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MorrisonResume.Models;
using MorrisonResume.ViewModels;

//I'm pretty sure I need a controller class 
//DbInitializer is already initializing the MorrisonResumeContext within Startup... 
//not sure if I needed controller to put the code on the razor web page
namespace MorrisonResume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly MorrisonResumeContext _context;

        public JobsController(MorrisonResumeContext context)
        {
            _context = context;
        }
        /*
        public ActionResult Index()
        {
            var jobs = _context.Job.Include(j => j.JobTitle);

            //I'm not sure how to continue this
            //return View(await jobs.ToListAsync());
            return 0;
        }
        */
    }

}