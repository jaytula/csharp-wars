using System;

public class Kata
{
    public static string JumpingNumber(int number)
    {
      string s = number.ToString();

      for(int i = 1; i < s.Length; i++) {
        int prev = int.Parse(s[i-1].ToString());
        int curr = int.Parse(s[i].ToString());
        if(Math.Abs(prev-curr) != 1) {
          return "Not!!";
        }
      }
      return "Jumping!!";
    }
}