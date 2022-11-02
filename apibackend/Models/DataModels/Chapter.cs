using System.ComponentModel.DataAnnotations;

using Microsoft.Build.Framework;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace apibackend.Models.DataModels
{
    public class Chapter : BaseEntity

    {
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; } = new Curso();
        [Required]
        public string List = string.Empty;
    }
}
