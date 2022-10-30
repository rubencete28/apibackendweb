using Microsoft.EntityFrameworkCore;
using apibackend.Models.DataModels;

namespace apibackend.Dates
{
    public class UniversityDb : DbContext
    {
        public UniversityDb(DbContextOptions<UniversityDb> options): base(options)
        {

        }
        public DbSet<Users> ?Users { get; set; }
        public DbSet<Cursos>? Cursos { get; set; }



    }
}
