﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SibersTestTask.Data;
using SibersTestTask.Models;

namespace SibersTestTask.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly SibersTestTask.Data.EmployeeContext _context;

        public IndexModel(SibersTestTask.Data.EmployeeContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
