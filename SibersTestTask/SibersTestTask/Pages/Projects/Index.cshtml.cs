using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SibersTestTask.Data;
using SibersTestTask.Models;

namespace SibersTestTask.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly SibersTestTask.Data.ProjectContext _context;

        public IndexModel(SibersTestTask.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Project != null)
            {
                Project = await _context.Project.ToListAsync();
            }
        }
    }
}
