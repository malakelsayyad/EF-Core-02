using Assignment.Context;
using Assignment.Entities;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            using AppDbContext dbContext = new AppDbContext();

            #region Crud Operations 

            #region Insert
            //var Instructor01 = new Instructor() { Name = "Mohamed",Bonus=1500,Salary=11000,HourRate=200 , Address ="Cairo"};
            //var Instructor02 = new Instructor() { Name = "Ahmed",Bonus=1500,Salary=12000 ,HourRate=200, Address ="Giza"};

            //var Student01 = new Student() { FName = "Mohamed",LName="Ali", Address = "Cairo",Age=15 };
            //var Student02 = new Student() { FName = "Ahmed", LName = "Ali", Address = "Giza", Age = 16 };

            //var Department01 = new Department() {Name="English"};
            //var Department02 = new Department() { Name = "French" };

            //var Topic01 = new Topic() { Name = "Chemistry" };
            //var Topic02 = new Topic() { Name = "Math" };

            //var Course01 = new Course() { Name = "FrontEnd", Description = "Design" };
            //var Course02 = new Course() { Name = "BackEnd", Description = "Logic" };

            //dbContext.Add(Department01);
            //dbContext.Add(Department02);

            //dbContext.Add(Topic01);
            //dbContext.Add(Topic02);

            //dbContext.Add(Instructor01);
            //dbContext.Add(Instructor02);

            //dbContext.Add(Student01);
            //dbContext.Add(Student02);

            //dbContext.Add(Course01);
            //dbContext.Add(Course02);

            //dbContext.SaveChanges();

            #endregion

            #region Read/Retrieve

            //var result = dbContext.Departments.FirstOrDefault(D => D.Id == 2);
            //var result = dbContext.Instructors.FirstOrDefault(I => I.Id == 2);
            //var result = dbContext.Courses.FirstOrDefault(C => C.Id == 2);
            //var result = dbContext.Students.FirstOrDefault(S => S.Id == 2);
            //var result = dbContext.Topics.FirstOrDefault(T => T.Id == 2);

            //Console.WriteLine(result?.Name??"Na");

            #endregion

            #region Update

            //var result = dbContext.Courses.FirstOrDefault(C => C.Id == 1);
            //result.TopicId = 1;
            //dbContext.SaveChanges();

            //var result = dbContext.Courses.FirstOrDefault(C => C.Id == 2);
            //result.TopicId = 2;
            //dbContext.SaveChanges();

            //var result = dbContext.Topics.FirstOrDefault(T => T.Id == 2);
            //result.Name = "Arabic";
            //dbContext.SaveChanges();

            //var result = dbContext.Students.FirstOrDefault(S => S.Id == 2);
            //result.FName = "Malak";
            //dbContext.SaveChanges();

            //var result = dbContext.Instructors.FirstOrDefault(I => I.Id == 2);
            //result.Name = "Mahmoud";
            //dbContext.SaveChanges();

            //var result = dbContext.Departments.FirstOrDefault(D => D.Id == 2);
            //result.Name = "HR";
            //dbContext.SaveChanges();

            #endregion

            #region Delete

            //var result = dbContext.Courses.FirstOrDefault(C => C.Id == 2);
            //dbContext.Courses.Remove(result);
            //dbContext.SaveChanges();

            //var result = dbContext.Topics.FirstOrDefault(T => T.Id == 2);
            //dbContext.Topics.Remove(result);
            //dbContext.SaveChanges();

            //var result = dbContext.Students.FirstOrDefault(S => S.Id == 2);
            //dbContext.Students.Remove(result);
            //dbContext.SaveChanges();

            //var result = dbContext.Instructors.FirstOrDefault(I => I.Id == 2);
            //dbContext.Instructors.Remove(result);
            //dbContext.SaveChanges();

            //var result = dbContext.Departments.FirstOrDefault(D => D.Id == 2);
            //dbContext.Departments.Remove(result);
            //dbContext.SaveChanges();

            #endregion

            #endregion


        }
    }
}
