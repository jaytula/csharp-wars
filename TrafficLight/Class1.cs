﻿public class Kata
{
  public static string UpdateLight(string current)
  {
    return current == "green" ? "yellow" : (current == "yellow" ? "red" : "green");
  }
}