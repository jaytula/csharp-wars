using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
  public static int GetAverage(int[] marks)
  {
    int total = marks.Aggregate(0, (acc, curr) => acc + curr);
    return (int)Math.Floor((double)total / marks.Length);
  }
}