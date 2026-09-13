using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using static System.Net.WebRequestMethods;


namespace ConsoleApp1
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            #region Problem 1
            //     public class Car
            //{

            //    #region Private Properties
            //    private int _id;
            //    private string _brand;
            //    private double _price;
            //    #endregion

            //    #region Setters and Getters
            //    public int ID
            //    {
            //        get => _id;
            //        set { _id = value; }
            //    }

            //    public string Brand
            //    {
            //        get => _brand;
            //        set { _brand = value; }
            //    }
            //    public double Price
            //    {
            //        get => _price;
            //        set { _price = value; }
            //    }
            //    #endregion

            //    #region Constructors

            //    public Car()
            //    {
            //        this.ID = -1;
            //        this.Price = 0;
            //        this.Brand = "Unknown";
            //    }
            //    public Car(int ID) : this()
            //    {
            //        this.ID = ID;
            //    }

            //    public Car(int ID, string Brand) : this(ID)
            //    {
            //        this.Brand = Brand;
            //    }
            //    public Car(int ID, string Brand, double Price) : this(ID, Brand)
            //    {
            //        this.Price = Price;
            //    }

            //    #endregion


            //    public override string ToString()
            //    {
            //        return $"ID: {ID},Brand: {Brand} , Price:{Price}";
            //    }
            //}

            //Car c1 = new Car(1, "BMW", 10000);
            //Car c2 = new Car(2, "Toyota", 10000);
            //Car c3 = new Car(3, "Honda", 10000);
            //Car c4 = new Car(4, "Nissan", 10000);
            //Car c5 = new Car(5, "Nissan");
            //Car c6 = new Car(6);
            //Car c7 = new Car();
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            // Question: Why does defining a custom constructor suppress the default constructor in C#?
            // becuase after creating a constructor the you specify the way the object will be constructed
            #endregion

            #region Problem 2

            //public class Calculator
            //{
            //    public int Sum(int n1 , int n2)
            //    {
            //        return n1 + n2;
            //    }

            //    public int Sum(int n1 , int n2 , int n3)
            //    {
            //        return n1 + n2 + n3;
            //    }

            //    public double Sum(double n1 , double n2)
            //    {
            //        return n1 + n2;
            //    }
            //}
            //Calculator cal = new Calculator();
            //Console.WriteLine(cal.Sum(10, 2));
            //Console.WriteLine(cal.Sum(10, 2,2));
            //Console.WriteLine(cal.Sum(10.2, 2.2));
            //Question: How does method overloading improve code readability and reusability ?
            // becuase it allows you to use the method with different number of parameters and
            // different types.
            #endregion

            #region Problem 3
            //Parent p = new Parent(10, 12);
            //Parent c = new Child(10, 12, 15);

            //Console.WriteLine(p);
            //Console.WriteLine(c);
            //Question: What is the purpose of constructor chaining in inheritance?
            // to call the constructor of the base first and intialize its properties
            #endregion

            #region Problem 4
            //Parent p = new Parent(10, 2);
            //Child c = new Child(10, 2, 2);
            //Console.WriteLine(p.Product());
            //Console.WriteLine(c.Product()); 
            //Question: How does new differ from override in method overriding? 
            // new: make data hiding to the inherited members
            // override: make a dynamic binding in runtime be replacing the overriden method in the method table(virtual table)
            #endregion

            #region Problem 5
            //Parent p = new Parent(10,2);
            //Child c = new Child(10, 2, 2);
            //Console.WriteLine(p);
            //Console.WriteLine(c);
            // Question: Why is ToString() often overridden in custom classes
            // because it is a virtual method indie the base class object
            #endregion

            #region Problem 6
            //Circle circle = new Circle(10);
            //circle.PrintDetails();
            //  Question: What are the benefits of default implementations in interfaces introduced in C# 8.0? 
            // The classes that implements the interface don't have to implement the method with default implementation
            // and will get only behavouirs that implements it.
            #endregion

            #region Problem 7

            //IMovable Car = new Car();
            //Car.Move();
            //Question: Why is it useful to use an interface reference to access implementing class methods? 
            // to be able to access all the objects implements this interface which apply abstarction
            #endregion

            #region Problem 8

            //File file = new File();
            //file.Read();
            //file.Write();
            // Question: How does C# overcome the limitation of single inheritance with interfaces? 
            // as the class can implement many interfaces and get behavouirs without needing to inheritance 
            // from many classes
            #endregion

            #region Problem 9
            //Rectangle rec = new Rectangle();
            //rec.Width = 10;
            //rec.Height = 2;
            //rec.Draw();
            //Console.WriteLine(rec.CalculateArea());
            // Question: What is the difference between a virtual method and an abstract method in C#? 
            // virtual method : can have implemetation and just used to overriden in the children class
            // and can have the same implemenation without change (do not have to be implemented in children)
            // abstarct : have to be implemented in child classes 
            #endregion

            #region What is the difference between class and struct in C#?
            // class: reference type, allow inhertince 
            // struct: value type, don't allow inheritance
            #endregion

            #region If inheritance is relation between classes clarify other relations between classes
            // Association: general relation between classes where one class has some classes also and 
            //and interact with
            #endregion


            #region what is static and dynamic binding 
            //Static binding is when the method to be called is determined at compile time,
            //usually through method overloading.Dynamic binding is when the method to be called is
            //determined at runtime based on the actual object, usually through method overriding and
            //polymorphism.
            #endregion

        }
    }

    //abstract public class Shape
    //{
    //    public  virtual void Draw()
    //    {
    //        Console.WriteLine("Darwing Shape");
    //    }
    //    public abstract double CalculateArea(); 
    //}


    //public class Rectangle : Shape
    //{
    //    public double Width { get; set; }

    //    public double Height { get; set; }
    //    public override double CalculateArea()
    //    {
    //        return Width * Height;
    //    }
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Draw a rectangle");
    //    }
    //}

    //public class File : IReadable, IWriteable
    //{
    //    public void Read()
    //    {
    //        Console.WriteLine("Read From File");
    //    }

    //    public void Write()
    //    {
    //        Console.WriteLine("Write On File");
    //    }
    //}
    //public interface IReadable
    //{

    //    void Read();
    //}

    //public interface IWriteable
    //{
    //    void Write();
    //}


    //public interface IMovable
    //{
    //    void Move();
    //}

    //public class Car : IMovable
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Car Moves");
    //    }
    //}

    //public interface IShape
    //{
    //    double Area { get; }
    //    void Draw();

    //    void PrintDetails()
    //    {
    //        Console.WriteLine("Details of the shape");
    //    }
    //}

    //public class Circle : IShape
    //{
    //    public int r;
    //    public double Area => Math.PI * r * r;

    //    public Circle(int r)
    //    {
    //        this.r = r;
    //    }

    //    public void Draw()
    //    {
    //        Console.WriteLine("Draw A cricle"); ;
    //    }
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine($"R: {r}");
    //    }
    //}

    //public class Rectangle : IShape
    //{
    //    public int Width { get; set; }
    //    public int Height { get; set; }
    //    public int Area => Width * Height;


    //    public Rectangle(int Width, int Height)
    //    {
    //        this.Width = Width;
    //        this.Height = Height;
    //    }
    //    public void Draw()
    //    {
    //        Console.WriteLine("Draw a rectangle");
    //    }

    //    public override string ToString()
    //    {
    //        return $"Width: {Width}, Height: {Height}";
    //    }
    //}

    //public class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int X, int Y)
    //    {
    //        this.X = X;
    //        this.Y = Y;
    //    }
    //    public override string ToString()
    //    {
    //        return $"X: {X} , Y: {Y}";
    //    }

    //    virtual public int Product()
    //    {
    //        return X * Y;
    //    }
    //}

    //public class Child : Parent
    //{
    //    public int Z { set; get; }
    //    public Child(int X, int Y, int Z) : base(X, Y)
    //    {
    //        this.Z = Z;
    //    }

    //    public override string ToString()
    //    {
    //        return base.ToString() + $", Z: {Z}";
    //    }

    //    public override int Product()
    //    {
    //        return X * Y * Z;
    //    }
    //}


}

