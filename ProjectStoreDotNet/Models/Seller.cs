using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectStoreDotNet.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column("birth_date")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Column("base_salary", TypeName = "decimal(6,2)")]
        public decimal BaseSalary { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        public Seller(int id, string name, string email, DateTime birthDate, decimal baseSalary, int departmentId)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            DepartmentId = departmentId;
        }
    }
}
