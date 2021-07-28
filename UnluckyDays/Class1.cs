using System;

public class Kata
{
  public static int UnluckyDays(int year)
  {
    int count = 0;

    for (int i = 1; i <= 12; i++)
    {
      DateTime dt = new DateTime(year, i, 13);
      if (dt.DayOfWeek == DayOfWeek.Friday) count++;
    }
    return count;
  }
}