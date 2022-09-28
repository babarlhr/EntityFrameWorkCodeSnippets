// EmployeeDBContext class must inherit from DbContext
// present in System.Data.Entity namespace
//EmployeeDBContext class use to access database. it will use DBcontext to provide Connection string and all other database operations.
//database operations. => (Create tables,updating tables,Saving and Getting data from database tables)

public class EmployeeDBContext : DbContext
{
    public DbSet<Department> Departments { get; set; } //Making tables in database . 
                                                       //DbContext use this properties to get underlying Department table values.
                                                       //Departments property can access to all table (Here:Department) values based on contditions. 
                                                       //conditions mostly provided by LINQ syntax
                                                       //in sense of C# .Departments  can access all public properties of Department class.
    public DbSet<Employee> Employees { get; set; }
}
