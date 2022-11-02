
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace apibackend.Models.DataModels
{
    public class Student : BaseEntity
        
    {
        [Required]

        public string Name { get; set; } =string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }
       
       public ICollection<Curso> Curso { get; set; } = new List<Curso>();

    }
}
