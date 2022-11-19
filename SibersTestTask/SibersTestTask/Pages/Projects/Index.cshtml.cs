﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SibersTestTask.Data;
using SibersTestTask.Models;

namespace SibersTestTask.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly SibersTestTask.Data.SibersTestTaskContext _context;

        public IndexModel(SibersTestTask.Data.SibersTestTaskContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;
        public IList<EmployeesInProject> EmployeesInProject { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Project != null)
            {
                Project = await _context.Project.ToListAsync();
            }
            if (_context.EmployeesInProjects != null)
            {
                EmployeesInProject = await _context.EmployeesInProjects.ToListAsync();
            }
            
        }
        public string HImethod()
        {
            string rr = "@Html.DisplayFor(modelItem => itemm.IdEmployee)";
            return (rr);
        }
    }
}
