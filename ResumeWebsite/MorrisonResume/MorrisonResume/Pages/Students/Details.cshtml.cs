using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MorrisonResume.Models;

namespace MorrisonResume.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly MorrisonResume.Models.MorrisonResumeContext _context;

        public DetailsModel(MorrisonResume.Models.MorrisonResumeContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student
                     .Include(s => s.Companies)
                         .ThenInclude(e => e.Job)
                     .AsNoTracking()
                     .FirstOrDefaultAsync(m => m.StudentId == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
