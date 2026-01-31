using System;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace C_AssignmentDay03P01
{
    class Person
    {
        public string Name;
    }
    class Program
    {
        static void Main()
        {

            #region Problem1
            //Console.Write("Enter a number: ");
            //string num = Console.ReadLine();
            //int number1 = int.Parse(num);
            //Console.WriteLine("Using int.Parse: " + number1);

            //int number2 = Convert.ToInt32(num);
            //Console.WriteLine("Using Convert.ToInt32: " + number2);
            #endregion

            #region Question1
            //int.Parse gives an exception when the input is null,
            //while Convert.ToInt32 safely returns 0. 
            #endregion


            #region Problem2
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input,out int number))
            //{
            //    Console.WriteLine("Valid number entered: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            //} 
            #endregion

            #region Question2
            //TryParse: handles invalid inputs safely wthout crashing the program 
            // Parse: threows an exception if the input is invalid , requires try-catch which maximize the overhead 
            #endregion

            #region Problem3
            //object obj;
            //// Assign an int
            //obj = 10;
            //Console.WriteLine("Value: " +obj);
            //Console.WriteLine("Type: " + obj.GetType());
            //Console.WriteLine("HashCode: "+ obj.GetHashCode());
            //Console.WriteLine();

            //// Assign a string
            //obj = "Hello";
            //Console.WriteLine("Value: " +obj);
            //Console.WriteLine("Type: " + obj.GetType());
            //Console.WriteLine("HashCode: "+ obj.GetHashCode());
            //Console.WriteLine();

            //// Assign a double
            //obj = 10.5;
            //Console.WriteLine("Value: " +obj);
            //Console.WriteLine("Type: " + obj.GetType());
            //Console.WriteLine("HashCode: "+ obj.GetHashCode()); 
            #endregion

            #region Question 3
            //The real purpose of GetHashCode() is to generate a hash value that helps objects be stored and retrieved efficiently
            //in hash-based collections.
            //The collections use the hash code to: Decide where to store an object in memory.
            //Quickly find the object later without checking every element. 
            #endregion

            #region Problem4
            //Person p1 = new Person();
            //p1.Name = "Mahmoud";
            //Person p2 = p1;
            //p1.Name = "Ahmed";
            //Console.WriteLine("Value from p2: " + p2.Name);
            #endregion

            #region Question4
            //Reference equality means that two variables point to the exact same object in memory,
            //not just objects with the same values.
            //In .NET, reference equality is checked using:
            //Object.ReferenceEquals(obj1, obj2)
            //(==) (for reference types that don’t overload it) 
            #endregion


            #region Problem5
            //string message = "Hello";
            //Console.WriteLine("Before modification:");
            //Console.WriteLine("Message: " + message);
            //Console.WriteLine("HashCode: " + message.GetHashCode());
            //Console.WriteLine();

            //message = message + " Hi Willy";
            //Console.WriteLine("After modification:");
            //Console.WriteLine("Message: " + message);
            //Console.WriteLine("HashCode: " + message.GetHashCode()); 
            #endregion


            #region Question5
            //Why are strings immutable in C#?
            /*
            1)Security
            -Strings are often used for sensitive data like file paths, passwords, connection strings.
            -Immutability prevents other parts of the program from changing the content without your knowledge
            2)Hashing and Dictionary Keys
            -Strings are frequently used as keys in hash tables, dictionaries, and sets.
            -Immutability ensures the hash code doesn’t change after the string is created.
            3)Performance Optimizations
            -.NET uses string interning, which stores only one copy of identical string literals in memory.
            */
            #endregion


            #region Problem6
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine("Before modification:");
            //Console.WriteLine("Text: " + sb);
            //Console.WriteLine("HashCode: " + sb.GetHashCode());
            //Console.WriteLine();

            //sb.Append(" How are you?");

            //Console.WriteLine("After modification:");
            //Console.WriteLine("Text: " + sb);
            //Console.WriteLine("HashCode: " + sb.GetHashCode()); 
            #endregion

            #region Question6
            //ques6: How does StringBuilder address the inefficiencies of string concatenation?
            //StringBuilder is mutable, meaning its content can change without creating new objects.
            //Modifying the string reuses the same memory buffer, making operations much faster and memory - efficient.
            // Avoids repeated object creation during concatenation
            // Ideal for loops or large text operations 
            #endregion


            #region Question 7
            // Question: Why is StringBuilder faster for large-scale string modifications?
            /*
            -Strings are immutable in C#:
            so, Large-scale modifications create many temporary objects,
            which slows performance and increases memory usage
            -StringBuilder is mutable:
            The content of a StringBuilder object can change without creating new objects.
            so, Appending, inserting, or removing text modifies the same buffer in memory.
             */
            #endregion


            #region Problem7
            //Console.Write("Enter the first number: ");
            //int input1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int input2 = int.Parse(Console.ReadLine());

            //int sum = input1 + input2;

            //Console.WriteLine();

            ////concatenation (+ operator)
            //Console.WriteLine("Using concatenation: " + "Sum is " + input1 + " + " + input2 + " = " + sum);

            ////composite formatting (string.Format)
            //Console.WriteLine("Using composite formatting: " + string.Format("Sum is {0} + {1} = {2}", input1, input2, sum));

            ////string interpolation ($)
            //Console.WriteLine($"Using string interpolation: Sum is {input1} + {input2} = {sum}"); 
            #endregion


            #region Question8
            // Question: Which string formatting method is most used and why? 
            //String interpolation ($) is the most used in modern C#
            //Readability: Looks like normal text with embedded variables.
            //Conciseness: Less typing than string.Format.
            //Flexibility: Can include expressions directly: 
            #endregion

            
            #region Problem8
            //StringBuilder sb = new StringBuilder("Hello");
            //Console.WriteLine("Original text: " + sb);

            ////Append text
            //sb.Append(" Willy");
            //Console.WriteLine("After Append: " + sb);

            ////Replace a substring
            //sb.Replace("Willy", "Ahmed");
            //Console.WriteLine("After Replace: " + sb);

            ////Insert a string at a specific position
            //sb.Insert(6, " How are you,");
            //Console.WriteLine("After Insert: " + sb);

            ////Remove a portion of text (from index 6, length 13)
            //sb.Remove(6, 13);
            //Console.WriteLine("After Remove: " + sb); 
            #endregion









        }
    }








    }

