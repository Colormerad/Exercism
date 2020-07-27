using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {

        var result = new List<int>();
        foreach (var num in multiples.ToList())
        {
            if (num != 0)
            {
                var numbers = Enumerable.Range(num, max)
                            .Where(x => x % num == 0)
                            .Where(x => x < max)
                            .ToList();
                result.AddRange(numbers);
            }          
        }
        return result.Distinct().Sum();        
    }
}
