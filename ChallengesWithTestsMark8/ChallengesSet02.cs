using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            
          
            return false;
            
        }

        public bool IsNumberEven(int number)
        {
            if ( number % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if ( num % 2 != 0)
            {
                return true;
            }
            
            else
            {
                return false;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            if (numbers == null)
            {
                return 0;
            }
            foreach (double number in numbers)
            {
                if ( number< min)
                {
                    min = number;   
                }
                if ( number> max )
                {
                    max = number;
                }
            }

            double sum = min + max;
            return sum;
           
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           var list = new List<int>() { str1.Length, str2.Length };
            return list.Min();
        }
        
        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
           
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int isOdd = 0;
            if ( numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                isOdd += number;
            }
            return isOdd % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
            //long count = (number + 1) / 2;
            //return count;
        }
    }
}
