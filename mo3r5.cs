/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.*/
using System;

    namespace mo3r5
    {
        class Program
        {
            public static void Main(String[] args)
            {

               int upper = 1000;
               int lower = 1;
               int numtotal = 0;

               int num = lower;

               while (num <= upper)
               {
                  if (isMultipleOf5(num) == true)
                  {
                      
                    numtotal = numtotal + num;
                    //num++;

                    
                  }
                  else
                  {
                      //num++;
                  }

                  if (isMultipleOf3(num) == true)
                  {
                     numtotal = numtotal + num;
                     //num++;

                  }
                  else
                  {
                      //num++;
                  }
                  
                

               }
                   Console.WriteLine(num);








            }


            public static bool isMultipleOf5(int num1)
            {
                num1 =  num1 / 5;
                if (isOdd(num1) == false) // if  the number divided by 5 is even  then it is a multiple
                {
                   return true;

                }
                else
                {
                    return false;
                }

            }


            public static bool isMultipleOf3(int num2)
            {
             num2 = num2 / 3;
             if (isOdd(num2) == false )
             {
                   return true;
             }
             else
             {
                 return false;
             }


            }

            public static bool isOdd(int num3)
            {
              return num3%2 !=0;



            }







        }
    }
