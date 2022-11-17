using Microsoft.EntityFrameworkCore;


namespace SibersTestTask.Models
{
    [PrimaryKey(nameof(IdEmployee), nameof(IdProject))]
    public class Employess_Projects
    {
        
        public int IdEmployee { get; set; }
      
        public int IdProject { get; set; }

        public Employee Employee { get; set; }
        public Project Prorect { get; set; }
    }
       
}
