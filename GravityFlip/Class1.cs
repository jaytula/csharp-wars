﻿using System;
using System.Linq;
public class Kata
{
  public static int[] Flip(char dir, int[] arr)
  {
    Array.Sort(arr);
    return dir == 'R' ? arr : arr.Reverse().ToArray();
  }
}