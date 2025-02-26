using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [Column("ecode")]
        public int Ecode { get; set; }
        [Column("empname")]
        public string EmpName { get; set; }

        [Column("salary")]
        public int Salary { get; set; }

        [Column("depid")]
        public int DepId { get; set; }
    }
}
