using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int MaxTriSum(int[] a)
  {
    var h = new HashSet<int>(a);
    var arr = h.ToArray();

    Array.Sort(arr);

    if(arr.Length <= 3) return arr.Sum();
    return new List<int>(arr).GetRange(arr.Length - 3, 3).ToArray().Sum();
  }
}