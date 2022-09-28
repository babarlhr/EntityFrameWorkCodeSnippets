public class Department
{
    // Scalar Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    // Navigation Property
    //A Department can have many employee
    //0:1 (Department : Employee)=>  Department can be 0 or 1 , but every department must have 1 or more Emplyees 
    //1:Many => RelationShip
    
    public List<Employee> Employees { get; set; }
}
