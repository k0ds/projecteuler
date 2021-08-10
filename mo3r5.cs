/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.*/
using System;

namespace mo3r5
{
    class Program
    {
        public static void Main(String[] args)
        {

            double upper = 1000;
            double lower = 1;
            double numtotal = 0;

            double num = lower;

            while (num < upper)
            {
                if (isMultipleOf5(num) == true || isMultipleOf3(num))
                {

                    numtotal = numtotal + num;
                    num++;


                }
                else
                {
                    num++;
                }

               
                //Console.WriteLine(num); uncomment to see output each iteration


            }
            Console.WriteLine(numtotal);








        }


        public static bool isMultipleOf5(double num1)
        {
            
            if ( num1 % 5 == 0) // if  the number divided by 5 is even  then it is a multiple
            {
                return true;

            }
            else
            {
                return false;
            }

        }


        public static bool isMultipleOf3(double num2)
        {
           
            
            if ( num2 % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool isOdd(double num3)
        {
            return num3 % 2 != 0;



        }







    }
}
