using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int id { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }
        public string? foto { get; private set; }

        public Employee(string name, int age, string foto)
        {
            this.name = name ?? throw new ArgumentNullException("Nome inválido!");
            this.age = age;
            this.foto = foto;
        }
    }
}
