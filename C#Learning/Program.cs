using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Program
    {
     //   public class Person
     //   {
     //       private string name;
     //       public string Name
     //       {
     //           get { return name; }
     //           set { name = value; }
     //       }
     //       //Constuctor
     //       public Person(string personName)
     //       {
     //           name = personName;

     //       }
     //       public void SayHello()
     //       {
     //           Console.WriteLine("Hello , my name is " + name);
     //       }
     //   }
     //public struct Point
     //   {
     //       public int x;
     //       public int y;
     //       public Point(int x, int y)
     //       {
     //           this.x = x;
     //           this.y = y;
     //       }
     //       public void Display()
     //       {
     //           Console.WriteLine($"Point is at ({x}, {y})");
     //       }
     //   }
        public class Car
        {
            public string brand;
            public int model;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public int Model
            {
                get { return model; }
                set { model = value; }
            }
            public Car(string brandOf, int modelOf)
            {
                brand = brandOf;
                model = modelOf;

            }
            public void DisplayDetails()
            {
                Console.WriteLine($"Card brand is {brand} and modal is {model}");
            }
        }
        public struct Rectangle
        {
            public double length;
            public double width;
                public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }
            public double CalcluateArea()
            {
                return length * width;
            }
        }
        static void Main(string[] args)
        {

            Car c = new Car("Honda", 2022);
            c.DisplayDetails();
            Rectangle r = new Rectangle(10.5, 8);
            double area = r.CalcluateArea();
            Console.WriteLine($"the area is {area}");
            //Person p = new Person("Shahryar");
            //p.SayHello();
            //Point point = new Point(10, 20);
            //point.Display();
            Console.ReadLine();
            //Q2. Write a program that converts temperature from Celsius to Fahrenheit.
            //double celcius = 100;
            //double farheniet = celcius * 9/5 + 32;
            //Console.WriteLine(farheniet);

            //Q2. Ask the user to enter principal, rate of interest, and time.Then calculate Simple Interest using:
            //Console.Write("Enter principal ammount");
            //string principalValue = Console.ReadLine();
            //double principal = Convert.ToDouble(principalValue);
            //Console.Write("Enter rate of interest");
            //string rateValue = Console.ReadLine();
            //double interest = Convert.ToDouble(rateValue);
            //Console.Write("Enter time in years");
            //string yearValue = Console.ReadLine();
            //double year = Convert.ToDouble(yearValue);
            //double simpleInterest = (principal * interest * year) / 100;
            //Console.WriteLine("Simple Interet is:" + simpleInterest);

            // Q3. Write a program that takes two numbers and swaps their values using a third variable.
            //int a = 10;
            //int b = 20;
            //Console.WriteLine("Before swapping: a = " + a + " and b = " + b);
            //int c;
            //c = b;
            //b = a;
            //a = c;
            //Console.WriteLine("After swapping: a = " + a + " and b = " + b);

            //Ask the user to enter marks for 5 subjects.Calculate:
            //Console.Write("Enter marks of subject 1; ");
            //double marks = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter marks of subject 2; ");
            //double marks2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter marks of subject 3; ");
            //double marks3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter marks of subject 4; ");
            //double marks4 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter marks of subject 5; ");
            //double marks5 = Convert.ToDouble(Console.ReadLine());
            //double totalMarks = marks + marks2 + marks3 + marks4 + marks5;
            //double perecentage = (totalMarks / 500) * 100;
            //Console.WriteLine("Total marks: " + totalMarks);
            //Console.WriteLine("Percentage: " + perecentage);

            //🔹 1.Simple Calculator
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the operator (+, - , *, /, %): ");
            //char op = Convert.ToChar(Console.ReadLine());
            //double result = 0;
            //switch(op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    case '%':
            //        result = num1 % num2;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}
            //Console.WriteLine("Result: " + result);

            //🔹 2.Check Even or Odd
            //Console.Write("Enter a number want to check if number is even of odd: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("the number id odd");
            //}
            //🔹 3.Find the Largest of 3 Numbers
            //Console.Write("Enter first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter third number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //if(num1>num2 && num1 >num3)
            //{
            //    Console.WriteLine($"{num1} is greater");
            //}
            //else if(num2>num1 && num2 >num3)
            //{
            //    Console.WriteLine($"{num2} is greater");
            //}
            //else if(num3>num1 && num3>num2)
            //{
            //    Console.WriteLine($"{num3} is greater");
            //}

            //🔹 4.Check if a Number is Positive, Negative, or Zero
            //int nuumber = 1;
            //if (nuumber > 0)
            //{
            //    Console.WriteLine("The number is positive");
            //}
            //else
            //{
            //    Console.WriteLine("the number is negative");
            //}
            //🔹 5.Swap Two Numbers(Without Third Variable)
            //         var swap1 = 10;
            //         var swap2 = 50;
            //         Console.WriteLine("Before swap swap1 = " + swap1 + " and swap2 = " + swap2);
            //         swap1 = swap1 + swap2;
            //         swap2 = swap1 - swap2;
            //         swap1 = swap1 - swap2;
            //Console.WriteLine("After swap swap1 = " + swap1 + " and swap2 = " + swap2);
            //         Console.WriteLine();
            //🔹 6.Leap Year Checker
            //Console.Write("Enter the year to check leap year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //if (year % 4 == 0 & year % 100 !=0 || year % 400 == 0)
            //{
            //    Console.WriteLine($"leap year is {year}");
            //}
            //else
            //{
            //    Console.WriteLine($" {year} is not a leap year");
            //}
            //Q3. Print numbers from 1 to 10 using a for loop.
            //for (int i= 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"i = {i}");
            //}
            //Q2. Sum of all even numbers between 1 and 100. 
            //int sum = 0;
            //for(int i = 1; i < 100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();
            // Q3. Factorial of a number (e.g., 5! = 5 × 4 × 3 × 2 × 1) using a while loop.
            //Console.Write("Enter a number to calcluate the factorial: ");
            //int factNum = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //int i = 1;
            //while (i >= factNum)
            //{
            //    factorial *= i;
            //    i++;
            //}
            //Console.WriteLine($"factorial of {factNum } number is {factorial}");

            // Functions 
            //1. PrintEvenNumbers() – prints even numbers from 1 to 50.
            //void PrintEvenNumbers()
            //{
            //    int num = 50;
            //    for(int i = 0; i <= num; i+=2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //PrintEvenNumbers();
            //2. CalculateArea(double radius) – calculates and returns the area of a circle.
            //double CalculateArea()
            //{
            //    Console.Write("Enter the radius for caluating area: ");
            //    double radius = Convert.ToDouble(Console.ReadLine());
            //    return Math.PI * radius * radius;
            //}
            //double area = CalculateArea();
            //Console.WriteLine(area);
            //3. IsEligibleForVoting(int age) – checks if the person is 18 or older and returns a message.(int age) – checks if the person is 18 or older and returns a message.
            //string  IsEligibleForVoting() {
            //     Console.Write("Enter your age to check if you are eligible for voting: ");
            //     int age = Convert.ToInt32(Console.ReadLine());
            //     if (age >= 18)
            //     {
            //         return "You are eligible to vote";
            //     }
            //     else
            //     {
            //         return "You are  not eligible to vote";
            //     }
            // }
            // Console.WriteLine(IsEligibleForVoting());

            //void Add(ref int a)
            //{
            //    a += 10;
            //}
            //int number = 5;
            //Console.WriteLine($"Before calling method it was {number}");
            //Add(ref number);
            //Console.WriteLine($"After calling method it was {number}");try{try{
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int number = Convert.ToInt32(Console.ReadLine()); ;
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Invalid output enter a number");
            //}
            //finally
            //{
            //    Console.WriteLine("Execution completed");
            //}
            //1. SafeDivision() – Ask user to enter 2 numbers and handle divide-by - zero exception.
            //void SafeDivision()
            //{
            //    Console.Write("Enter the 1st number: " );
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter the 2nd number: " );
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    try
            //    {
            //        Console.WriteLine(num1/num);
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("Division by 0 is not allowed");
            //    }
            //}
            //SafeDivision();
            //2. ParseAge() – Ask user to input age, handle FormatException if non-numeric value is entered.
            //void ParseAGe()
            //{
            //    try
            //    {
            //        Console.Write("Enter you age: ");
            //        int age = Convert.ToInt32(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid digit enter enter a numerical value");

            //    }

            //}
            //ParseAGe();
            //3. ThrowIfNegative(int number) – Throw an exception if the number is negative.
            //void ThrowIfNegative()
            //{

            //    Console.Write("Enter the number");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    if (number < 0)
            //    {
            //        throw new Exception("the number u entered is negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number u entered is "+ number);
            //    }

            //}
            //ThrowIfNegative();
            // Field
         
    
        }

    }
}
