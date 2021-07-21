using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
  public class Digitizer
  {
    public static long[] Digitize(long n)
    {
      long[] arr = n.ToString().Select(s => long.Parse(s.ToString())).ToArray();
      Array.Reverse(arr);
      return arr;
    }
  }
}