using Microsoft.EntityFrameworkCore;
using apibackend.Models.DataModels;
using Index = apibackend.Models.DataModels.Chapter;

namespace apibackend.Dates
{
    public class UniversityDb : DbContext
    {
        public UniversityDb(DbContextOptions<UniversityDb> options): base(options)
        {

        }

        //tables incluyes
        public DbSet<User> ?Users { get; set; }
        
        public DbSet<Curso>? Cursos { get; set; }

        public DbSet<Category>? Category { get; set; }

        public DbSet<Student>? Students { get; set; }

        public DbSet<Chapter>? Chapters { get; set; }

        public DbSet<apibackend.Models.DataModels.BaseEntity> BaseEntity { get; set; }

    }
}
