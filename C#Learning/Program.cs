using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            //while(factNum > factNum-1)
            //{
            //    int factorial = 1;
            //    for (int i =1; i<=factNum; i++)
            //    {
            //        factorial *= i;
                  
            //    }
            //    Console.WriteLine($"Factorial of {factNum} is {factorial}");
            
            //}
            // Q4. Check if a number is a prime number.
            Console.Write("Enter a number to check it it is prime: ");
            int primeNum = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if(primeNum <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i= 2; i<=Math.Sqrt(primeNum); i++)
                {
                    if (primeNum % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
