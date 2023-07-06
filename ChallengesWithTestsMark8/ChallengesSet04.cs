using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
           
           foreach( int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
           return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> {  number1, number2, number3, number4 };
            return list.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
           //bool side1 = false;
           // bool side2 = false;
           // bool side3 = false;
           // if(sideLength1 + sideLength2 > sideLength3) 
           // {
           //     return true;
           // }
           // else if ( sideLength2 + sideLength3 > sideLength1)
           // {
           //     return true;
           // }
           // else if( sideLength3 + sideLength1 > sideLength2)
           // {
           //     return true;
           // }
           // return false;

            return sideLength1 + sideLength2 > sideLength3 &&
                   sideLength2 + sideLength3 > sideLength1 &&
                   sideLength3 + sideLength1 > sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;

            foreach( var obj in objs)
            {
                if(obj == null)
                {
                    count++;
                }

            }
            if(count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            int count = 0;
            int sum = 0;
            if ( numbers == null)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if( number % 2 == 0)
                {
                    count++;
                    sum += number;
                }
            
            }
            return count == 0 ? 0 :(double) sum / count;
        }


        public int Factorial(int number)
        {
           if( number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

    }
}
