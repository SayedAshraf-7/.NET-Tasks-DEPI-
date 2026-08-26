

using System;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static void Main()
    {

        #region AddCommentsforTheCode
        //int x = 10; // Declare a Variable X of type intger and intialize it with 10
        //int y = 20;// Declare Variable y of type int and intialize it with 20
        //int sum = x + y; // Declare the Variable sum of type int and its value x + y = 30
        //Console.WriteLine(sum); // Print the sum in the Screen
        #endregion

        #region Shortcut To comment and uncomment in VS
        // CTRL + /
        #endregion

        #region Identify and fix the errors in this code snippet
        //int x = "10"; // x is an intger value and has a string value
        //console.WriteLine(x + y); // console object is ambigious in C# the c letter must be Capital
        //// y varible it not intialized so it ambigoius too.
        #endregion

        #region Explain the difference between a runtime error and a logical error with examples. 
        //Logical Error: it's an error inside the logic of the code but the code will be compiled 
        //and run normally and no problems in the runtime
        //Runtime Error: it's an error happens in the time after compilation 
        // but the code will be compiled normally and then the error happens.

        //Logical Example
        //int x = 10, y = 12;
        //// compare with the wrong comparasion operator or Print the wrong message
        //// not include the case of x = y;
        //if(x > y)
        //{
        //    Console.WriteLine("y is greater");
        //}
        //else
        //{
        //    Console.WriteLine("x is greater");
        //}

        /*
         Runtime Example
         Access the Wrong place in the Array
        
        int[] arr = { 1, 2, 4, 5 };
        Console.WriteLine(arr[6]);
         */
        #endregion

        #region Declare Varibales with right name conventions in C#
        // string FullName = "Sayed Ashraf";
        // int Age = 21;
        //decimal MonthlySalary = 220000;
        // bool IsStudent = true;
        #endregion

        #region  Why is it important to follow naming conventions such as PascalCase in C#?
        // Becuase it makes the code easy to read and maintain 
        // for example using '_' with properties make it easy to understand this is a private filed
        // using 'I' before the interface's name
        #endregion

        #region Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object.
        /*RefType x = new RefType();
        x.value = 10;
        RefType y = x;
        Console.WriteLine($"x: {x.value} ");
        Console.WriteLine($"y: {y.value} ");
        y.value = 12;
        Console.WriteLine("After Changey y value");
        Console.WriteLine($"x: {x.value} ");
        Console.WriteLine($"y: {y.value} ");
        */
        #endregion

        #region  Explain the difference between value types and reference types in terms of memory allocation.
        // ValueType: the value is allocated directly inside the stack 
        // referenceType: the value is allocated inside the heap but the reference inside the stack 
        #endregion


        #region  Create a program that calculates the following using variables x = 15 and y = 4: 
        //int x = 15, y = 4;
        //Console.WriteLine($"Sum : {x + y}");
        //Console.WriteLine($"Differnece : {x - y}");
        //Console.WriteLine($"Product : {x * y}");
        //Console.WriteLine($"Division : {x / y}");
        //Console.WriteLine($"Remainder : {x % y}");
        #endregion

        #region  What will be the output of the following code? Explain why: 
        //int a = 2, b = 7;
        //Console.WriteLine(a % b); // 2 
        // the remainder of divide 2 / 7 is 2 as the remainder as 2 < 7
        #endregion

        #region Write a program that checks if a given number is both: Greater than 10. Even. 
        /* int num = 12;
        if (num > 10 && num % 2 == 0)
        {
            Console.WriteLine("YES");
        }
        else
            Console.WriteLine("NO");
        */
        #endregion

        #region How does the && (logical AND) operator differ from the & (bitwise AND) operator? 

        // && >> is a logical operator and return boolean it is also short-circuiting
        // & >> is a bitwise operator and is used with integers and make anding operation bit by bit


        #endregion

        #region Implement a program that takes a double input from the user and casts it to an int Use both implicit and explicit casting, then print the results. 
        //double db = Convert.ToDouble(Console.ReadLine());
        //int x = db; // impilict
        //int y = (int)x; // explicit
        // Why is explicit casting required when converting a double to an int? 
        // Becuase casting can lose data 
        #endregion


        #region Write a program
        //Console.Write("Enter the Age: ");
        //int Age = int.Parse(Console.ReadLine());
        //if (Age > 0)
        //{
        //    Console.WriteLine("Valid");
        //}
        //else
        //    Console.WriteLine("Not Valid");
        #endregion


        #region What exception might occur if the input is invalid and how can you handle it
        // ThrowFormatException happens if the input is not a number
        #endregion


        #region Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.
        //int x = 10;
        //int y = x++;
        //int z = ++x;
        //Console.WriteLine(y); // 10
        //Console.WriteLine(z); // 12

        #endregion

        #region Given the code below, what is the value of x after execution? Explain why

        //int x = 5;
        //int y = ++x + x++; // 6 + 6
        //// x = 7 because it is incremented twice
        //// y = 12 = 6 + 6;
        //Console.WriteLine(y);
        #endregion

        #region  what's the difference between compiled and interpreted languages and in this way what about Csharp? 
        // Compiled Language: A compiler translates your source code into machine code before the program runs.
        // Interpreted Langauge : An interpreter generally reads the program and executes it through another program (the interpreter), rather than producing a traditional native executable first.
        // C# is generally compiled, but not directly to native machine code
        // C# use a hybird approach in its compilation process.

        #endregion

        #region Compare between implicit, explicit, Convert and parse casting 
        //Implicit conversion happens automatically when there is no significant risk of losing information.
        //Explicit casting means you tell C# to convert a value yourself using (type).
        // Convert is a class provided by .NET for converting between different types.
        //Parse is mainly used to convert a string containing a valid representation of a value into another type.
        // Both are throwing Excpetion if the input is not valid so the best 
        // practice to use int.TryParse();
        #endregion

        #region what meant by Csharp is managed code 

        /*C# is called managed code because C# programs normally execute
        under the .NET runtime, which manages memory and provides services such as
        garbage collection, type safety, and exception handling.*/

        #endregion

        #region what meant by struct is considered like class before
        //becuase struct has the same use-cases of the class is to create a prototypes
        // for new data types or new objects exist in the system
        // but the difference between them now that struct is value type
        // class is reference type

        #endregion

    }




    //public class RefType
    //{
    //    public int value;

    //}

}