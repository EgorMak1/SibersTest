using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SibersTestTask.Models
{
    
    public class EmployeesInProject
    {
        [Key]
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdProject { get; set; }



        public Project Project { get; set; }
        public Employee Employee { get; set; }
    }
}
