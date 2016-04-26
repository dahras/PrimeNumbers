using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("This program will find out the prime numbers between the numbers you enter.");
            Console.ReadKey();

            Console.WriteLine("Enter First Number");
            string SmallNumber = Console.ReadLine();
            int FirstNumber;
            int.TryParse(SmallNumber, out FirstNumber);
            //Console.WriteLine(FirstNumber);

         

            System.Console.WriteLine("Enter Second Number");
            string LargeNumber = Console.ReadLine();
            int SecondNumber;
            int.TryParse(LargeNumber, out SecondNumber);


            if (FirstNumber <= 1)
            {
                Console.WriteLine("Either You have not entered a numeric value or number is less than 2, Press any key to exit");
                Console.ReadKey();
            }

                 else if (SecondNumber < FirstNumber)
            {
                Console.WriteLine("Second Number is Smaller than the first, Press any key to exit and try again");
                Console.ReadKey();


            }
            else if(SecondNumber>= FirstNumber)
            {
                for (int i = FirstNumber; i <= SecondNumber; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= SecondNumber; j++)
                        {
                       
                        if (i != j && i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }

                        }
                        if (isPrime)
                        {
                            Console.Write("\t" + i);
                        }
                        isPrime = true;
                    }
                    Console.ReadKey();
                }
            }
        }


            }


       
