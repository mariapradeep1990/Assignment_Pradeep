using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            Console.ReadKey(true);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + roundUp(r1,2));

            Console.ReadKey(true);

            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);

            Console.ReadKey(true);

            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);

            Console.ReadKey(true);

            int n4 = 5;
            printTriangle(n4);

            Console.ReadKey(true);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            Console.ReadKey(true);


            // write your self-reflection here as a comment
            /* Learnings based on assignment number 1
             * - Getting comfortable with the toolset of IDE     
             * - Learning the structure alongside with basics of programming
             * - Usage of independent methods to easily use them in the program as many times as required thus making the program more efficient
             * - Usage of iterative loops to attain the required logic towards solution
             * - Learnings on the benefits of using error and exception handling - try and catch
            */

        }


        public static void printPrimeNumbers(int x, int y) // Method to print all prime numbers within a given range of numbers*/
        {
            try
            {
                int i, j;
                Console.WriteLine("The prime numbers between the provided range of numbers is: ");
                for (i = x; i <= y; i++)
                {
                    for (j = 2; j <= i; j++)

                        if (i % j == 0) // checks the condition whether the number can be only divided by itself */

                            break;


                    if (i == j)

                        
                        Console.WriteLine(+i);

                }


               Console.ReadKey(true);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        
        /* This method will compute the result of the series upto n elements. */
        public static double getSeriesResult(int n)
        {
           
            try
            {
                double fact1 = 0.0;
                double fact2 = 0.0;
                double fact = 0.0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0) //checks whether the number is odd and makes it a positive factorial */
                    {
                        fact1 = (fact1 + Factorials(i)) / (i + 1);
      
                        
                    }
                    else  //checks whether the number is even and makes it a negative factorial */
                    {
                        fact2 = -(fact2 + (Factorials(i) / (i + 1))); 
                        
                    }
                }
                fact = fact1 + fact2; // Addition of both the factorials to compute the series upto n elements */
                return fact;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static double Factorials(double l1)
        {
            double y = l1;
            for (double i = l1 - 1; i >= 1; i--)
            {
                y = y * i;
            }
            return y;
        }

    

        /* Below is a method to round up the decimal points */
        public static decimal roundUp(double inp, int points)
        {
            decimal b = (decimal)inp;
            return decimal.Round(b, points);
        }

        /* Method to covert a number from decimal to binary */
        public static long decimalToBinary(long q)
        {
            try
            {
                string binaryResult = string.Empty;
                long rem = 0;
                while (q > 0)
                {
                    rem = q % 2; // get the remainder
                    q = q / 2; // Divide the quotient by 2.
                    binaryResult = rem.ToString() + binaryResult;
                }
                
                return Convert.ToInt64(binaryResult); //convert binary result to integer 
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        /* Method to convert a number from binary (base 2) to decimal (base 10) */
        public static long binaryToDecimal(long num)
        {
            try
            {

                long rem, bValue = 1, Result = 0;
                while (num > 0)
                {
                    
                    rem = num % 10; // Modulus 10 will give the remainder of the number which is the rightmost bit
                    Result = Result + (rem * bValue); // Base Value to be multiplied with the remainder and then added along with result

                    num = num / 10; // The already used bit from the rightmost will be removed by dividing the number by 10
                    bValue = bValue * 2;
                }
                return Result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        /* Method to print a triangle with a cone shape with desired number of rows*/
        public static void printTriangle(int rows)
        {
            try
            {
                Console.WriteLine("\nTriangle of " + rows + " rows:");
                
                for (int i = 0; i < rows; i++) // Forloop to handle number of rows from zero to 5 rows as required
                {

                    for (int j = rows - i; j > 1; j--) // For loop to compute the number of spaces required as per the number of rows provided
                    { 
                        Console.Write(" "); // to print the spaces desired, number of times
                    }

               
                    for (int j = 0; j <= i; j++)
                    {
                         
                        Console.Write("* "); // Print stars in columns and depends on the top most for loop according to row values
                    }

                    
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        /* Method to compute the frequency of all the elements in the given 1-D array */
        public static void computeFrequency(int[]k)
        {
            try
            {
                
                Console.WriteLine("Element Frequency of the number ");
                for (int i = 0; i < k.Length; i++)
                {
                    
                    int usage = 0;
                    for (int j = 0; j < i; j++) // Check if the number was used earlier
                    {
                        if (k[i] == k[j])
                        {
                            usage++; // increment the usage of number by 1
                        }
                    }

                    
                    if (usage == 0) // The Loop continues to run if the usage of the number is for the first time
                    {
                        
                        int c = 1; // initiate to 1 since the minimum occurence could always be 1

                        for (int j = i + 1; j < k.Length; j++)
                        {
                            if (k[i] == k[j])

                                c++;
                        }
                        Console.WriteLine(k[i] + "      " + c);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}