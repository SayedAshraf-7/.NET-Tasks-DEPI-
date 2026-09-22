namespace Task
{
    public class Child : Person
    {
        public sealed override int Salary { get; set; }
        public Child(string Name, int Age, int DepartementNum) : base(Name, Age, DepartementNum)
        {

        }
        public void DisplaySalary()
        {
            Console.WriteLine($"Salary : {Salary}");
        }
    }



}
