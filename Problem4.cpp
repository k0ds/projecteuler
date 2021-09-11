/*

A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/

#include <iostream>
#include <bits/stdc++.h>

using namespace std;

bool isPalindrome(std::string num)
{

    std::string rev = num;
    reverse(rev.begin(), rev.end());
    if (rev == num)
    {
        return  true;
    }
    else return false;




}

int main()
{



    int c = 0;
    int d = 0;


    for (int a = 100; a < 1000; a++)
    {


        for (int b = 100; b < 1000; b++)
        {
            c = a * b;
            std::string num = to_string(c);
            if (isPalindrome(num) == true)
            {
                cout << "pal " << a << "\n";
                cout << "pal " << b << "\n";
                if (c > d)
                {
                    d = c;
                }


            }




      }
    }


    cout << d;

}