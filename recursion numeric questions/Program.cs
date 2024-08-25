using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion_numeric_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //1
        // param: positive number
        // return: sum of all numbers from 1 to n
        // n = 5 return 15 (1+2+3+4+5)
        public static int sum(int n)
        {
            return 0;
        }
        //2
        // param: positive number
        // return: n! (factorial n)
        // n = 4 return 24 (1*2*3*4)
        public static int factorial(int n)
        {
            return 0;
        }
        //3
        // param: positive number
        // return: num of digits
        // n = 2981 return 4
        public static int numOfDigits(int n)
        {
            return 0;

        }
        //4
        // param: positive number
        // return: sum of digits over and over until sum is one digit
        // 991 -> 19 -> 10 -> 1
        public static int sumOfDigits(int n) //פעולה עוטפת
        //פעולה עוטפת בד"כ דרושה להזנה ראשונית שך הרקורסיה
        {
            return 0;
        }
        public static int sumOfDigitsHelp(int n)
        {
            return 0;
        }
        //5
        // param: double number
        // return: fractional part
        // 991.123 -> 0.123
        // use only +/-
        public static double fractionalPart(double num)
        {
            return 0;

        }
        //6
        // param: positive number
        // return: product of odd numbers from 1 to n
        // n = 5 return 15 (1*3*5)
        // n = 6 return 15 (1*3*5)
        public static int oddsProduct(int n) //needed, or else for each number we'll need to check
        {
            return 0;
        }
        public static int oddsProductHelp(int n) //trying to solve only with this will be ugly and not optimized
        {
            return 0;
        }
        //7
        // param: 2 positive numbers
        // return: n*m
        // use only +/-
        // n=8 m=2 reuslt = 16
        // n=10 m=3 result = 30
        public static int mult(int n, int m)
        {
            return 0;
        }
        //8
        // param: 2 positive numbers
        // return: n/m
        // use only +/-
        // n=8 m=2 reuslt = 4
        // n=10 m=3 result = 3
        public static int quotient(int n, int m)
        {
            return 0;
        }
        //9
        // param: 2 positive numbers
        // return: n%m
        // use only +/-
        // n=8 m=2 reuslt = 0
        // n=10 m=3 result = 1
        public static int remainder(int n, int m)
        {
            return 0;
        }
        //10
        // param: positive number
        // return: biggestDifferenceBetweenTwoAdjacentDigits
        // n = 291655 return 8 (9-1 > 9-2,6-1,6-5,5-5)
        public static int biggestDifferenceBetweenTwoAdjacentDigits(int num)
        {
            return 0;
        }

        public static int biggestDiff2(int num) //another solution for the above
        {
            return 0;
        }

    }
}
