using System;
public class Kata
{
  public static int CookingTime(int eggs)
  {
    return 5 * (int) Math.Ceiling(eggs / 8.0);
  }
}