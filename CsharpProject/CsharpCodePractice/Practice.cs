using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodePractice
{
    public class Practice
    {
        public void Even()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Enter number is even");
            }
            else { Console.WriteLine("Given number is Odd"); }
        }
        // Swap two number using third/ temporary veriable
        public void swapwithtemp()
        {
            Console.WriteLine("Enter the First number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int number2 = int.Parse(Console.ReadLine());
            int temp;
            Console.WriteLine("Before swapping number1 = {0}, and number2 ={1}", number1, number2);
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After swapping number1 = {0}, and number2 ={1}", number1, number2);
        }
        public void swapwithouttemp()
        {
            Console.WriteLine("Enter the First number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swapping number1 = {0}, and number2 ={1}", number1, number2);
            number1 = number1 + number2;
            number1 = number1 - number2;
            Console.WriteLine("After swapping number1 = {0}, and number2 ={1}", number1, number2);
        }
        // Program to sum digits of a given number
        public void SumOfGivenDigit()
        {
            Console.WriteLine("Enter the First number");
            int number = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while (number != 0)
            {
                rem = number % 10; // 1,2
                sum = sum + rem; // 1 ,3 ,1 =4
                number = number / 10; //12,1
            }
            Console.WriteLine("Sum of given digit  = {0},", sum);
        }
        // Check given number is prime or not
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Enter the First number");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Entered number is prime");
            }
            else { Console.WriteLine("Entered number is not a prime"); }
        }
        // Print All the Prime number b/w 1 to 100
        public void prime1()
        {
            for (int number = 1; number <= 100; number++)
            {
                int count = 0;

                for (int i = 1; i <= number; i++)
                {

                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public void TotalNumberofPrimeNo()
        {
            //int count = 0;
            //bool prime;
            //for (int i = 0; i < 10; i++)
            //{
            //    prime = true;
            //    for (int j = 2; j < i && prime = true; j++)
            //    {
            //        if(i % j ==0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //    }
            //    if (prime )
            //    {

            //    }
            //}
        }
        public void PalindromeNumber()
        {
            Console.WriteLine("Enter the First number");
            int number1 = int.Parse(Console.ReadLine());
            int rem, sum = 0;
            while (number1 != 0)
            {
                rem = number1 % 10;
                sum = (sum * 10) + rem;
                number1 = number1 % 10;
            }
            Console.WriteLine(sum);
        }
        public void CapitalLetter()
        {

            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
        public void SmallLetter()
        {
            Console.WriteLine("Small Alphabet letter");
            for (char j = 'a'; j <= 'z'; j++)
            {
                Console.WriteLine(j);
            }  
        }
    }
}
