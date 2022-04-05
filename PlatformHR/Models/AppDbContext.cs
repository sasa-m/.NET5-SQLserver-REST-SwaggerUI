using Microsoft.EntityFrameworkCore;
using System;

namespace PlatformHR.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<CandidateSkill> CandidatesSkills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Candidate>().HasData(new Candidate
            {
                Id = 1,
                FullName = "Branko Lazic",
                DateOfBirth = new DateTime(1988, 03, 07),
                ContactNumber = 641234567,
                Email = "bl@gmail.com"
            });

            modelBuilder.Entity<Candidate>().HasData(new Candidate
            {
                Id = 2,
                FullName = "Luka Mitrovic",
                DateOfBirth = new DateTime(1986, 05, 11),
                ContactNumber = 641234567,
                Email = "lm@gmail.com"
            });

            modelBuilder.Entity<Candidate>().HasData(new Candidate
            {
                Id = 3,  
                FullName = "Marko Simonovic",
                DateOfBirth = new DateTime(1982, 10, 09),
                ContactNumber = 641234567,
                Email = "ms@gmail.com"
            });

            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 1,
                Name = "Java",
            });

            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 2,
                Name = "C#",
            });

            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 3,
                Name = "Database Design",
            });

            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 4,
                Name = "English",
            });

            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 5,
                Name = "Russian",
            });

            modelBuilder.Entity<Skill>().HasData(new Skill
            {
                Id = 6,
                Name = "German",
            });

            modelBuilder.Entity<CandidateSkill>().HasOne(c => c.Candidate).WithMany(cs => cs.CandidateSkills).HasForeignKey(ci => ci.CandidateId);

            modelBuilder.Entity<CandidateSkill>().HasOne(c => c.Skill).WithMany(cs => cs.CandidateSkills).HasForeignKey(ci => ci.SkillId);
        }

    }
}
