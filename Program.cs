using System;
using System.Collections.Generic;

namespace test3
{
    class Program
    {        
        static void Main(string[] args)
        {
            var a = new List<string>() { "a", "jk", "abb", "mn", "abc", "acgffp", "acgffq" };
            var b = new List<string>() { "bb", "kj", "bbc", "op", "def", "fpcgaf", "fptgaf" };

            var results = getMinimumDifference(a, b);
            
            foreach(var result in results)
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        public static List<int> getMinimumDifference(List<string> a, List<string> b)
    {
        var results = new List<int>();
        var arrayLength = a.Count;
        for(var i = 0; i < arrayLength; i++)
        {
            var currentWordA = a[i];
            var currentWordB = b[i];

            if (currentWordA.Length == currentWordB.Length)
            {   
                var diffLettersA = new HashSet<char>();             
                var diffLettersB = new HashSet<char>();
                var isRemoved = false;
                for(var y = 0; y < currentWordA.Length; y++)
                {
                    if (diffLettersA.Contains(currentWordB[y]))
                    {
                        diffLettersA.Remove(currentWordB[y]);
                        isRemoved = true;                        
                    }

                    if (diffLettersB.Contains(currentWordA[y]))
                    {
                        diffLettersA.Remove(currentWordA[y]);
                        isRemoved = true;                        
                    }

                    if (isRemoved == true)
                    {
                        isRemoved = false;
                        continue;
                    }

                    if (currentWordA[y] != currentWordB[y])
                    {
                        diffLettersA.Add(currentWordA[y]);
                        diffLettersB.Add(currentWordB[y]);
                    }
                }

                Console.WriteLine($"{currentWordA} - {currentWordB} - {diffLettersA.Count}");

                results.Add(diffLettersA.Count);
            }
            else
            {
                Console.WriteLine($"{currentWordA} - {currentWordB} - -1");
                results.Add(-1);
            }            
        }

        return results;
    }
    }
}
