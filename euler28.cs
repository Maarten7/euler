using System;
class Program
{
  static void Main()
  {
    Console.WriteLine(sumDiagonal(1001));
  }


  static int sumEdges(int n)
  {
    int e0 = n*n;
    int e1 = n*n - 1 * (n - 1);
    int e2 = n*n - 2 * (n - 1);
    int e3 = n*n - 3 * (n - 1);
    return e0 + e1 + e2 + e3;
  }

  static int sumDiagonal(int n)
  {
    switch (n)
    {
      case 1:
        return 1;
      default:
        return sumEdges(n) + sumDiagonal(n - 2);
    }
  }

}

