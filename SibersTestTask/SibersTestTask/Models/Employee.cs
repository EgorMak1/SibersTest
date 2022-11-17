namespace SibersTestTask.Models
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public ICollection<Leader> Leaders { get; set; }
    }
}
