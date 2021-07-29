using System.Linq;

public class Kata
{
  public static string SpecialNumber(int number)
  {
    var isSpecial = number.ToString().Aggregate(true, (acc, x) => acc && (x >= '0' && x <= '5'));
    return isSpecial ? "Special!!" : "NOT!!";
  }
}