using System;
using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] n)
  {
    return (int)n.Aggregate(0, (acc, x) => acc + (int)Math.Pow((int)x, 2));
  }
}