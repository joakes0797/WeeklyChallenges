using System;
//using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (letters.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
            // return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = 0;
            foreach (var val in vals)
            {
                count++;
            }
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //if (vals.Length % 2 == 0)
            //{
            //  return true;
            //}
            //else
            //{
            //  return false;
            //}
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            // return (number % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers is null)
            {
                return 0;
            }

            double smallest = 0;
            double biggest = 0;
            double result = 0;

            foreach (var number in numbers)
            {
                smallest = number;
                biggest = number;
            }
            
            foreach (var number in numbers)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
                if (number > biggest)
                {
                    biggest = number;
                }
            }

            result = smallest + biggest;

            return result;
            //using System.Linq;
            //if (numbers is null || numbers.Count() == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //  return numbers.Min() + numbers.Max();
            //}
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var first = str1.Length;
            var second = str2.Length;
            if (first < second)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            //if (str1.Length < str2.Length)
            //{
            //    return str1.Length;
            //}
            //else
            //{
            //    return str2.Length;
            //}
        }

        public int Sum(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum;

            //if (numbers is null)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return numbers.Sum();
            //}
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }

            var myList = new List<int>();
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    myList.Add(num);
                }
            }

            int sum = 0;
            foreach (var num in myList)
            {
                sum += num;
            }

            return sum;

            //return (numbers == null) ? 0 : numbers.Where(x => x % 2 == 0).Sum();            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers is null)
            {
                return false;
            }           
            
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            if (sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            //return (numbers == null) ? false : (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            else if (number % 2 == 0)
            {
                return number / 2;
            }
            else return ((number - 1) / 2);

            //if (number <= 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number / 2;
            //}
        }
    }
}
