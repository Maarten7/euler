using System;
using System.Collections.Generic;
using Con = System.Console;

class Program
{
  static void Main()
  {
    //Con.WriteLine(Range(1, 41));
    //Con.WriteLine(Range(-999, 61));
    Console.WriteLine(Search());
  }

  static int Search()
  {
    int maxRange = 0;
    int maxA = -999;
    int maxB = -1000;
    int range;
    for (int a = -999; a < 1000; a++ )
    {
      for (int b = -1000; b <= 1000; b++)
      {
        range = Range(a, b);
        if (range > 900)
        {
          Con.WriteLine("{0} {1} {2}", a, b, range);
        }
        if (range > maxRange)
        {
          maxRange = range;
          maxA = a;
          maxB = b;
        }
      }
    }
    Con.WriteLine("ma {0} mb {1} mr{2}", maxA, maxB, maxRange);
    return maxA * maxB;
  }


  static int Range(int a, int b)
  {
    if (!IsPrime(b))
    {
      return 0;
    }
    int n = 0;
    bool holding = true;
    int pq;
    while (holding)
    {
      pq = Formula(n, a, b);
      //Con.WriteLine("{0} {1}", n, pq);
      holding = IsPrime(pq);
      n++;
    }
    return --n;
  }

  static int Formula(int n, int a = 1, int b = 41)
  {
    return n*n + a*n + b;
  }

  static bool IsPrime(int a)
  {
    if (a < 2)
    {
      return false;
    }

    int stop = (int)Math.Ceiling(Math.Sqrt(a));
    foreach (int p in primes(stop:stop))
    {
      //Con.WriteLine("{0} {1} {2}", a, stop, p);
      if (a % p == 0)
      {
        return false;
      }
    }
    return true;
  }

  static IEnumerable<int> primes(int stop = 1000)
  {
    List<int> primes = new List<int>() {2, 3, 5}; 
    yield return 2;
    yield return 3;
    yield return 5;
    int i = 7;
    while (i <= stop)
    {
      bool isPrime = true;
      foreach (int prime in primes)
      {
        if (i % prime == 0)
        {
          isPrime = false;
          break;
        }
      }
      if (isPrime)
      {
        yield return i;
        primes.Add(i);
      }
      i += 2;
    }
  }
}
