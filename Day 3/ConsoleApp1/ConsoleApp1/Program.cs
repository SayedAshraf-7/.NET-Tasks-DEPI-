using System;
using System.Text;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 - Problem 1 - Parse vs Convert.ToInt32

            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //try
            //{
            //    int number1 = int.Parse(input);
            //    Console.WriteLine($"int.Parse result: {number1}");

            //    int number2 = Convert.ToInt32(input);
            //    Console.WriteLine($"Convert.ToInt32 result: {number2}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid format. Please enter a valid integer.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number is too large or too small for an int.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion

            #region Part01 - Problem 2 - TryParse

            //Console.Write("Enter an integer: ");
            //string input2 = Console.ReadLine();

            //if (int.TryParse(input2, out int number))
            //{
            //    Console.WriteLine($"The number is: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid integer.");
            //}

            #endregion

            #region Part01 - Problem 3 - GetHashCode

            //object obj;

            //obj = 10;
            //Console.WriteLine($"int GetHashCode: {obj.GetHashCode()}");

            //obj = "Hello";
            //Console.WriteLine($"string GetHashCode: {obj.GetHashCode()}");

            //obj = 10.5;
            //Console.WriteLine($"double GetHashCode: {obj.GetHashCode()}");

            #endregion

            #region Part01 - Problem 4 - Reference Equality

            //Person person1 = new Person();
            //person1.Name = "Ahmed";

            //Person person2 = person1;

            //person2.Name = "Mohamed";

            //Console.WriteLine($"person1.Name: {person1.Name}");
            //Console.WriteLine($"person2.Name: {person2.Name}");
            //Console.WriteLine($"ReferenceEquals: {ReferenceEquals(person1, person2)}");

            #endregion

            #region Part01 - Problem 5 - String Immutability

            //string text = "Hello";

            //Console.WriteLine($"Before: {text}");
            //Console.WriteLine($"HashCode before: {text.GetHashCode()}");

            //text = text + " Hi Willy";

            //Console.WriteLine($"After: {text}");
            //Console.WriteLine($"HashCode after: {text.GetHashCode()}");

            #endregion

            #region Part01 - Problem 6 - StringBuilder

            //StringBuilder builder = new StringBuilder("Hello");

            //Console.WriteLine($"Before: {builder}");
            //Console.WriteLine($"HashCode before: {builder.GetHashCode()}");

            //builder.Append(" Hi Willy");

            //Console.WriteLine($"After: {builder}");
            //Console.WriteLine($"HashCode after: {builder.GetHashCode()}");

            #endregion

            #region Part01 - Problem 7 - String Formatting

            //Console.Write("Enter first integer: ");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second integer: ");
            //int input3 = int.Parse(Console.ReadLine());

            //int sum = input1 + input3;

            //// Concatenation
            //Console.WriteLine("Using Concatenation:");
            //Console.WriteLine("Sum is " + sum);

            //// Composite formatting
            //Console.WriteLine("Using string.Format:");
            //Console.WriteLine(string.Format("Sum is {0}", sum));

            //// String interpolation
            //Console.WriteLine("Using String Interpolation:");
            //Console.WriteLine($"Sum is {sum}");

            #endregion

            #region Part01 - Problem 8 - StringBuilder Operations

            //StringBuilder sb = new StringBuilder("Hello World");

            //// Append
            //sb.Append("!");
            //Console.WriteLine($"After Append: {sb}");

            //// Replace
            //sb.Replace("World", "Willy");
            //Console.WriteLine($"After Replace: {sb}");

            //// Insert
            //sb.Insert(6, "Dear ");
            //Console.WriteLine($"After Insert: {sb}");

            //// Remove
            //sb.Remove(0, 6);
            //Console.WriteLine($"After Remove: {sb}");

            #endregion


            //    An enum (enumeration) is a value type that defines a set of named constants.
            //    Enums are useful when a variable should have one value from a predefined set of options.
            //## 3. String vs StringBuilder

            //Use string when text does not need frequent modifications.

            //Use StringBuilder when text is modified frequently, especially for large amounts of text.

            //String:
            //- Immutable
            //- Simple to use
            //- Good for normal text and a small number of modifications

            //StringBuilder:
            //- Mutable
            //- Supports Append, Replace, Insert, and Remove
            //- Better for frequent or large-scale modifications


        }

        #region Person Class

        //class Person
        //{
        //    public string Name { get; set; }
        //}

        #endregion
    }
}