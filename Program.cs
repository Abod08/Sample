using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = new List<int> { 4, -2, 10, -7, 15, 60, 25, 31 };

            var positiveNumber = nums.Where(x => x > 0 && x < 20 && x % 2 == 0);

            foreach (var num in positiveNumber)
            {
                System.Console.WriteLine(num);
            }

            var Query = (from num in nums
                        where num > 0 && num < 20 && num % 2 == 0
                        select num).ToList();
                        
            foreach (var num in Query)
            {
                System.Console.WriteLine(num);
            }

        }
    }
}
