namespace C_AssignmentDay09
{
    #region Problem 1
    //enum Weekdays
    //{
    //    Monday = 1,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday
    //} 
    #endregion

    #region problem 2&9
    //enum Grades //: short
    //{
    //    F = 1,
    //    D,
    //    C,
    //    B,
    //    A
    //}
    #endregion

    #region problem 7
    enum GenderDefault   // intt
    {
        Male,
        Female
    }
    enum GenderByte : byte   // explicitly use byte
    {
        Male,
        Female
    } 
    #endregion
    class Program
    {
        static void Main()
        {
            #region problem 1
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"Day: {day}, Value: {(int)day}");
            //} 
            #endregion

            #region ques 1
            //ques1:Why is it recommended to explicitly assign values to enum members in some cases?
            //ans1 : for DB mapping and versioning safety 
            #endregion

            #region problem 2
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"Grade: {grade}, Value: {(short)grade}");
            //} 
            #endregion

            #region ques 2
            //ques2:What happens if you assign a value that exceeds the underlying type's range?
            //ans 2:compile time error  
            #endregion

            #region problem 3
            //Person p1 = new Person
            //{
            //    Name = "Mahmoud",
            //    Age = 24,
            //    Department = "IT"
            //};
            //Person p2 = new Person
            //{
            //    Name = "Habiba",
            //    Age = 26,
            //    Department = "HR"
            //};
            //p1.PrintDetails();
            //p2.PrintDetails(); 
            #endregion

            #region question 3
            //ques3:What is the purpose of the virtual keyword when used with properties?
            //ans3 : allow derived classes to override it(polymorphism) 
            #endregion

            //prob 4

            #region question 4
            //ques4: Why can’t you override a sealed property or method?
            //ans4 : Because sealed explicitly prevents further overriding in the inheritance chain. 
            #endregion

            #region problem 5
            //// callin without creating object
            //double perimeter = Utility.CalculatePerimeter(5, 3);
            //Console.WriteLine($"Perimeter: {perimeter}"); 
            #endregion

            #region question 5
            //ques5:What is the key difference between static and object members?
            //ans5 :Static: belong to the class itslf, shared with all objects, created one time in memory
            //      Object: belong to specific object, each obj has its own copy, must created usin new keywoerd 
            #endregion

            #region problem 6
            //ComplexNumber c1 = new ComplexNumber(2, 3); 
            //ComplexNumber c2 = new ComplexNumber(4, 5);   

            //ComplexNumber result = c1 * c2;
            //Console.WriteLine($"Result: {result}"); 
            #endregion

            #region question 6
            //ques6:Can you overload all operators in C#?
            //ans6 : No, becayse: Language Safety (Some operators control core runtime behavior) 
            #endregion

            #region problem 7
            //Console.WriteLine($"Size of GenderDefault (int): {sizeof(GenderDefault)} bytes");
            //Console.WriteLine($"Size of GenderByte (byte): {sizeof(GenderByte)} bytes"); 
            #endregion

            #region question 7
            //ques7:When should you consider changing the underlying type of an enum?
            //ans7 : memory optimization, Value Range is Small

            #endregion

            #region problem 8
            //double c = 25;
            //double f = Utility2.CelsiusToFahrenheit(c);
            //Console.WriteLine($"{c}°C = {f}°F");

            //double f2 = 77;
            //double c2 = Utility2.FahrenheitToCelsius(f2);
            //Console.WriteLine($"{f2}°F = {c2}°C"); 
            #endregion

            #region question 8
            //ques8:Why can't a static class have instance constructors?
            //ans8 : Static classes cannot be instantiated and because of Compiler Restriction 
            #endregion

            #region problem 9
            //Console.Write("Enter grade (A, B, C, D, F): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Grades result))
            //{
            //    Console.WriteLine($"Valid Grade: {result}");
            //    Console.WriteLine($"Numeric Value: {(int)result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade entered.");
            //} 
            #endregion

            #region question 9
            //ques9:What are the advantages of using Enum.TryParse over direct parsing with int.Parse?
            //ans9 :No Exceptions (Safer), validation is easier, Direct Enum Conversion 
            #endregion

            #region problem 10
            //Employee[] employees =
            //{
            //new Employee(1, "Mahmoud"),
            //new Employee(2, "Sara"),
            //new Employee(3, "Ali")
            //};
            //Employee searchEmployee = new Employee(2, "DifferentName");

            //int index = Helper2<Employee>.SearchArray(employees, searchEmployee);
            //if (index != -1)
            //    Console.WriteLine($"Employee found at index {index}");
            //else
            //    Console.WriteLine("Employee not found"); 
            #endregion

            #region question 10
            //ques10:What is the difference between overriding Equals and == for object comparison in C# struct and class ?
            //ans10 : for classes: "==" : compare refrences and "Equals()": compare refrences
            //        after override: Equals() compare values
            //        for Structs: "==" not avaliable by default 
            //                   :"Equals()" comare value by vlaue  
            #endregion

            #region question 11
            //ques11: Why is overriding ToString beneficial when working with custom classes?
            //ans11 : makes the obj readable and easier to debug 
            #endregion

            #region Problem 11
            ////integers
            //int maxInt = Helper.Max(10, 20);
            //Console.WriteLine($"Max int: {maxInt}");

            ////doubles
            //double maxDouble = Helper.Max(5.5, 2.3);
            //Console.WriteLine($"Max double: {maxDouble}");

            ////Strings
            //string maxString = Helper.Max("Ahmed", "Mahmoud");
            //Console.WriteLine($"Max string: {maxString}"); 
            #endregion

            #region question 12
            //ques12: Can generics be constrained to specific types in C#?
            //ans12 : yes, Constraint to Interface(where T : IComparable<T>) 
            #endregion




        }
    }
}
