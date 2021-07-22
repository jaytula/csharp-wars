using System;

public class Dinglemouse
{
  public static int[] humanYearsCatYearsDogYears(int humanYears)
  {
    int catYears = (humanYears == 1 ? 15 : 24) + Math.Max(humanYears - 2, 0) * 4;
    int dogYears = (humanYears == 1 ? 15 : 24) + Math.Max(humanYears - 2, 0) * 5;

    return new int[] { humanYears, catYears, dogYears };
  }

}