using System.Text.RegularExpressions;

namespace Solution
{
  public static class Solution
  {
    public static bool Solve(string a, string b)
    {
      Regex rx = new Regex("^" + a.Replace("*", ".*") + "$");
      return rx.Match(b).Success;
    }
  }
}