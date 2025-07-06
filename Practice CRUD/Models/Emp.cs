using System.ComponentModel.DataAnnotations;

namespace Practice_CRUD.Models
{
    public class Emp
    {
        [Key]
        public int Eid { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public double SalaryOfEmp { get; set; }
    }
}
