namespace SibersTestTask.Models
{
    public class Leader
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdLeadProject { get; set; }
        public int IdEmployee { get; set; }



        public ICollection<Project> Projects { get; set; }
        public Employee Employee { get; set; }
    }
}
