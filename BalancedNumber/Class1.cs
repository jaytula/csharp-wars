using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static string BalancedNumber(int number)
  {
    int[] numberArr = number.ToString().Select(ch => int.Parse(ch.ToString())).ToArray();
    List<int> numberList = new List<int>(numberArr);

    int midIndex = (int)Math.Floor((double)numberList.Count / 2);
    if (numberList.Count % 2 == 0)
    {
      numberList.RemoveAt(midIndex - 1);
      numberList.RemoveAt(midIndex - 1);
    }
    else
    {
      numberList.RemoveAt(midIndex);
    }

    int leftSideSum = numberList.Skip(0).Take(numberList.Count / 2).Aggregate(0, (acc, value) => acc + value);
    int rightSideSum = numberList.Skip(0).Skip(numberList.Count / 2).Aggregate(0, (acc, value) => acc + value);

    return leftSideSum == rightSideSum ? "Balanced" : "Not Balanced";
  }
}