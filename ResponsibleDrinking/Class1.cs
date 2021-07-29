using System.Text.RegularExpressions;

public class Drinkin
{
  public string hydrate(string drinkString)
  {
    Regex regex = new Regex(@"\b([0-9])\b");
    MatchCollection matches = regex.Matches(drinkString);
    int result = 0;

    for (int ctr = 0; ctr < matches.Count; ctr++)
    {
      result += int.Parse(matches[ctr].Value);
    }

    return $"{result} glass{(result > 1 ? "es" : "")} of water";
  }
}