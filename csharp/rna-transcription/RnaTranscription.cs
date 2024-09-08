using System;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide) => 
    nucleotide.Replace('G', 'X').Replace('C', 'G').Replace('X', 'C').Replace('A', 'U').Replace('T', 'A');

}