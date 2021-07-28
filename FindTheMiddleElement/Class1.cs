using System;
using System.Collections.Generic;
public class Kata
{
  public static int Gimme(double[] inputArray)
  {
    var copiedArray = new List<double>(inputArray).ToArray();
    Array.Sort(copiedArray);

    return Array.IndexOf(inputArray, copiedArray[1]);
  }
}