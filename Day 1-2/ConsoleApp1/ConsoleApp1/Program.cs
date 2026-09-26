using System;
using System.Collections;
using System.Data;

internal class Program
{
    public delegate bool SalaryHandler(double val , double Salary); 
    public static void Main()
    {

        #region Problem 1
        //var x = 10;
        //var name = "Khaled";
        //var d = 1.23d;
        //var flag = true;
        //var arr = new [] { 1, 2, 4 };
        //Console.WriteLine(x.GetType());
        //Console.WriteLine(name.GetType());
        //Console.WriteLine(d.GetType());
        //Console.WriteLine(flag.GetType());
        //Console.WriteLine(arr.GetType());
        #endregion

        #region Problem 2
        //var VarName = "Sayed";
        //string StrName = "Sayed";
        //int IntAge = 30;
        //var VarAge = 30;
        //Console.WriteLine(VarName);
        //Console.WriteLine(StrName);
        //Console.WriteLine(VarAge);
        //Console.WriteLine(IntAge);
        // They Have the same result in Compile time as 
        // var works in compile time and remove the var word with the data type
        // needed to store this value stored in.
        #endregion

        #region Problem 3
        //var Product = new { Name = "Egg", Price = 5, Quantity = 31 };
        //Console.WriteLine(Product);
        //Console.WriteLine(Product.Name);
        //Console.WriteLine(Product.Price);
        //Console.WriteLine(Product.Quantity);
        #endregion

        #region Problem 4
        //var arr = new[] { 

        //    new { Name = "Sayed" ,Grade = 100} , 
        //    new { Name = "Islam", Grade = 90},
        //    new { Name = "Omar", Grade = 70}
        //};
        //foreach (var student in arr)
        //{
        //    Console.WriteLine(student);
        //}
        #endregion

        #region Problem 5
        //var Order = new {
        //    OrderID = 100,
        //    OrderName = "Order11",
        //    Customer = new
        //    {
        //        Name = "Ali",
        //        City = "Los Anglos"
        //    }
        //};
        //Console.WriteLine(Order);
        #endregion

        #region Problem 6
        //string s = "Name";
        //Console.WriteLine(s.IsPalindrome());
        //s = "Ahmed";
        //Console.WriteLine(s.IsPalindrome());
        //s = "Ahha";
        //Console.WriteLine(s.IsPalindrome());
        //s = "s";
        //Console.WriteLine(s.IsPalindrome());
        //s = "AhA";
        //Console.WriteLine(s.IsPalindrome());
        //s = "";
        //Console.WriteLine(s.IsPalindrome());
        #endregion

        #region Problem 7
        //int n = 10;
        //Console.WriteLine(n.isPrime());
        //n = 11;
        //Console.WriteLine(n.isPrime());
        //n = 15;
        //Console.WriteLine(n.isPrime());
        //n = 67;
        //Console.WriteLine(n.isPrime());
        #endregion

        #region Problem 8
        //int[] arr = { 1, 2, 3, 4, 5 };

        //Console.WriteLine(arr.Sum2());

        #endregion

        #region Problem 9

        //List<string> EmployeeNames = new List<string>
        //{ "Sayed" , "Ahmed" , "Khaled" , "Ali" };
        //EmployeeNames.Add("Osama");
        //EmployeeNames.Remove("Ahmed");
        //bool f = false;
        //foreach (var name in EmployeeNames)
        //{
        //    if (name == "Osama")
        //        f = true;
        //}
        //if (f)
        //    Console.WriteLine("Found");
        //else
        //    Console.WriteLine("Not Found");

        #endregion

        #region Problem 10

        //Employee emp1 = new Employee("Ahmed" , 900);
        //Employee emp2 = new Employee("Kahled" , 1100);
        //Employee emp3 = new Employee("Hassan" , 1200);
        //List<Employee> emps = new List<Employee>();
        //emps.Add(emp1);
        //emps.Add(emp2);
        //emps.Add(emp3);
        //SalaryHandler Handler = isValidSalary;
        //foreach (var item in emps)
        //{
        //    if(Handler.Invoke(1000,item.Salary))
        //        Console.WriteLine(item);
        //}

        #endregion

        #region Problem 11


        //Dictionary<string, int> products = new Dictionary<string, int>();

        //products.Add("p1", 25000);
        //products.Add("p2", 500);
        //products.Add("p3", 1200);
        //products.Add("p4", 8000);

        //foreach (var item in products)
        //{
        //    Console.WriteLine($"{item.Key} : {item.Value}");
        //}
        #endregion

        #region Problem 12

        //Dictionary<int, string> students = new Dictionary<int, string>();

        //students.Add(101, "Ahmed");
        //students.Add(102, "Mona");
        //students.Add(103, "Omar");
        //students.Add(104, "Sara");
        //Console.Write("Enter student ID: ");
        //int id = int.Parse(Console.ReadLine());

        //if (students.TryGetValue(id, out string name))
        //{
        //    Console.WriteLine($"Student name: {name}");
        //}
        //else
        //{
        //    Console.WriteLine("Student not found.");
        //}
        #endregion

        #region Problem 13
        Hashtable data = new Hashtable();

        data.Add(1, "Ahmed");
        data.Add(2, "Mona");
        data.Add(3, "Omar");

        foreach (DictionaryEntry pair in data)
        {
            Console.WriteLine($"{pair.Key} => {pair.Value}");
        }
        #endregion
    }

    //private static bool isValidSalary(double val,double Salary)
    //{
    //    return Salary > val;
    //}

  
}
