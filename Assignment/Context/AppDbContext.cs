using Assignment.Configuration;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Instructor[FLuent APIs]
            modelBuilder.Entity<Instructor>().HasKey(I => I.Id);


            modelBuilder.Entity<Instructor>().Property(I => I.Name)
                                             .HasMaxLength(20)
                                             .IsRequired();

            modelBuilder.Entity<Instructor>().Property(I => I.Bonus)
                                             .HasColumnType("float");

            modelBuilder.Entity<Instructor>().Property(I => I.Salary)
                                             .HasColumnType("float");

            modelBuilder.Entity<Instructor>().Property(I => I.Address)
                                             .HasMaxLength(50)
                                             .HasColumnName("EmpAddress");

            modelBuilder.Entity<Instructor>().Property(I => I.HourRate)
                                             .HasColumnType("float");
            #endregion

            #region Student [By Config]
            //Student
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            #endregion

            modelBuilder.Entity<Department>()
                        .HasMany(D=>D.Students)
                        .WithOne()
                        .HasForeignKey(S=>S.DepartmentDeptId);

            modelBuilder.Entity<Department>()
                        .HasMany(D => D.Instructors)
                        .WithOne()
                        .HasForeignKey(I=>I.DepartmentDeptId);

            modelBuilder.Entity<Topic>()
                        .HasMany(T=> T.Courses)
                        .WithOne()
                        .HasForeignKey(C => C.TopicId);

            modelBuilder.Entity<CourseInstructor>()
               .HasKey(Ci => new { Ci.CrsId,Ci.InsId });

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new {SC.StudId,SC.CrsId });

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=AssignmentEf; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Course> Courses { get; set; } 
        public DbSet<Department> Departments { get; set; } 
        public DbSet<Instructor> Instructors { get; set; } 
        public DbSet<Student> Students { get; set; } 
        public DbSet<Topic> Topics { get; set; } 
        public DbSet<CourseInstructor> CourseInstructor { get; set; } 
        public DbSet<StudentCourse> StudCourse { get; set; } 

    }
}