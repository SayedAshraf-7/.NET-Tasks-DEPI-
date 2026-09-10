using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;


namespace ConsoleApp1
{

    internal partial class Program
    {
        static void Main(string[] args)
        {


            #region Problem 1
            //      public struct Point
            //{
            //    public int X { get; set; }
            //    public int Y { get; set; }

            //    public Point(int X, int Y)
            //    {
            //        this.X = X;
            //        this.Y = Y;
            //    }

            //    public Point()
            //    {

            //    }

            //}
            // Question: Why can't a struct inherit from another struct or class in C#? 
            // becuase the struct already inhert from the class System.ValueType and C# don't allow multiple inheritance
            #endregion

            #region Problem 2
            //TypeA obj = new TypeA();
            //Console.WriteLine(obj.G);
            //Console.WriteLine(obj.H);
            //Console.WriteLine(obj.F); // Can't access F because it's private(Protection Level)
            //public class TypeA
            //{
            //    private int F { get; set; }

            //    internal int G { get; set; }

            //    public int H { get; set; }
            //}
            // Question: How do access modifiers impact the scope and visibility of a class member?
            // because the access modifier control if the member will be :
            // public : Accessisable in every where
            // private : Accessisable inside the class only
            // protected : inside the class and classes inherits from this class
            // internal : inside the same project

            #endregion

            #region Problem 3

            //public struct Employee
            //{
            //    private int _ID;

            //    private string _Name;

            //    private double _Salary;

            //    public int GetID()
            //    {
            //        return _ID;
            //    }
            //    public void SetID(int ID)
            //    {
            //        this._ID = ID;
            //    }
            //    public void SetName(string Name)
            //    {
            //        this._Name = Name;
            //    }
            //    public string GetName()
            //    {
            //        return this._Name;
            //    }
            //    public double GetSalary()
            //    {
            //        return this._Salary;
            //    }
            //    public void SetSalary(double Salary)
            //    {
            //        this._Salary = Salary;
            //    }

            //}

            //Employee emp = new Employee();
            //emp.SetName("Sayed");
            //emp.Salary = 10000; // Error because of Protection Level(private field)
            //emp.SetSalary(10000);
            //emp.Name = "Sayed"; // Error becuase of level protection (private field)

            // Question: Why is encapsulation critical in software design? 
            // Becuase it prevents the direct access of the data inside the object and assign it to wrong values
            // protect the data from changed in a wrong situations
            // minizie the complexity by making the important members only public


            #endregion

            #region Problem 4
            // Point p1 = new Point(10);
            //Point p2 = new Point(10, 10); // the same object type with different Constrcutros
            // Point p3 = new Point(); // Default Constructor
            //Question: what is constructors in structs ?
            // A constructor in a struct is a special method used to initialize the struct when you create an object.
            #endregion

            #region Problem 5
            //Point p1 = new Point(10);
            //Console.WriteLine(p1);
            // Question: How does overriding methods like ToString() improve code readability? 
            // to customize the printing way to make the reading of the object easier and better

            #endregion

            #region Problem 6
            //Point p1 = new Point(10, 10);
            //Console.WriteLine(p1);// X: 10 , Y: 10
            //IncrementPointBy1(p1);
            //Console.WriteLine(p1);// X: 10 , Y: 10
            ////############################
            //Employee emp = new Employee();
            //emp.Age = 21;
            //Console.WriteLine(emp); // Age: 21
            //IncremeantEmpAgeBy1(emp);
            //Console.WriteLine(emp); // Age: 22
            // Question: How does memory allocation differ for structs and classes in C#?
            // struct : value-type where it is allocated in the stack 
            // class : reference-type where allocated in the heap
            #endregion

            #region What is copy constructor? 
            //A copy constructor is a constructor that creates a new object/
            //value by copying the data from an existing object of the same type.
            //Employee emp1 = new Employee("Sayed" , 10000 , 21);
            //Employee emp2 = new Employee(emp1);
            //emp2.Age = 30;
            //Console.WriteLine(emp1);
            #endregion

            #region What is Indexer, when used, as business mention cases u have to utilize it? 
            //an indexer gives users a convenient way to access its internal data without exposing the actual storage.

            #endregion


            #region Summarize keywords we have learnt last lecture
            //struct	Value type
            //class Reference type
            //public Public access
            //private Restricted access
            //protected Inherited access
            //internal Assembly access
            //get Read value
            //set Write value
            //init Initial assignment
            //readonly Fixed field
            //this	Current instance
            //new Create instance
            //override Replace implementation
            #endregion
        }


        //static public void IncremeantEmpAgeBy1(Employee emp)
        //{
        //    emp.Age++;
        //}
        //static public void IncrementPointBy1(Point p)
        //{
        //    // new instance created from object as it is a value type
        //    // Point temp = p (new instance created and modifies)
        //    p.X++;
        //    p.Y++;
        //}



    }

    //public class Employee
    //{

    //    public string Name { get; set; }

    //    public double Salary { get; set; }
    //    public int Age { get; set; }

    //    public Employee(string Name , double Salary , int Age)
    //    {
    //        this.Name = Name;
    //        this.Salary = Salary;
    //        this.Age = Age;
    //    }

    //    public Employee(Employee emp)
    //    {
    //        this.Name = emp.Name;
    //        this.Salary = emp.Salary;
    //        this.Age = emp.Age;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Age: {Age}";
    //    }

    //}


    //public struct Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Point(int X)
    //    {
    //        this.X = X;
    //        this.Y = 0;
    //    }
    //    public Point(int X , int Y)
    //    {
    //        this.X = X;
    //        this.Y = Y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"X: {X} , Y: {Y}";
    //    }
    //}

}

