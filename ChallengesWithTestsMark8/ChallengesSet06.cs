using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            bool doesContain = false;

            if (ignoreCase == true)
            {
                //change words casing to lower
                foreach (var x in words)
                {
                    if (x is null)
                    {
                        continue;
                    }
                    if (x.ToLower() == word)
                    {
                        doesContain = true;
                    }
                }
            }
            else
            {
                //match by exact case
                foreach (var x in words)
                {
                    if (x == word)
                    {
                        doesContain = true;
                    }
                }
            }

            return doesContain;
        }

        public bool IsPrimeNumber(int num)
        {
            //a prime is a whole number greater than one that can only be divided by itself and one
            if (num <= 0)
            {
                return false;
            }

            bool isPrime = false;
            var foo = 0;
                        
            for (var i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    foo++;
                }
            }

            if (foo == 2)
            {
                isPrime = true;
            }

            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //if (str.Length == 0)
            //{
            //    return -1;
            //}

            // Distinct:  gets all distinct elements in the string
            // Reverse:   work backwards from the original ending of the string
            // Where:     only look for elements where the count of the letter is exactly 1
            // First or Default:  get the first element that meets the criteria, or
            //                    return 0 if there are no results that meet the criteria

            return str.IndexOf(
                        str.Distinct()
                           .Reverse()
                           .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                           .FirstOrDefault());

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var totalCount = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var currentCount = 1;  //every time i changes, reset the current count to 1

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])  //if i and j match, increment the current count
                    {
                        break;      //if i and j don't match, don't increment the current count
                    }
                    
                    currentCount++;
                }

                if (currentCount > totalCount)
                {
                    totalCount = currentCount;
                }
            }
            
            return totalCount;


            // make a dictionary

            //var counts = new Dictionary<int, int>();
            //foreach (int number in numbers)
            //{
            //    int count;
            //    counts.TryGetValue(number, out count);
            //    count++;
            //    counts[number] = count;
            //}
            //int mostCommonNumber = 0, occurrences = 0;
            //foreach (var pair in counts)
            //{
            //    if (pair.Value > occurrences)
            //    {
            //        occurrences = pair.Value;
            //        mostCommonNumber = pair.Key;
            //    }
            //}
            ////Console.WriteLine("The most common number is {0} and it appears {1} times", mostCommonNumber, occurrences);
            //return mostCommonNumber;

            // at this point, we know the mostCommonNumber.  now we need to know how many times it appears consecutively

            //int x = mostCommonNumber;
            //var count2 = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (x == numbers[i] && numbers[i] == numbers[i + 1])
            //    {
            //        count2++;
            //    }                
            //}
            //return count2;

                //  from a Codewars solution
                //        {
                //            public static int find_it(int[] seq)
                //            {
                //                var counts = new Dictionary<int, int>();
                //                foreach (int number in seq)
                //                {
                //                    int count;
                //                    counts.TryGetValue(number, out count);
                //                    count++;
                //                    counts[number] = count;
                //                }
                //                int leastCommonNumber = 0;
                //                foreach (var pair in counts)
                //                {
                //                    if (pair.Value % 2 != 0)
                //                    {
                //                        leastCommonNumber = pair.Key;
                //                    }
                //                }
                //                return leastCommonNumber;
                //            }
                //        }

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements is null || elements.Count == 0 || n < 0 || n > elements.Count)
            {
                return new double[] { };
            }

            var nList = new List<double>();
            for (var i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nList.Add(elements[i]);
                }       
            }

            return nList.ToArray();
        }
    }
}
