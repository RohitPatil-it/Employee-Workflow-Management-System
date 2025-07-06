using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_CRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public DateTime? DOJ { get; set; }
        public string Gender { get; set; }
        public string Hobbies { get; set; } // Stored in DB as CSV

        [NotMapped]
        public List<string> HobbiesList { get; set; } = new List<string>();

    }
}
