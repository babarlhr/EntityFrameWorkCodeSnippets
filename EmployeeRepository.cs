//Repository pattern . 
//Properties are defined in Employee class
//Any method implemtation to get Employee calss data is implemented here
// here we are getting List of departments 
//This class contains methods which going to return data that we want. 
//Write custom logic to return one department, one employee. all department (List<Department>), all employee (List<Employee>)

public class EmployeeRepository
{
    public List<Department> GetDepartments()
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();
        return employeeDBContext.Departments.Include("Employees").ToList();
    }
}
