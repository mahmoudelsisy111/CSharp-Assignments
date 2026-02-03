using System;
using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_AssignmentDay04P01
{
    #region Part02Prob02
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    } 
    #endregion
    class Program
    {
        static void Main()
        {
            #region Part02Prob02
            //Console.Write("Enter a number (1-7) to get the day of the week: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int dayNumber))
            //{
            //    try
            //    {
            //        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());
            //        Console.WriteLine($"The day is: {day}");
            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("Error: Invalid number! Please enter a number from 1 to 7.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Please enter a valid integer.");
            //} 
            #endregion

            #region Problem1
            //int[] arr1 = new int[3];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = i + 1;
            //}
            //Console.WriteLine("arr1 elements:");
            //foreach (int num in arr1)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("--------------------");
            ////======================================

            //int[] arr2 = new int[] { 4, 5, 6 };
            //Console.WriteLine("arr2 elements:");
            //foreach (int num in arr2)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("--------------------");
            ////======================================

            //int[] arr3 = { 7, 8, 9 };
            //Console.WriteLine("arr3 elements:");
            //foreach (int num in arr3)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("--------------------");
            ////======================================

            //// Demonstrate IndexOutOfRangeException
            //try
            //{
            //    Console.WriteLine(arr3[10]); // Invalid index
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Exception caught: " + ex.Message);
            //}
            #endregion

            #region Question1
            // based on the array datatype
            // int, double, float (numeric) : 0
            // bool : false
            // char, string, object : null 
            #endregion

            #region Problem2
            //int[] arr1 = { 2, 4, 6, 8 };
            //int[] arr2 = { 1, 3, 5, 7 };
            //arr2 = arr1;
            //// so arr1 has 2 refrences and arr2 became unreachable

            ////before modification
            //Console.WriteLine(arr1[1]); //4
            //Console.WriteLine(arr2[1]); //4

            //Console.WriteLine("=============================");

            ////modify arr2
            //arr2[1] = 100;

            ////after modification on arr2
            //Console.WriteLine(arr1[1]); //100
            //Console.WriteLine(arr2[1]); //100

            //Console.WriteLine("=============================");

            ////Deep copy using clone()
            //int[] arr3 = (int[])arr1.Clone();

            //// Modify arr3
            //arr3[1] = 555;

            ////after modification on arr3
            //Console.WriteLine(arr1[1]); //100
            //Console.WriteLine(arr3[1]); //555 
            #endregion

            #region Question 2
            //Array.Clone() VS Array.Copy()
            // Clone() : returns new array , make a typical copy of an existing array , can't control num of elements to be copied
            // Copy()  : copy elements from array to another array , needs another array to be existed , can control num of elements to be copied 
            #endregion

            #region Problem3
            //int[,] grades = new int[3, 3];

            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");

            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\n--- Students Grades ---");

            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"\nStudent {i + 1} Grades:");

            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //}
            #endregion

            #region Question 3
            //GetLength(0:rows,1:columns) : gives the size of a specific dimension.
            // Length() : gives the total number of elements in the array. 
            #endregion

            #region Problem4
            //    int[] arr = { 50, 20, 40, 10, 30 };

            //    Console.WriteLine("Original Array:");
            //    Print(arr);

            //    //Sort
            //    Array.Sort(arr);
            //    Console.WriteLine("\nAfter Sort:");
            //    Print(arr);

            //    //Reverse
            //    Array.Reverse(arr);
            //    Console.WriteLine("\nAfter Reverse:");
            //    Print(arr);

            //    //IndexOf
            //    int index = Array.IndexOf(arr, 40);
            //    Console.WriteLine($"\nIndex of 40: {index}");

            //    //Copy
            //    int[] copiedArr = new int[arr.Length];
            //    Array.Copy(arr, copiedArr, arr.Length);
            //    Console.WriteLine("\nCopied Array:");
            //    Print(copiedArr);

            //    //Clear
            //    Array.Clear(arr, 1, 2);
            //    Console.WriteLine("\nAfter Clear (from index 1, count 2):");
            //    Print(arr);
            //}
            static void Print(int[] a)
            {
                foreach (int num in a)
                    Console.Write(num + " ");
                Console.WriteLine();
            }
            #endregion

            #region Question4
            //Array.Copy() VS Array.ConstrainedCopy()
            //Copy(): faster, but less safety if there is an exception during the copy it might copy only part of the array
            //ConstrainedCopy(): slower, but more safety if there is an exception during the copy it is atoomic(copy all or nothing)  
            #endregion

            #region Problem5
            //int[] arr = { 10, 20, 30, 40, 50 };

            ////Using for
            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine("\n");

            ////Using foreach
            //Console.WriteLine("Using foreach loop:");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine("\n");

            ////Using while in reverse
            //Console.WriteLine("Using while loop in reverse:");
            //int index = arr.Length - 1;
            //while (index >= 0)
            //{
            //    Console.Write(arr[index] + " ");
            //    index--;
            //}
            #endregion

            #region Question5
            //foreach is preferred because it is safer(no IndexOutOfRangeException), cleaner, and prevents index - related errors. 
            #endregion


            #region Problem6
            //int number;
            //bool isValid;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string input = Console.ReadLine();

            //    isValid = int.TryParse(input, out number) && number > 0 && number % 2 != 0;

            //    if (!isValid)
            //    {
            //        Console.WriteLine("Invalid input! Please enter a POSITIVE ODD number.\n");
            //    }

            //} while (!isValid);

            //Console.WriteLine($"\nThank you! You entered: {number}"); 
            #endregion

            #region Question6
            // Input validation prevents runtime errors, ensures correct data, and makes the program more defensive against invalid user input. 
            #endregion

            #region Problem7
            //int[,] matrix =
            //{ { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };

            //for (int i = 0; i < matrix.GetLength(0);i++)
            //{
            //    for (int j= 0;j <matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Question7
            // we can use nested loops, use Tab(\t), and use Console.WriteLine() after each row 
            #endregion

            #region Problem 8
            //Console.WriteLine("Enter a month number (1-12):");
            //int month = int.Parse(Console.ReadLine());

            //if (month == 1)
            //    Console.WriteLine("january");
            //else if (month == 2)
            //    Console.WriteLine("February");
            //else if (month == 3)
            //    Console.WriteLine("March");
            //else if (month == 4)
            //    Console.WriteLine("April");
            //else if (month == 5)
            //    Console.WriteLine("May");
            //else if (month == 6)
            //    Console.WriteLine("June");
            //else if (month == 7)
            //    Console.WriteLine("July");
            //else if (month == 8)
            //    Console.WriteLine("August");
            //else if (month == 9)
            //    Console.WriteLine("September");
            //else if (month == 10)
            //    Console.WriteLine("October");
            //else if (month == 11)
            //    Console.WriteLine("November");
            //else if (month == 12)
            //    Console.WriteLine("December");
            //else Console.WriteLine("Invalid month number");

            //Console.WriteLine("========================");

            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Invalid month number"); break;
            //} 
            #endregion

            #region Question8
            // Use switch when checking many fixed values for the same variable to make the code cleaner and more readable
            #endregion

            #region Prob 9
            //int[] arr = { 50, 20, 40, 10, 30, 20 };
            //Console.WriteLine("Original Array:");
            //Print(arr);

            ////Sort
            //Array.Sort(arr);
            //Console.WriteLine("\nAfter Array.Sort():");
            //Print(arr);

            ////Search value
            //int value = 20;
            //int firstIndex = Array.IndexOf(arr, value);
            //int lastIndex = Array.LastIndexOf(arr, value);

            //Console.WriteLine($"\nFirst index of {value}: {firstIndex}");
            //Console.WriteLine($"Last index of {value}: {lastIndex}"); 
            #endregion

            #region Question 9
            //Array.Sort() is O(n log n) 
            #endregion


            #region Problem10
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine("Sum using for loop: " + sumFor);

            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine("Sum using foreach loop: " + sumForeach); 
            #endregion

            #region Question10
            //For arrays, a for loop can be a bit more efficient than foreach because it accesses elements directly by index
            //without the overhead of an enumerator. 
            #endregion

        }


    }
}

