public class Employee
{
    public double Salary { get; set; }
    public string Name { get; set; }
    public Employee(string Name , double Salary)
    {
        this.Name = Name;
        this.Salary = Salary;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Salary: {Salary}";
    }

}