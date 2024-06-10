using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
  static int A = 8;
  static int B = A;

  static void Main(string[] args)
  {

    int sCount = DistinctTerms();
    Console.WriteLine("Smart {0}", sCount);


    int bCount = BruteForce();
    Console.WriteLine("BruteForce {0}", bCount);
  }

  static HashSet<int> Divisors(int b)
  {
    HashSet<int> divisors = new HashSet<int>() {};
    if (b == 2) return divisors;
    for (int d = 2; d <= (int)Math.Ceiling(Math.Sqrt(b)); d++)
    {
      if (b % d == 0)
      {
        divisors.Add(d);
        divisors.Add(b / d);
      }
    }
    return divisors;
  }

    
  static int DistinctTerms()
  {
    int terms = 0;
    for (int a = 2; a <= A; a++)
    {
      for (int b = 2; b <= B; b++)
      {
        Console.WriteLine("a={0} b={1} a^b={2}", a, b, Math.Pow(a,b));
        int unique = CountUnique(a, b);
        terms += unique;
        //Console.WriteLine("total={0}\n", terms);
      } 
    }
    return terms;
  }

  static bool RangeCheck(int a, int d)
  {
    double minLimitD = Math.Log(A, 2);
    double minLimitA = Math.Sqrt(A);
  
    if (a > minLimitA || d > minLimitD)
    {
      return false;
    }
    
    int pow = (int)Math.Pow(a, d);
    if (2 <= pow && pow <= A)
    {
      return true;
    }
    return false;
  }

  static int CountUnique(int a, int b, int original = 0)
  {
    int count = 1;
    HashSet<int> divisors =  Divisors(a);
  
    // special case
    if (divisors.Count == 1)
    {
      Console.WriteLine("\t-->Power");
      int d = divisors.First();
      int n = a / d;
      return CountUnique(d, n * b, original: a);
    }

    foreach (int d in Divisors(b))
    {
      if ( original == 0 && RangeCheck(a, d))
      {
        count -= 1;
        Console.WriteLine("\ta={0} d={1} (a^d)^(b/d)={4}\ta^d={3} b/d={5} RangeCheck({3})={2}", a, d, RangeCheck(a,d), Math.Pow(a,d), Math.Pow(Math.Pow(a,d),b/d), b/d);
        Console.WriteLine("\t\tcount-- original=0)");
      }
      if ( original != 0 && Math.Pow(a,d) > original && RangeCheck(a, d))
      {
        Console.WriteLine("\ta={0} d={1} (a^d)^(b/d)={4}\ta^d={3} b/d={5} RangeCheck({3})={2}", a, d, RangeCheck(a,d), Math.Pow(a,d), Math.Pow(Math.Pow(a,d),b/d), b/d);
        Console.WriteLine("\t\tcount-- original!=0 && a>= original)");
        count -= 1;
      }
    }
    Console.WriteLine("\t-->CountUnique()={0}", count);
    return count;
  }
        
  
  static int BruteForce()
  {
    HashSet<long> powers = new HashSet<long>();

    for (int a = 2; a <= A; a++)
    {
      for (int b = 2; b <= B; b++)
      {
        long pow = (long)Math.Pow(a, b);
        if (powers.Contains(pow))
        {
          Console.WriteLine("found bouble {0} {1} {2}", a, b, pow);
        }
        powers.Add(pow);
      }
    }
    return powers.Count;
  }
}


