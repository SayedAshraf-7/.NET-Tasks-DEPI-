

using System;

internal class Program
{
    public static void Main()
    {
        #region Problem 1


        //int[] arr = new int[5];
        //int[] arr2 = { 1, 2, 3, 4, 5 };
        //Array arr3 = Array.CreateInstance(typeof(int), 5);

        //for (int i = 0; i < arr.Length; i++)
        //    arr[i] = i;
        //for (int i = 0; i < arr.Length; i++)
        //    Console.Write($"{arr[i]} ");
        //Console.WriteLine();

        //for (int i = 0; i < arr2.Length; i++)
        //    arr2[i] = 1;
        //for (int i = 0; i < arr2.Length; i++)
        //    Console.Write($"{arr2[i]} ");
        //Console.WriteLine();

        //for (int i = 0; i < arr3.Length; i++)
        //    arr3.SetValue(i * 2,i);
        //for (int i = 0; i < arr3.Length; i++)
        //    Console.Write($"{arr3.GetValue(i)} ");
        //Console.WriteLine();


        //try
        //{
        //    Console.WriteLine(arr[12]);
        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine($"Error : {ex.Message}");
        //}

        // Question Default value for the Array in C#
        // the array has the same default value of the type it has 
        // string -> null , int -> 0 , bool -> false;
        #endregion


        #region Problem 2
        //string[] arr = { "1", "2", "3" };
        //string[] arr2 = arr;
        //arr2[0] = "2";
        ////Console.WriteLine(arr[0]); // 2 beacause of shallow copy Problem
        ////####################################

        //arr2 = (string[])arr.Clone();
        //arr2[0] = "7";
        //Console.WriteLine(arr2[0]);
        //Console.WriteLine(arr[0]);
        // What is the Difference between Copy and Clone ? 
        // Clone: create new Array(Object)
        // Copy : copy the values to exist array
        #endregion

        #region Problem 3

        //int[,] Grades = new int[3, 3];

        //for (int row = 0; row < Grades.GetLength(0); row++)
        //{
        //    for (int col = 0; col < Grades.GetLength(1); col++)
        //    {
        //        do
        //        {
        //            Console.Write("Enter a grade : ");
        //            object res = Console.ReadLine();
        //            int num = 0;
        //            bool f = int.TryParse(res.ToString(), out num) && (num >= 0 && num <= 100);
        //            if (f)
        //            {
        //                Grades[row, col] = num;
        //                break;
        //            }
        //            Console.WriteLine("Enter Valid grade!");
        //        } while (true);
        //    }
        //}

        //for (int row = 0; row < Grades.GetLength(0); row++)
        //{

        //    for (int col = 0; col < Grades.GetLength(1); col++)
        //    {
        //        Console.WriteLine(Grades[row, col]);
        //    }
        //}
        //// Difference between GetLength and Length in C#
        //// GetLenght -> the Length of the dimension you want
        //// Length -> the Total number of cells inside the multi-dimensions array

        #endregion

        #region Problem 4

        //int[] arr = { 4, 2, 3, 4 };


        //Array.Sort(arr);
        //for (int i = 0; i < arr.Length; i++)
        //    Console.WriteLine(arr[i]);
        // The Array is Sorted


        //Array.Reverse(arr);
        //for (int i = 0; i < arr.Length; i++)
        //    Console.WriteLine(arr[i]);
        // The Array is Reversed


        //Console.WriteLine(Array.IndexOf(arr, 12));
        // Find the First Occurence for a value and return the number or -1 if it doesn't exist


        //Array.Clear(arr);
        //for (int i = 0; i < arr.Length; i++)
        //    Console.WriteLine(arr[i]);
        // Clear the content of the array and return to the default value


        //int[] arr2 = { 1,2,1,1};
        //Array.Copy(arr,arr2,2);
        //for (int i = 0; i < arr.Length; i++)
        //    Console.WriteLine(arr2[i]);
        // copy the elements of arr to arr2

        // What is the difference between Array.Copy() and Array.ConstrainedCopy()?    
        //Array.ConstrainedCopy ->Guarantees destination isn't partially modified
        // it works with all or nothing but Copy can partially modify the array and then stop if 
        // expcetion has occured

        #endregion

        #region Problem 5

        /* int[] arr = { 1, 2, 3, 4 };

        for (int i = 0; i < arr.Length; i++)
            Console.Write($"{arr[i]} ");
        Console.WriteLine();
        foreach (var item in arr)
            Console.Write($"{item} ");
        Console.WriteLine();

        int idx = arr.Length - 1;
        while(idx >= 0)
        {
            Console.Write($"{arr[idx]} ");
            --idx;
        }
        Console.WriteLine();

        //  Question: Why is foreach preferred for read-only operations on arrays? 
            
            Becuase it visits each element only without caring about index 
            and easier to maintain

        */

        #endregion

        #region Problem 6

        //do
        //{

        //    Console.Write("Enter Positive Odd number : ");
        //    int num;
        //    if (int.TryParse(Console.ReadLine() , out num) && num % 2 != 0 && num > 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("Right");
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Enter Valid Number !");
        //        Console.ForegroundColor = ConsoleColor.Gray;

        //    }
        //}
        //while (true);
        #endregion

        #region Problem 7

        //int[,] Grades =
        //{
        //    { 90, 85, 70 },
        //    { 75, 80, 95 },
        //    { 60, 88, 92 }
        //};

        //for (int row = 0; row < Grades.GetLength(0); row++)
        //{
        //    for (int col = 0; col < Grades.GetLength(1); col++)
        //    {
        //        Console.Write(Grades[row, col] + "\t");
        //    }

        //    Console.WriteLine();
        //}
        #endregion

        #region Problem 8
        //Console.Write("Enter month number (1-12): ");
        //int month = int.Parse(Console.ReadLine());

        //if (month == 1)
        //{
        //    Console.WriteLine("January");
        //}
        //else if (month == 2)
        //{
        //    Console.WriteLine("February");
        //}
        //else if (month == 3)
        //{
        //    Console.WriteLine("March");
        //}
        //else if (month == 4)
        //{
        //    Console.WriteLine("April");
        //}
        //else if (month == 5)
        //{
        //    Console.WriteLine("May");
        //}
        //else if (month == 6)
        //{
        //    Console.WriteLine("June");
        //}
        //else if (month == 7)
        //{
        //    Console.WriteLine("July");
        //}
        //else if (month == 8)
        //{
        //    Console.WriteLine("August");
        //}
        //else if (month == 9)
        //{
        //    Console.WriteLine("September");
        //}
        //else if (month == 10)
        //{
        //    Console.WriteLine("October");
        //}
        //else if (month == 11)
        //{
        //    Console.WriteLine("November");
        //}
        //else if (month == 12)
        //{
        //    Console.WriteLine("December");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid month number");
        //}

        //Console.Write("Enter month number (1-12): ");
        //int month = int.Parse(Console.ReadLine());

        //switch (month)
        //{
        //    case 1:
        //        Console.WriteLine("January");
        //        break;

        //    case 2:
        //        Console.WriteLine("February");
        //        break;

        //    case 3:
        //        Console.WriteLine("March");
        //        break;

        //    case 4:
        //        Console.WriteLine("April");
        //        break;

        //    case 5:
        //        Console.WriteLine("May");
        //        break;

        //    case 6:
        //        Console.WriteLine("June");
        //        break;

        //    case 7:
        //        Console.WriteLine("July");
        //        break;

        //    case 8:
        //        Console.WriteLine("August");
        //        break;

        //    case 9:
        //        Console.WriteLine("September");
        //        break;

        //    case 10:
        //        Console.WriteLine("October");
        //        break;

        //    case 11:
        //        Console.WriteLine("November");
        //        break;

        //    case 12:
        //        Console.WriteLine("December");
        //        break;

        //    default:
        //        Console.WriteLine("Invalid month number");
        //        break;
        //}

        //Question: When should you prefer a switch statement over if-else?
        // switch is better for more than 4 conditions and posiible values
        #endregion

        #region Problem 9
        //int[] numbers = { 78, 45, 89, 90, 11, 14, 5,78 };
        //Array.Sort(numbers);
        //for (int i = 0; i < numbers.Length; i++)
        //    Console.WriteLine(numbers[i]);
        //Console.WriteLine($"FirstIndex : {Array.IndexOf(numbers , 78)}");
        //Console.WriteLine($"LastIndex : {Array.LastIndexOf(numbers , 78)}");
        #endregion

        #region Problem 10

        //int[] numbers = { 10, 20, 30, 40, 50 };

        //int sum = 0;

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}

        //Console.WriteLine("Sum using for: " + sum);
        //sum = 0;
        //foreach (var item in numbers)
        //{

        //    sum += item;
        //}
        //Console.WriteLine("Sum using for: " + sum);
        // for each is better as we don't need the index or any modification inside the array
        // we just need readonly and forward loop

        #endregion

        // Part 2 Problems

        #region Problem 11
        //Console.Write("Enter Number (1-7) : ");
        //string num = Console.ReadLine();
        //Console.WriteLine(Enum.Parse(typeof(DayOfWeek), num) );

        // If the Number the User Entered > 7 then the number will be Printed without conversion to 
        // DayWeek type
        #endregion



    }
    public enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

}