using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = new List<int>();
            var odds = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else odds.Add(number);
            }

            return evens.Sum() - odds.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Count();
            
            if (str2.Count() < shortest)
            {
                shortest = str2.Count();
            }
            if (str3.Count() < shortest)
            {
                shortest = str3.Count();
            }
            if (str4.Count() < shortest)
            {
                shortest = str4.Count();
            }
            
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;

            if (number2 < number1)
            {
                smallest = number2;
            }
            if (number3 < number2)
            {
                smallest = number3;
            }
            if (number4 < number3)
            {
                smallest = number4;
            }

            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //sum of lengths of any 2 sides is always larger than length of 3rd side
            int a = sideLength1;
            int b = sideLength2;
            int c = sideLength3;

            return (a + b > c) && (b + c > a) && (c + a > b);

            //if (a + b > c) && (b + c > a) && (c + a > b))
            //{
            //    return true;
            //}
            //else return false;
        }

        public bool IsStringANumber(string input)
        {      
            if (input is null)
            {
                return false;
            }

            return double.TryParse(input, out _);

            //bool isNumber = double.TryParse(input, out _);
            //return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            double majority;
            if (objs.Length % 2 == 0)
            {
                majority = objs.Length / 2.0 + 1;
            }
            else
            {
                majority = objs.Length / 2.0 + 0.5;
            }

            double nullCount = 0;
            foreach (var o in objs)
            {
                if (o == null)
                {
                    nullCount++;
                }
            }

            return (nullCount >= majority);

            //if (nullCount >= majority)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = new List <int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
            }

            if (evens is null || evens.Count == 0)
            {
                return 0;
            }

            return evens.Average();
        }

        public int Factorial(int number)
        {
            // negative factorial should throw ArgumentOutOfRangeException
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Factorial of 0 is 1
            if (number == 0 || number == 1)
            {
                return 1;
            }

            int result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
