using System;
using System.ComponentModel;
using System.Text;

namespace Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****************************************  Assignment_4_c# ********************************************//
            #region  Question 1
            ////1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter an integer: ");
            //string input = Console.ReadLine();

            //// Try to parse the input to an integer
            //if (int.TryParse(input, out int number))
            //{
            //    if (number >= 1)
            //    {
            //        Console.WriteLine("Numbers between 1 and {0}:", number);
            //        for (int i = 1; i <= number; i++)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a number greater than or equal to 1.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion


            #region Question 2
            ////2- Write a program that allows the user to insert an integer then 
            ////             print a multiplication table up to 12.

            //Console.Write("Enter an integer: ");
            //string input = Console.ReadLine();

            //// Try to parse the input to an integer
            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine($"Multiplication table for {number}:");
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{number} x {i} = {number * i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Question 3
            ////3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter an integer: ");
            //string input = Console.ReadLine();

            //// Try to parse the input to an integer
            //if (int.TryParse(input, out int number))
            //{
            //    if (number >= 1)
            //    {
            //        Console.WriteLine($"Even numbers between 1 and {number}:");
            //        for (int i = 1; i <= number; i++)
            //        {
            //            if (i % 2 == 0) // Check if the number is even
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a number greater than or equal to 1.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion

            #region Question 4
            ////4- Write a program that takes two integers then prints the power.

            //Console.Write("Enter the base (integer): ");
            //string baseInput = Console.ReadLine();

            //Console.Write("Enter the exponent (integer): ");
            //string exponentInput = Console.ReadLine();

            //// Parse the inputs to integers
            //if (int.TryParse(baseInput, out int baseNumber) && int.TryParse(exponentInput, out int exponent))
            //{
            //    // Calculate the power using Math.Pow
            //    double result = Math.Pow(baseNumber, exponent);

            //    Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers for both base and exponent.");
            //}
            #endregion

            #region Question 5
            ////5- Write a program to allow the user to enter a string and print the REVERSE of it.


            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //// Check if the input is not null or empty
            //if (!string.IsNullOrEmpty(input))
            //{
            //    // Reverse the string using a loop
            //    string reversed = ReverseString(input);

            //    Console.WriteLine($"The reverse of the string is: {reversed}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a non-empty string.");
            //}
            #endregion


            #region Question 6
            ////6- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Enter the starting number of the range: ");
            //string startInput = Console.ReadLine();

            //Console.Write("Enter the ending number of the range: ");
            //string endInput = Console.ReadLine();

            //// Parse inputs to integers
            //if (int.TryParse(startInput, out int start) && int.TryParse(endInput, out int end))
            //{
            //    if (start > 0 && end > 0 && start <= end)
            //    {
            //        Console.WriteLine($"Prime numbers between {start} and {end}:");
            //        for (int i = start; i <= end; i++)
            //        {
            //            if (IsPrime(i))
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please ensure both numbers are positive and the starting number is less than or equal to the ending number.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers.");
            //}
            #endregion

            #region Question 7
            ////7- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a decimal number: ");
            //string input = Console.ReadLine();

            //// Parse the input to an integer
            //if (int.TryParse(input, out int decimalNumber) && decimalNumber >= 0)
            //{
            //    Console.WriteLine($"The binary representation of {decimalNumber} is: {ConvertToBinary(decimalNumber)}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            //}
            #endregion


            #region Question 8
            ////8- . Write a program that prints an identity matrix using for loop,
            ////in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.Write("Enter the size of the identity matrix (n): ");
            //string input = Console.ReadLine();

            //// Parse the input to an integer
            //if (int.TryParse(input, out int n) && n > 0)
            //{
            //    Console.WriteLine($"Identity matrix of size {n} x {n}:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                Console.Write("1 ");
            //            else
            //                Console.Write("0 ");
            //        }
            //        Console.WriteLine(); // Move to the next row
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}
            #endregion

            #region Question 9
            ////9- Write C# program that Extract a substring from a given string.

            //Console.Write("Enter the original string: ");
            //string inputString = Console.ReadLine();

            //Console.Write("Enter the starting index: ");
            //string startInput = Console.ReadLine();

            //Console.Write("Enter the length of the substring: ");
            //string lengthInput = Console.ReadLine();

            //// Parse the inputs for starting index and length
            //if (int.TryParse(startInput, out int startIndex) && int.TryParse(lengthInput, out int length))
            //{
            //    if (startIndex >= 0 && length >= 0 && startIndex + length <= inputString.Length)
            //    {
            //        string substring = inputString.Substring(startIndex, length);
            //        Console.WriteLine($"The extracted substring is: \"{substring}\"");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid range. Ensure the starting index and length are within the bounds of the string.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers for starting index and length.");
            //}
            #endregion

            #region  Question 10
            ////10- Write C# program that take two string variables and print them as one variable

            //Console.Write("Enter the first string: ");
            //string firstString = Console.ReadLine();

            //Console.Write("Enter the second string: ");
            //string secondString = Console.ReadLine();

            //// Combine the strings
            //string combinedString = firstString + secondString;

            //Console.WriteLine($"The combined string is: \"{combinedString}\"");
            #endregion

            #region Question 11

            ////11- . Write a program that prints an identity matrix using for loop,
            ////in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.Write("Enter the size of the identity matrix (n): ");
            //string input = Console.ReadLine();

            //// Parse the input to an integer
            //if (int.TryParse(input, out int n) && n > 0)
            //{
            //    Console.WriteLine($"Identity matrix of size {n} x {n}:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //                Console.Write("1 ");
            //            else
            //                Console.Write("0 ");
            //        }
            //        Console.WriteLine(); // Move to the next row
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer.");
            //}
            #endregion

            #region Question 12
            ////12- Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the number of elements in the array: ");
            //string input = Console.ReadLine();

            //// Parse input to determine the size of the array
            //if (int.TryParse(input, out int size) && size > 0)
            //{
            //    int[] array = new int[size];
            //    int sum = 0;

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        string elementInput = Console.ReadLine();

            //        if (int.TryParse(elementInput, out int element))
            //        {
            //            array[i] = element;
            //            sum += element; // Add the element to the sum
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            i--; // Retry the current element
            //        }
            //    }

            //    Console.WriteLine($"The sum of all elements in the array is: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the array.");
            //}
            #endregion


            #region Question 13

            ////13 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.


            //Console.Write("Enter the size of the arrays: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int size) && size > 0)
            //{
            //    int[] array1 = new int[size];
            //    int[] array2 = new int[size];

            //    Console.WriteLine("Enter elements for the first array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        array1[i] = ReadInteger();
            //    }

            //    Console.WriteLine("Enter elements for the second array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        array2[i] = ReadInteger();
            //    }

            //    // Merge and sort the arrays
            //    int[] mergedArray = new int[array1.Length + array2.Length];
            //    Array.Copy(array1, mergedArray, array1.Length);
            //    Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);

            //    Array.Sort(mergedArray);

            //    Console.WriteLine("Merged and sorted array:");
            //    Console.WriteLine(string.Join(" ", mergedArray));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the arrays.");
            //}
            #endregion

            #region Question 14
            //// 14- Write a program in C# Sharp to count the frequency of each element of an array.

            //Console.Write("Enter the number of elements in the array: ");
            //string input = Console.ReadLine();

            //// Validate array size
            //if (int.TryParse(input, out int size) && size > 0)
            //{
            //    int[] array = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        array[i] = ReadInteger();
            //    }

            //    // Count the frequency of each element
            //    Dictionary<int, int> frequency = new Dictionary<int, int>();

            //    foreach (int element in array)
            //    {
            //        if (frequency.ContainsKey(element))
            //        {
            //            frequency[element]++;
            //        }
            //        else
            //        {
            //            frequency[element] = 1;
            //        }
            //    }

            //    // Display the frequency of each element
            //    Console.WriteLine("Frequency of each element:");
            //    foreach (var pair in frequency)
            //    {
            //        Console.WriteLine($"Element {pair.Key}: {pair.Value} time(s)");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the array.");
            //}
            #endregion


            #region Question 15
            //// 15- Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("Enter the number of elements in the array: ");
            //string input = Console.ReadLine();

            //// Validate array size
            //if (int.TryParse(input, out int size) && size > 0)
            //{
            //    int[] array = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        array[i] = ReadInteger();
            //    }

            //    // Find maximum and minimum elements
            //    int max = array[0];
            //    int min = array[0];

            //    foreach (int element in array)
            //    {
            //        if (element > max)
            //            max = element;

            //        if (element < min)
            //            min = element;
            //    }

            //    Console.WriteLine($"Maximum element in the array is: {max}");
            //    Console.WriteLine($"Minimum element in the array is: {min}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the array.");
            //}
            #endregion

            #region Question 16
            ////16- Write a program in C# Sharp to find the second largest element in an array.

            //Console.Write("Enter the number of elements in the array: ");
            //string input = Console.ReadLine();

            //// Validate array size
            //if (int.TryParse(input, out int size) && size > 1) // Ensure at least 2 elements
            //{
            //    int[] array = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        array[i] = ReadInteger();
            //    }

            //    // Find the second largest element
            //    int largest = int.MinValue;
            //    int secondLargest = int.MinValue;

            //    foreach (int element in array)
            //    {
            //        if (element > largest)
            //        {
            //            secondLargest = largest;
            //            largest = element;
            //        }
            //        else if (element > secondLargest && element != largest)
            //        {
            //            secondLargest = element;
            //        }
            //    }

            //    if (secondLargest != int.MinValue)
            //    {
            //        Console.WriteLine($"The second largest element in the array is: {secondLargest}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("There is no distinct second largest element in the array.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer greater than 1 for the size of the array.");
            //}
            #endregion

            #region Question 17
            //// 

            //Console.Write("Enter the number of elements in the array: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int size) && size > 1)
            //{
            //    int[] array = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element [{i}]: ");
            //        array[i] = ReadInteger();
            //    }

            //    // Dictionary to store the first occurrence index of each element
            //    Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            //    int longestDistance = 0;

            //    // Loop through the array to find the longest distance
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (firstOccurrence.ContainsKey(array[i]))
            //        {
            //            // Calculate the distance between the current and first occurrence of the element
            //            int distance = i - firstOccurrence[array[i]] - 1;
            //            if (distance > longestDistance)
            //            {
            //                longestDistance = distance;
            //            }
            //        }
            //        else
            //        {
            //            // Store the first occurrence index of the element
            //            firstOccurrence[array[i]] = i;
            //        }
            //    }

            //    if (longestDistance > 0)
            //    {
            //        Console.WriteLine($"The longest distance between two equal cells is: {longestDistance}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No equal cells found with a distance greater than 0.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer greater than 1 for the size of the array.");
            //}
            #endregion


            #region Question 18
            ////18- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array.
            ////                Now copy all the elements of first array on second array and print second array.

            //// Input the size of the 2D arrays
            //Console.Write("Enter the number of rows for the arrays: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns for the arrays: ");
            //int cols = int.Parse(Console.ReadLine());

            //// Create two multidimensional arrays of the same size
            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //// Accept values from the user and store them in the first array
            //Console.WriteLine("Enter the values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy all elements from the first array to the second array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //// Print the second array
            //Console.WriteLine("Elements of the second array (after copying from the first array):");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + "\t");
            //    }
            //    Console.WriteLine(); // New line after each row
            //}
            #endregion


            #region Question 19
            //// 19- Write a Program to Print One Dimensional Array in Reverse Order
            //// Input the size of the array
            //Console.Write("Enter the number of elements in the array: ");
            //int size = int.Parse(Console.ReadLine());

            //// Create the array
            //int[] array = new int[size];

            //// Accept values from the user and store them in the array
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// Print the array in reverse order
            //Console.WriteLine("Array in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            #endregion


            // ******************************************** Demo_Session4_C# *********************************************//
            #region Loop Statement
            //Console.WriteLine("1 T ");
            //Console.WriteLine("2 T ");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 0;i<=10;i++)

            //{
            //    Console.WriteLine(i +"T");
            //}


            #endregion

            #region for- foreach

            //// el for loop momken a8er beha fe array ela9ly enma foreach l2 3lshan foreach bta5od nos5a mn array bs wbtsht8l 3leha
            //int[] numbers = {1,2,3,4,5,6,7,8,9,10};


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //if (numbers[i] == 4)
            //    //{
            //    //    break;
            //    //}
            //    if (numbers[i] == 4)
            //    {
            //        continue;
            //    }
            //    //numbers[i] += 10;
            //    Console.WriteLine(numbers[i]+10);
            //}

            ////// class implement interface IEnumerable
            ////foreach (int number in numbers) 
            ////{
            ////    //number += 10;   invalid 
            ////    Console.WriteLine(number+10);

            ////}



            #endregion

            #region Wihle - Do While
            //int number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number :");
            //    //number =int.Parse(Console.ReadLine());
            //    flag = int.TryParse(Console.ReadLine(), out number);

            //} while (number % 2 == 1 || !flag);

            //Console.WriteLine($"{number} is Even");


            //int number=3;
            //bool flag = false;
            //while (number % 2 == 1 || !flag) 
            //{
            //    Console.WriteLine("Enter Even Number :");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}
            //Console.WriteLine($"{number} is Even");



            #endregion

            #region Strring

            // class => Reference Type
            // immutable Data Type [Value can not Changed]
            // Array of Chars
            // A H M E D 


            //string name;


            //name = new string("Ahmed");
            //name = "Ahmed";

            //string name01 = "Ahmed";
            //string name02 = "Ahmed";


            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC :{name01.GetHashCode()}");

            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC :{name02.GetHashCode()}");


            string name01 = "Ahmed";
            string name02 = "Ali";


            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC :{name01.GetHashCode()}");

            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC :{name02.GetHashCode()}");




            //name02 = name01;
            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC :{name01.GetHashCode()}");

            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC :{name02.GetHashCode()}");




            //name01 = "Abdullah";
            //Console.WriteLine(name01);
            //Console.WriteLine($"Name01 HC :{name01.GetHashCode()}");

            //Console.WriteLine(name02);
            //Console.WriteLine($"Name02 HC :{name02.GetHashCode()}");


            //string message = "Hello";
            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //message += "Route";

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());
            #endregion

            #region StringBuilder

            //StringBuilder message;
            //message = new StringBuilder("Hello");

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //message.Append("Route");


            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            #endregion

            #region StringBuilder Methods

            //StringBuilder message = new StringBuilder("Welcom");

            //message.Append("To Route");
            //message.AppendLine("Abdullah");

            //Console.WriteLine(message);
            //message.Append("Mahmoud");
            //Console.Write(message);

            //message.Remove(0, 6);
            //Console.WriteLine(message);

            //message.Insert(0, "Welcom");
            //Console.WriteLine(message);


            //int age = 10;
            //string name = "ali";
            //message.AppendFormat($"\nName: {name} , Age : {age}");
            //Console.WriteLine(message);

            //Console.WriteLine("\n");
            //message.AppendJoin("/"," abdullah","mahmoud","sayed",23);
            //Console.WriteLine(message);

            #endregion

            #region Array 1 D

            int[] numbers=new int[3] {1,2,3};
            //int[] numbers = new int[] {1,2,3};
            //int[] numbers = { 1, 2, 3 };


            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);


            //int[] numbers = new int[3];


            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //     Console.WriteLine($"Enter Element Number {i+1}");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank);
            #endregion

            #region 2D Array
            //int[,] marks = new int[3, 5];
            ////{ {1,2,3,4,5 }, { 10,20,30,40,50}, {100,200,300,400,500 } }


            ////Console.WriteLine(marks.Length);
            ////Console.WriteLine(marks.Rank);

            ////Console.WriteLine(marks.GetLength(0));
            ////Console.WriteLine(marks.GetLength(1));

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Grade Student ({i + 1})");
            //    for (int j = 0; j < marks.GetLength(1);/* j++ */)
            //    {
            //        bool flag;
            //        Console.WriteLine($"Enter Grade Subject [{j + 1}]");
            //        //marks[i, j] = int.Parse(Console.ReadLine());
            //        flag = int.TryParse(Console.ReadLine(), out marks[i, j]);

            //        //if(flag && marks[i,j] >=0)
            //        //{
            //        //    j++;
            //        //}

            //        //or

            //        j = flag && marks[i, j] >= 0 ? ++j : j;


            //    }
            //}

            ////for (int i = 0; i < marks.GetLength(0); i++)
            ////{
            ////    Console.WriteLine($"Grades Student ({i + 1})");
            ////    for (int j = 0; j < marks.GetLength(1); j++)
            ////    {
            ////        Console.Write($"Grades Subject [{j + 1}] :");
            ////        Console.WriteLine(marks[i, j]);

            ////    }
            ////}


            //// el for loop de bdl 2 forloop bto3 elteba3a
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i/marks.GetLength(1),i%marks.GetLength(1)]);
            //}


            #endregion

            #region Judged Array

            //int[][] number = new int[3][];

            //number[0]=new int[3] {2,4,5};
            //number[1]=new int[2] {1,8};
            //number[2]=new int[1] {7};

            //for (int i = 0; i < number.Length; i++) 
            //{
            //  for(int j =0;j < number[i].Length; j++)
            //    {
            //        Console.WriteLine(number[i][j]);
            //    }
            //}
            #endregion

            // ******************************************* Task_Session4_C#  *********************************************//

            #region Task
            // Step 1: Create a fixed-size array of integers
            int[] array = new int[5] { 1,2,3,4,5};  // Fixed size array of 5 elements

            //*******************************************************
            //// Step 2: Enter valuse of array 
            //Console.WriteLine("Enter 5 elements for the array:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"Element {i}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //*******************************************************

            //// Step 3: Accessing array elements
            //Console.WriteLine("Accessing array elements:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Element at index {i} is {array[i]}");
            //}
            //*******************************************************


            //// Step 4: Updating an array element
            //Console.WriteLine("\nUpdating element at index 2:");
            //array[2] = 100;
            //Console.WriteLine($"Updated element at index 2: {array[2]}");

            //********************************************************

            //// Step 3: Accessing array elements To displey modification
            //Console.WriteLine("Accessing array elements:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Element at index {i} is {array[i]}");
            //}

            //===========================================================

            //// Step 5: Displaying the entire array
            //Console.WriteLine("\nArray after update:");
            //PrintArray(array);

            //********************************************************


            //// Step 6: Sorting the array in ascending order
            //Array.Sort(array);
            //Console.WriteLine("\nArray after sorting in ascending order:");


            //PrintArray(array);

            //*********************************************************

            //// Step 7: Searching for an element in the array
            //Console.Write("\nEnter a number to search in the array: ");
            //int searchValue = int.Parse(Console.ReadLine());
            //int index = Array.IndexOf(array, searchValue);

            //if (index != -1)
            //{
            //    Console.WriteLine($"The value {searchValue} was found at index {index}");
            //}
            //else
            //{
            //    Console.WriteLine($"The value {searchValue} was not found in the array.");
            //}

            //************************************************************
            //// Step 8: Reversing the array
            //Array.Reverse(array);
            //Console.WriteLine("\nArray after reversing:");


            //PrintArray(array);


            //************************************************************
            //// Step 9: Resizing the array (Increasing size)
            //Array.Resize(ref array, 7);
            //Console.WriteLine("\nArray after resizing (size increased to 7):");
            //PrintArray(array);



            //==================================================================

            //// Step 9: Resizing the array (Increasing size)
            //Console.WriteLine("\nEnter the new size for the array:");
            //int newSize = int.Parse(Console.ReadLine());
            
            //// Resize the array based on user input
            //if (newSize > array.Length)
            //{
            //    Array.Resize(ref array, newSize);
            //    Console.WriteLine($"\nArray after resizing (size increased to {newSize}):");
            //    PrintArray(array);
            //}
            //else
            //{
            //    Console.WriteLine("\nNew size must be greater than the current size.");
            //}

            //==========================================================




            //************************************************************
            // Step 10: Filling the array with a specific value
            //Array.Fill(array, 0);
            //Console.WriteLine("\nArray after filling with 0:");
            //PrintArray(array);
            #endregion 

        }



        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static string ConvertToBinary(int number)
        {
            if (number == 0)
                return "0";

            string binary = string.Empty;

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary; // Append the remainder to the left
                number /= 2;
            }

            return binary;
        }

        static int ReadInteger()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    return value;

                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
        }


        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

    }
}
