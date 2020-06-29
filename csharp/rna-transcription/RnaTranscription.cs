using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        return nucleotide.ToUpper().Replace("G", "H").Replace("A", "U").Replace("T", "A").Replace("C", "G").Replace("H", "C");
    }
}