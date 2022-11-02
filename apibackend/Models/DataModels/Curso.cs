
using System.ComponentModel.DataAnnotations;

namespace apibackend.Models.DataModels
{
    public enum Nivel
    {
        Basico,
        Intermedio,
        Avanzado

    }
    public class Curso : BaseEntity
        
    {
        [Required, StringLength(50)]

        public string Name { get; set; } =string.Empty;
        [Required, StringLength(280)]
        public string DescriptionCorta { get; set; } = string.Empty;
        [Required]
        public string DescripcionLarga { get; set; } = string.Empty;
        [Required]
        public string PublicoObjetivos{ get; set; } = string.Empty;
        [Required]
        public string Objetivos { get; set; } = string.Empty;
        [Required]
        public string Requisitos { get; set; } = string.Empty;
        public Nivel Nivel { get; set; } = Nivel.Basico;

        [Required]
        public ICollection<Category> categories { get; set;} = new List<Category>();
        [Required]

        public Chapter Chapter { get; set; } =  new Chapter();
        [Required]
       
        public ICollection<Student> students { get; set; } = new List<Student>();
       



    }
}
