using Microsoft.EntityFrameworkCore;
using MANAOG_ITELEC_3ITE.Models;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace MANAOG_ITELEC_3ITE.Database
{

    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    FirstName = "Ashley",
                    LastName = "Manaog",
                    Course = Course.BSIT,
                    AdmissionDate = DateTime.Parse("2022-07-19"),
                    GPA = 1.0,
                    Email = "ASHLITAYM@gmail.com"
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Geto",
                    LastName = "Satorou",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-12-05"),
                    GPA = 1,
                    Email = "GS@gmail.com"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Chuuya",
                    LastName = "Nishinoya",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-02-15"),
                    GPA = 1.5,
                    Email = "ac@gmail.com"
                });


            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Nishinoya",
                    LastName = "Yu",
                    IsTenured = true,
                    Rank = Rank.instructor,
                    HiringDate = DateTime.Parse("2022-07-19"),
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Chuuya",
                    LastName = "Nakahara",
                    IsTenured = true,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("2022-12-05")
                }
            );
        }
    }
       
}
