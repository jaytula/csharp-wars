namespace myjinxin
{
  using System;
  using System.Linq;
  using System.Collections.Generic;

  public class Kata
  {
    public int[] Testit(int[] a, int[] b)
    {
      var ha = new HashSet<int>(a);
      var hb = new HashSet<int>(b);

      var arr1 = ha.ToArray();
      var arr2 = hb.ToArray();

      var result = arr1.Concat(arr2).ToArray();
      Array.Sort(result);
      return result;
    }
  }
}