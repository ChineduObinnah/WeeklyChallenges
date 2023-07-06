using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach ( bool value in vals)
            {
                if ( value == false)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if( numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sumNum = 0;
            foreach ( int number in numbers)
            {
                if( number % 2 != 0)
                {
                    sumNum += number; 
                }
            }
            return sumNum % 2 !=0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isUpper = false;
            var isLower = false;
            var isNum= false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
               else if (char.IsUpper(password[i]))
                {
                    isUpper= true;
                }
               else if (char.IsDigit(password[i]))
                {
                    isNum = true;
                }

                if (isUpper && isLower && isNum)
                {
                    return true;
                }

            }
                return false;



        }
        

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1]; 
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> result = new List<int>();
            for ( int i = 1; i < 100; i += 2)
            {
                result.Add(i);
            }
            return result.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
     
            for( int i  = 0; i < words.Length; i++ )
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
