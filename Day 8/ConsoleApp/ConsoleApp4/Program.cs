using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

internal class Program
{

    static void Main()
    {

        #region Problem 1
        //IVehicle Vehicle = new Car();   
        //IVehicle Vehicle2 = new Bike();
        //Vehicle.StartEngine();
        //Vehicle.EndEngine();
        //Vehicle2.StartEngine();
        //Vehicle2.EndEngine();
        //// Question : Why is it better to code against an interface rather than a concrete class? 
        //// to access all the types that implement that interface.

        #endregion

        #region Problem 2

        //IShape shape = new Rectangle(10, 2);
        //IShape shape2 = new Circle(1);
        //Console.WriteLine($"{shape.GetArea()}");
        //Console.WriteLine($"{shape2.GetArea()}");
        // Question :  When should you prefer an abstract class over an interface? 
        // When I need to add the relation IS-A and also the abstarct class can:
        // 1- has some Attributes
        // 2- has some non-abstract methods where can be used in children with the same implementation
        #endregion

        #region Problem 3

        //Product p1 = new Product("Bike", 1, 740);
        //Product p2 = new Product("Game", 2, 710);
        //Product p3 = new Product("Car", 3, 2240);
        //Product p4 = new Product("Butter", 4, 40);
        //Product p5 = new Product("7aga", 5, 10);
        //List<Product> products = new List<Product> { p1, p2, p3, p4, p5 };
        //products.Sort();
        //foreach(var product in products)
        //{
        //    Console.WriteLine(product.Price);
        //}
        // Question: How does implementing IComparable improve flexibility in sorting? 
        // as you have the ability to make the sorting in the way I implement the method (CompareTo)

        #endregion

        #region Problem 4

        //Student s = new Student(10, "Khaled" , 95);
        //Student s2 = new Student(s);
        //s2.ID = 11;
        //s2.Grade = 80;
        //s2.Name = "Ahmed";
        //Console.WriteLine(s);
        //Console.WriteLine(s2);
        // Question: What is the primary purpose of a copy constructor in C#? 
        // to copy the values of the object only with a new reference
        #endregion

        #region Problem 5
        //Robot Robot = new Robot();
        //Robot.Waik();
        //Question: How does explicit interface implementation help in resolving naming conflicts? 
        //by Implementing the method using the interface name and access the method by an interface reference
        #endregion

        #region Problem 6
        //Account ac = new Account();
        //ac.SetID(12);
        //ac.SetBalance(1000);
        //ac.SetAccountHolder("Diaa Alawady");
        // Question: What is the key difference between encapsulation in structs and classes? 
        // they both can apply encapsulation by access modifiers
        #endregion

        #region Problem 7

        //ConsoleLogger logger = new ConsoleLogger();
        // Question: How do default interface implementations affect backward compatibility in C#?
        // The class will not have to implement all the methods inside the interface
        // and use the defualt implementation from the interface
        #endregion


        #region Problem 8
        //Book b1 = new Book();
        // Question: How does constructor overloading improve class usability? 
        // By make a different instance of a class with different sets of Parameters 
        #endregion

        #region Problem 9

        // 2- What we mean by coding against interface rather than class ? and if u get it so
        // applying the functionality of a program by implementing interfaces
        //What we mean by code against abstraction not concreteness ?
        // apply the functionality of the object from an abstract. 

        #endregion



    }

}

//public interface IVehicle
//{
//    void StartEngine();
//    void EndEngine();
//}

//public class Car : IVehicle
//{
//    public void EndEngine()
//    {
//        Console.WriteLine("End Engine for Car");
//    }

//    public void StartEngine()
//    {
//        Console.WriteLine("Start Engine For Car");
//    }
//}

//public class Bike : IVehicle
//{
//    public void EndEngine()
//    {
//        Console.WriteLine("End Engine for Bike");
//    }

//    public void StartEngine()
//    {
//        Console.WriteLine("start Engine for Bike");
//    }
//}



//abstract public class Shape
//{
//    public string Name { get; set; }
//    abstract public double GetArea();

//    public void Display()
//    {
//        Console.WriteLine($"This is a {Name}");
//    }
//}

//public interface IShape
//{
//    double GetArea();
//    void Display();
//}
//public class Rectangle : IShape
//{

//    public int w { get; set; }
//    public int h { get; set; }
//    public double GetArea() => w * h;

//    public void Display()
//    {
//        Console.WriteLine("Rectangle");

//    }

//    public Rectangle(int w , int h)
//    {
//        this.w = w;
//        this.h = h;
//    }
//}


//public class Circle : IShape
//{
//    public int r { get; set; }
//    public double GetArea() => Math.PI * r * r;
//    public Circle(int r)
//    {
//        this.r = r;
//    }
//    public void Display()
//    {
//        Console.WriteLine("Circle");
//    }
//}



//public class Product : IComparable<Product>
//{
//    public string Name { get; set; }
//    public int ID { get; set; }
//    public double Price { get; set; }
//    public Product(string Name , int ID , double Price)
//    {
//        this.Name = Name;
//        this.Price = Price;
//        this.ID = ID;
//    }

//    public int CompareTo(Product other)
//    {
//        if (other == null)
//            return 1;
//        return Price.CompareTo(other.Price);
//    }

//}


//public class Student
//{
//    public int ID { get; set; }
//    public string Name { get; set; }
//    public double Grade { get; set; }

//    public Student(int ID , string Name , double Grade)
//    {
//        this.ID = ID;
//        this.Name = Name;
//        this.Grade = Grade;
//    }

//    public Student(Student other)
//    {
//        this.ID = other.ID;
//        this.Name = other.Name;
//        this.Grade = other.Grade;
//    }

//    public override string ToString()
//    {
//        return $"Name:{Name} , ID:{ID} , Grade:{Grade}";
//    }
//}


//public interface IWaikable
//{
//    void Waik();
//}

//public class Robot : IWaikable
//{
//    void IWaikable.Waik()
//    {
//        Console.WriteLine("Explict Implementation From Interface");
//    }
//    public void Waik()
//    {
//        Console.WriteLine("Waik Method in Robot");
//    }
//}


//struct Account 
//{

//    #region Attributes
//    private int AccountID;
//    private string AccountHolder;
//    private double Balance;
//    #endregion

//    #region Properties

//    public void SetID(int ID)
//    {
//        this.AccountID = ID;
//    }
//    public void SetAccountHolder(string AccountHolder)
//    {
//        this.AccountHolder = AccountHolder;
//    }
//    public void SetBalance(double Balance)
//    {
//        this.Balance = Balance;
//    }
//    public int GetID() => AccountID;
//    public double GetBalance() => Balance;

//    public string GetAccountHolder => AccountHolder;

//    #endregion

//}


//public interface ILogger
//{
//    public void Log()
//    {
//        Console.WriteLine("Default Implementation");
//    }
//}

//public class ConsoleLogger : ILogger
//{
//    //public void Log()
//    //{
//    //    Console.WriteLine("Log in the Console");
//    //}

//}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book()
    {
        
    }
    public Book(string Title)
    {
        this.Title = Title;
    }
    public Book(string Author , string Title)
    {
        this.Author = Author;
        this.Title = Title;
    }



}