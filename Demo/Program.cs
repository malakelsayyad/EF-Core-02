using Demo.Contexts;
using Demo.Entity;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            //AppDbContext appDbContext = new AppDbContext();

            //try
            //{

            //}
            //finally
            //{
            //    appDbContext.Dispose();
            //}       

            //using (AppDbContext appDbContext = new AppDbContext())
            //{

            //};

            using AppDbContext dbContext = new AppDbContext();
           
            #region Crud Operations

            #region Create - Insert

            //Create - Insert
            //var employee = new Employee() 
            //{
            //  Name="Ahmed Ali",
            //  Salary=20000,
            //  Address="Cairo",
            //  Age=25
            //};
            //employee.Name = "Khaled";

            //Console.WriteLine(dbContext.Entry(employee).State);//Detached

            ////dbContext.Add(employee);
            //dbContext.Employees.Add(employee);

            //Console.WriteLine(dbContext.Entry(employee).State);//Added

            //var result=dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(employee).State);//Unchanged


            //employee.Name = "Omar";
            //Console.WriteLine(dbContext.Entry(employee).State);//Modified


            //Console.WriteLine(result);

            //dbContext.Add(employee);
            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(employee).State);

            //dbContext.Entry(employee).State=EntityState.Added;

            //Console.WriteLine(dbContext.Entry(employee).State);

            //dbContext.SaveChanges();

            #endregion

            #region  Read - Select 

            //var result = dbContext.Employees.Where(E => E.Id == 4).FirstOrDefault();
            //var result = dbContext.Employees.FirstOrDefault(E => E.EmpId == 4);

            //var result =dbContext.Employees.Select(E => E.EmpId == 4);

            //Console.WriteLine(dbContext.Entry(result).State);//Unchanged

            //result.Name = "Ali";

            //Console.WriteLine(dbContext.Entry(result).State);//Modified

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(result?.Name);
            //Console.WriteLine(result?.EmpId);
            #endregion

            #region  Update 

            //var result = dbContext.Employees.FirstOrDefault(E => E.Id == 4);

            //Console.WriteLine(dbContext.Entry(result).State);

            //result.Name = "Omar Ahmed";
            //Console.WriteLine(dbContext.Entry(result).State);

            //dbContext.Update(result);
            //Console.WriteLine(dbContext.Entry(result).State);

            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(result).State);


            #endregion

            #region  Delete 

            //var result = dbContext.Employees.FirstOrDefault(E => E.Id == 4);

            //Console.WriteLine(dbContext.Entry(result).State); //Unchanged


            //dbContext.Employees.Remove(result);
            //Console.WriteLine(dbContext.Entry(result).State);//Deleted

            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(result).State);



            #endregion

            #endregion

            //Employee employee = new Employee();
            //Department department = new Department();

            //department.Manager.

        }
    }
}
