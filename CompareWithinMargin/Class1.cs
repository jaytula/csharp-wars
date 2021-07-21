using System;

public class Kata
{
  public static int CloseCompare(double a, double b, double margin = 0)
  {
    double difference = a - b;

    if(Math.Abs(difference) <= margin) return 0;
    return difference < 0 ? -1 : 1;
  }
}