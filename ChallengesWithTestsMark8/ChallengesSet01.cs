using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            int sum =  number1 + number2;
            return sum;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
           int smallNum = Math.Min(number1, number2);
            return smallNum;
        }

        public long Multiply(long factor1, long factor2)
        {
           
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
            //  return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"{nameOfPerson}!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
