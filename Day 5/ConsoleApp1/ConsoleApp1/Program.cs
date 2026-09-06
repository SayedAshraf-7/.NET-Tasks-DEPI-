using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Problem 1
            //int n1, n2;
            //bool flag1 = int.TryParse(Console.ReadLine(), out n1);
            //bool flag2 = int.TryParse(Console.ReadLine(), out n2);
            //try
            //{
            //    if (flag1 && flag2)
            //    {
            //        int res = n1 / n2;
            //    }
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}
            // What is the purpose of the finally block? 
            // finally block is a block of code will be excuted in any case happens inside try block
            // (throw expcetion).

            #endregion

            #region Problem 2


            //static public void TestDefinsiveCode()
            // {

            //     //int X, Y, Z;
            //     //bool flag;
            //     //do
            //     //{
            //     //    Console.WriteLine("Enter first Number : ");
            //     //}
            //     //while (!int.TryParse(Console.ReadLine(), out X) || X > 0);
            //     //do
            //     //{
            //     //    Console.WriteLine("Enter Second Number : ");
            //     //}
            //     //while (!int.TryParse(Console.ReadLine(), out Y) || Y >= 1);

            //     //Z = X / Y;

            //     //int[] arr = { 1, 2, 3 };
            //     //if (arr?.Length > 69)
            //     //    arr[69] = 90;

            //     // How does int.TryParse() improve program robustness compared to int.Parse() ?
            //     // if TryParse failed to parse the string to int it don't throw exception and return a boolean
            //     // value to check if the value correctly parsed or not
            //}



            #endregion

            #region Problem 3
            //int? num = null;
            //num = num ?? 12;

            //Console.WriteLine($"HasValue {num.HasValue}");
            //Console.WriteLine($"Value {num.Value}");
            // HasValue : returns a boolean value to check if the variable is null or not
            // Value : returns the value inside the nullable variable and throw exception if the variable is null
            //What exception occurs when trying to access Value on a null Nullable<T>? 
            // InvalidOperationException
            #endregion

            #region Problem 4
            //int[] arr = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    Console.WriteLine(arr[7]);            
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error {ex.Message}");
            //}
            // Question: Why is it necessary to check array bounds before accessing elements? 
            // check if the index will be accessed less than or equal the size of the array.

            #endregion

            #region Problem 5
            //int[,] arr = new int[3,3];
            //int[] RowSums = new int[3];
            //int[] ColumnsSums = new int[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0;j < 3; j++)
            //    {
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //        RowSums[i] += arr[i,j];
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        ColumnsSums[i] += arr[j, i];
            //    }
            //}

            //for (int i = 0; i < RowSums.Length; i++)
            //{
            //    Console.WriteLine($"Row{1+i} : {RowSums[i]}");
            //}

            //for (int i = 0; i < ColumnsSums.Length; i++)
            //{
            //    Console.WriteLine($"Column{i+1} : {ColumnsSums[i]}");
            //}
            //  How is the GetLength(dimension) method used in multi-dimensional arrays? 
            // returns the number of the elements inside a deminsion.

            #endregion

            #region Problem 6

            //int[][] arr = new int[3][];
            //arr[0] = new int[1];
            //arr[1] = new int[2];
            //arr[2] = new int[3];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length;j++)
            //    {
            //        arr[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            // How does the memory allocation differ between jagged arrays and rectangular arrays ?
            // jagged array provides more flexibility because each row can be independently sized, while a rectangular
            // array has a fixed number of rows and columns.
            #endregion

            #region Problem 7
            //string? x = null;
            //int val = Convert.ToInt32(Console.ReadLine());
            //if(val == 1)
            //{
            //    x = "Sayed";
            //}
            //Console.WriteLine(x!.Length);
            // What is the purpose of nullable reference types in C#? 
            // it helps you avoid some null errors and expcetions.
            #endregion

            #region Problem 8
            //int x = 12;
            //object o = x;
            //int num;
            //if(int.TryParse(o.ToString() , out num)){
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.Write("Error in unboxing");
            //}
            // What is the performance impact of boxing and unboxing in C#?
            // it has performance overload because of all the operations happens indide it
            // like allocating from the heap and can cause an exception if the unboxing didn't happen correctly


            #endregion

            #region Problem 9
            //static void SumAndMultiply(int a, int b, out int sm, out int mul)
            //{
            //    sm = a + b;
            //    mul = a * b;
            //}
            //int n1 = 2, n2 = 5;
            //int sm, mul;
            //SumAndMultiply(n1, n2,out sm , out mul);
            // Why must out parameters be initialized inside the method? 
            // becuase they are not required to be intialized outside the method.
            #endregion

            #region Problem 10
            //public static void PrintString(string str , int t = 5)
            //{
            //    for (int i = 0; i < t; i++)
            //    {

            //        Console.WriteLine(str);
            //    }
            //}
            //PrintString(str : "Sayed");
            // The use of named parameters to avoid errors happens because of order and wrong mapping
            // of paramters and its values
            // Why must optional parameters always appear at the end of a method's parameter list ?
            // so the compiler can correctly match between the parameters and the values
            #endregion

            #region Problem 11
            //int[]? arr = null;
            //Console.WriteLine(arr?.Length);
            //  How does the null propagation operator prevent NullReferenceException? 
            //by checking whether the object is null before accessing its member.
            #endregion

            #region Problem 12
            //int number;
            //string res = "undefind";
            //if(int.TryParse(Console.ReadLine(), out number))
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            res = "Monday";
            //            break;
            //        case 2:
            //            res = "Tuesday";
            //            break;
            //        case 3:
            //            res = "Wednesday";
            //            break;
            //        case 4:
            //            res = "Thursday";
            //            break;
            //        case 5:
            //            res = "Friday";
            //            break;
            //        case 6:
            //            res = "Saturday";
            //            break;
            //        case 7:
            //            res = "Sunday";
            //            break;
            //    }
            //}
            // When is a switch expression preferred over a traditional if statement ?
            //  if the number of conditions is more than 4
            #endregion

            #region Problem 13
            //public static int SumArray(params int[]numbers)
            //{
            //    int res = 0;
            //    foreach(var item in numbers)
            //    {
            //        res += item;
            //    }
            //    return res;
            //}
            //Console.WriteLine(SumArray(1, 2, 4));
            //int[] numbers = { 1, 2, 4 };
            //Console.WriteLine(SumArray(numbers));
            // Question: What are the limitations of the params keyword in method definitions? 
            // All arguments must be compatible with the element type cannot use paramters of different types

            #endregion


            #region Problem 14
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{

            //    Console.Write($"{i} ");
            //}

            #endregion


            #region Problem 15
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{

            //    Console.Write($"{num * i} ");
            //}
            #endregion


            #region Problem 16
            //int num = Convert.ToInt32(Console.ReadLine());
            //int power = Convert.ToInt32(Console.ReadLine());
            //long res = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    res *= num;
            //}
            //Console.WriteLine(res);
            #endregion

            #region Prblem 17
            //string s = Console.ReadLine() ?? "";
            //ReverseString(ref s);
            //Console.WriteLine(s);
            //public static void ReverseString(ref string s)
            //{
            //    char[] chars = s.ToCharArray();
            //    for (int i = 0; i < chars.Length / 2; i++)
            //    {
            //        char t = chars[i];
            //        chars[i] = chars[chars.Length - i - 1];
            //        chars[chars.Length - i - 1] = t;
            //    }
            //    s = new string(chars);
            //}
            #endregion


            #region Problem 18
            //int n = 10002;
            //int res = 0;
            //while (n > 0)
            //{
            //    int dig = n % 10;
            //    res *= 10;
            //    res += dig;
            //    n /= 10;
            //}
            //Console.WriteLine(res);
            #endregion

            #region Problem 19
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //Dictionary<int, int> loc = new Dictionary<int, int>();
            //int ans = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    loc[arr[i]] = -1;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (loc[arr[i]] == -1)
            //    {
            //        loc[arr[i]] = i;
            //    }
            //    else
            //    {
            //        ans = Math.Max(ans , i - loc[arr[i]]-1);
            //    }
            //}

            //Console.WriteLine(ans);
            #endregion


            #region Problem 20
            string s = Console.ReadLine();
            string[] parts = s.Split(' ');
            StringBuilder res = new StringBuilder();
            for (int i = parts.Length - 1; i >= 0; --i)
            {
                res.Append(parts[i]);
                res.Append(' ');
            }
            Console.WriteLine(res);

            #endregion
        }



    }


}
