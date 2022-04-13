using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);

            //if (vals.Contains(false))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers is null)
            {
                return false;
            }
            var odds = new List<int>();
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            var x = odds.Sum();
            
            return x % 2 != 0;

            //if (x % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            var abc2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";
            bool isFirstContained = false;
            bool isSecondContained = false;
            bool isThirdContained = false;
            foreach (var x in password)
            {
                if (abc.Contains(x))
                {
                    isFirstContained = true;
                }
                if (abc2.Contains(x))
                {
                    isSecondContained = true;
                }
                if (numbers.Contains(x))
                {
                    isThirdContained = true;
                }
            }

            return isFirstContained && isSecondContained && isThirdContained;

            //if (isFirstContained && isSecondContained && isThirdContained)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public char GetFirstLetterOfString(string val)
        {
            //var x = val.First();
            //return x;
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            //var x = val.Reverse().First();
            //return x;
            return val.Reverse().First();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return divisor;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            //var a = nums.First();
            //var b = nums.Last();
            //return b - a;
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
