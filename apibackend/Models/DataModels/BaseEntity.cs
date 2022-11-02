using System.ComponentModel.DataAnnotations;

namespace apibackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        //public int userID { get; set; }
        //public  User CreateBy { get; set; } = new User();
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //public User UpdateBy { get; set; } = new User();
        public string UpdateBy { get; set; } = string.Empty ;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime DeletedAt { get; set; } = DateTime.Now;
        //public User DeletedBy { get; set; } = new User();
        public string DeletedBy { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        

    }
}
