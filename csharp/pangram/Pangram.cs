﻿using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        return input.ToLower()
            .Where(x => Char.IsLetter(x))
            .GroupBy(x => x)
            .Count() == 26;
    }
}
