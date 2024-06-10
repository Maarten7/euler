using System;

class Program
{
  static void Main()
  {
    for (double d = 1; d < 1000; d++)
    {
      string D = d.ToString();
      int G = D.Length;
      string nine = "9";
      string leeg = "";

      for (int j = 0; j < G; j++)
      {
        leeg += nine;
      }

      double negens = Double.Parse(leeg);

      Console.WriteLine(d / negens);
    }
  }
}

