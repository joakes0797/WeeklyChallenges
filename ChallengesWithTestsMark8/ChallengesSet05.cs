using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var nextNumber = startNumber + 1;
            while(nextNumber % n != 0)
            {
                nextNumber++;
            }
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0)
            {
                return false;
            }

            var x = numbers[0];
            var isLessThan = true;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (x <= numbers[i])
                {
                    x = numbers[i];
                }
                else
                {
                    isLessThan = false;
                }
            }
            return isLessThan;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers is null || numbers.Length == 0)
            {
                return 0;
            }

            var fooList = new List<int>();

            for (var i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    fooList.Add(numbers[i + 1]);
                }
            }
            return fooList.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null || words.Length == 0)
            {
                return "";
            }

            var foo = new List<string>();

            foreach (var word in words)
            {
                if ( word is "" || word is " " || word is "  ")
                {
                    continue;
                }
                else
                {
                    foo.Add(word.Trim());
                }
            }

            if (foo is null || foo.Count == 0)
            {
                return "";
            }

            var bar = "";
            foreach (var word in foo)
            {
                bar += word + " ";
            }

            return bar.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements is null || elements.Count <= 3)
            {
                return new double[] { };
            }

            var foo = new List<double>();

            for (var i = 4; i <= elements.Count; i++)
            {
                if (i % 4 == 0)
                {
                    foo.Add(elements[i-1]);
                }
            }

            return foo.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums is null || nums.Length <= 1)
            {
                return false;
            }

            bool canSum = false;

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        canSum = true;
                    }
                }
            }

            return canSum;
        }
    }
}
