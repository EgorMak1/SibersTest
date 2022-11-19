using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SibersTestTask.Data;
using SibersTestTask.Models;

namespace SibersTestTask.Pages
{
    public class Index1Model : PageModel
    {
        private readonly SibersTestTask.Data.SibersTestTaskContext _context;

        public Index1Model(SibersTestTask.Data.SibersTestTaskContext context)
        {
            _context = context;
        }

        public IList<EmployeesInProject> EmployeesInProject { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.EmployeesInProjects != null)
            {
                EmployeesInProject = await _context.EmployeesInProjects.ToListAsync();
            }
        }
    }
}
