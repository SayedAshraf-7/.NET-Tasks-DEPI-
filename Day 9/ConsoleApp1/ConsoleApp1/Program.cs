using System;
using System.ComponentModel;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task
{
    internal class Program
    {
        public static void Main()
        {


        }
            #region Problem 1
            //foreach (var item in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine($"Item {item} = {(int)item} ");
            //}
            // Question: Why is it recommended to explicitly assign values to enum members in some cases? 
            // to use some specific values.

            #endregion

            #region Problem 2
            //foreach (var item in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{item} = {(short)item}");
            //}

            #endregion

            #region Problem 3
            //Person p1 = new Person("Khaled", 21, 1);
            //Person p2 = new Person("Ahmed" , 22 , 3);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            // Question What is the purpose of the virtual keyword when used with properties?
            // allows a derived class to override that property and provide its own implementation.
            #endregion

            #region Problem 4
            //Child c = new Child("Sayed", 21, 1);
            //c.DisplaySalary();
            #endregion

            #region Problem 5

            //Console.WriteLine(Utility.RectanglePerimeter(10,10));
            //  Question: What is the key difference between static and object members? 
            // static members don't depend on the instance and used directly from the class wihout an instance
            // object: need an instance to be used 
            #endregion

            #region Problem 6

            //ComplexNumber n1 = new ComplexNumber(1, 3);
            //ComplexNumber n2 = new ComplexNumber(2, 3);
            //ComplexNumber n3 = n1 * n2;
            //Console.WriteLine(n3);
            // Question: Can you overload all operators in C#? Explain why or why not.
            // no not all operators some of them are defind by the langauge.

            #endregion

            #region Problem 7
            // using int as enum underlying type allow adding more values
            // but increase memory usage to 4 bytes.
            // Question: When should you consider changing the underlying type of an enum?
            // for memory efficiency
            #endregion

            #region Problem 8
            //int TempratureInCluseis = 29;
            //Console.WriteLine(Utility.CelsiusToFahrenheit(TempratureInCluseis));
            //Question:  Why can't a static class have instance constructors? 
            // because you cannot create an instance (object) of a static class.
            #endregion

            #region Problem 9

            //string Grade = Console.ReadLine();
            //if (Enum.TryParse(Grade, true, out Grades grade))
            //{
            //    Console.WriteLine($"Grade: {grade}");
            //    Console.WriteLine($"Value: {(int)grade}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade. Please enter A, B, C, D, E, or F.");
            //}
            // Question: What are the advantages of using Enum.TryParse over direct parsing with int.Parse ?
            // TryParse uses an excpetion handling by returning a boolean value to show the casting state

            #endregion

            #region Problem 10

            //Employee emp1 = new Employee(1 , "Ahmed");
            //Employee emp2 = new Employee(2 , "Hassan");
            //Employee emp3 = new Employee(4 , "Sayed");
            //Employee emp4 = new Employee(5 , "Mohamed");
            //Employee[] emps = { emp1, emp2, emp3 , emp4};
            //int res = Helper<Employee>.SearchArr(emps, emp4);
            //Console.WriteLine(res);
            // Question:  What is the difference between overriding Equals and == for object comparison in C# struct and class ? 
            // equals and == for struct make a comparsion values based but in reference types like classes
            // they compare the objects by references not values till they are overriden
            //  Question: why is overriding ToString beneficial when working with custom classes? 
            // to customize the way of demonstrating the object with its members

            #endregion

            #region Problem 11
            //Console.WriteLine(Helper<int>.Max(10,20));
            //Console.WriteLine(Helper<double>.Max(10.2, 20.4));
            //Console.WriteLine(Helper<string>.Max("IZ", "Programming"));
            // Question:Can generics be constrained to specific types in C#? Provide an example. 
            // Yes it can be contrained to reference only or value type or even by types that implement a specific interfaces
            #endregion

            #region Problem 12

            //int[] arr = { 1, 2, 3, 4, 1, 1 };
            //Helper<int>.ReplaceArray(arr, 1, 3);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Question: What are the key differences between generic methods and generic classes ?
            // A generic method allows a single method to work with different data types, while a generic class allows the entire class and its members to work with a specified type.

            #endregion

            #region Problem 13
            //Rectangle rec1 = new Rectangle(10,2);
            //Rectangle rec2 = new Rectangle(7,8);
            //Console.WriteLine(rec1);
            //Console.WriteLine(rec2);
            //Swap(ref  rec1, ref rec2);
            //Console.WriteLine(rec1);
            //Console.WriteLine(rec2);

            //Question:Why might using a generic swap method be preferable to implementing custom methods for each type? 
            // to avoid rewriting the same code many times for each type -> reusability
            // easy to maintain the logic of the method  for one time -> maintainability
            #endregion

            #region Problem 14
            //clsDepartement dep1 = new clsDepartement(1,"IT");
            //clsDepartement dep2 = new clsDepartement(2,"Software Engineering");
            //Employee e1 = new Employee(1, "Khaled",dep1);
            //Employee e2 = new Employee(1, "Ahmed",dep2);
            //Employee e3 = new Employee(1, "Hassan",dep1);
            //Employee e4 = new Employee(1, "Weal",dep2);
            //Employee[] emps = { e1,e2,e3};
            //int res = Helper<Employee>.SearchArr(emps, e4);
            //Console.WriteLine(res);
            // How can overriding Equals for the Department class improve the accuracy of searches?
            // becuase Departement is a refernce type and be able to compare all departement fields
            #endregion

            #region Problem 15

            //Circle c1 = new Circle(10, "Blue");
            //Circle c2 = new Circle(10, "Blue");
            //Console.WriteLine(c1 == c2);
            //Console.WriteLine(c1.Equals(c2));
            //Question: Why is == not implemented by default for structs ?
            // can use equals and make a normal comparsion as circle is a value type
            // == must be overloaded and write its behavouir
            // but == and equals in classes inherited from the (object) but must be overriden as the compare instancec by its references

            #endregion

            //2 - What we mean by Generalization concept using Generics?
            //Generalization using Generics means writing one class or method that can work with different data types instead of writing separate code for each type.
            //3 - What we mean by hierarchy design in real business ? 
            //Hierarchy design means organizing business entities into levels or relationships, where higher - level entities can contain or manage lower-level entities.

            #region Problem 16 

            public static void ReverseArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Swap<T>(arr, i, arr.Length - i - 1);
            }
        }

        #endregion

            #region Problem 17

        class MyStack<T>
        {
            private T[] items;
            private int top;

            public MyStack(int size)
            {
                items = new T[size];
                top = -1;
            }

            public void Push(T item)
            {
                if (top == items.Length - 1)
                {
                    Console.WriteLine("Stack is full.");
                    return;
                }

                top++;
                items[top] = item;
            }
            public T Pop()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                T item = items[top];
                top--;

                return item;
            }

            public T Peek()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                return items[top];
            }
        }

        #endregion

            #region Problem 18

        static void Swap<T>(T[] arr, int index1, int index2)
        {
            T temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        #endregion

            #region Problem 19

        static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        #endregion
    }

}


    