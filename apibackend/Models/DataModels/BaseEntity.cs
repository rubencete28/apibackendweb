using System.ComponentModel.DataAnnotations;

namespace apibackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]

        [Key]

        public int? Id { get; set; }
       
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

       
        public string UpdateBy { get; set; } = string.Empty ;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime DeletedAt { get; set; } = DateTime.Now;
        //public User DeletedBy { get; set; } = new User();
        public string DeletedBy { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        

    }
}
