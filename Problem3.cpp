/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?

 NOTE: I did not write most of this code I only made some slight modifications but the original logic is still there

 credit to https://www.geeksforgeeks.org/prime-factor/

*/



#include <iostream>
#include <cmath>
using namespace std;


void Prime(long n)
{

   while (n%2 == 0)
   {
       cout << 2;
       n = n/2;

   }

   for (int i = 3; i <= sqrt(n); i = i+2)
   {
       while (n%i == 0)
       {
           cout << i << " ";
           n = n/i;
       }
   }

   if (n > 2)
       cout << n;


}
int main()
{
    long n = 600851475143;
    Prime(n);




}



