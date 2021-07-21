using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
  {
    string[] x = n.ToString().Select(ch => Math.Pow(int.Parse(ch.ToString()), 2).ToString()).ToArray();
    return int.Parse(String.Join("", x));
  }
}