using System;
using System.Text;

public class Kata
{
  public static string Speedify(string input)
  {
    var sb = new StringBuilder();

    for (int i = 0; i < input.Length; i++)
    {
      var ch = input[i];
      var offset = input[i] - 'A';
      if (sb.Length < offset + i + 1)
      {
        sb.Append(' ', i + offset - sb.Length);
        sb.Append(ch);
      }
      else
      {
        sb[offset + i] = ch;
      }
    }

    return sb.ToString();
  }
}