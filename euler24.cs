using System;

class Program 
{
  static void Main()
  {
    string input = "0123456789";
    string[] z = Permutations(input);
    Array.Sort(z);
    Console.WriteLine(z.Length);
    Console.WriteLine(z[999999]);
  }

  static string[] Permutations(string inString)
  {

    char[] input = inString.ToCharArray();
    //Console.WriteLine("instring[0] {0}", inString[0]);

    int len = input.Length;
    char adder = input[len - 1];

    switch (len)
    {
      case 0:
      case 1:
        return new string[] {inString};

      case 2:
        string e1 = inString[0].ToString() + inString[1].ToString();
        string e2 = inString[1].ToString() + inString[0].ToString();
        return new string[] {e1, e2};

      default:

        // new input, recursive part
        char[] new_input = new char[len - 1];
        for (int i = 0; i < len - 1; i++)
        {
          new_input[i] = input[i];
        }
        System.Console.WriteLine("new input {0}\n", new string(new_input));
        // get all permutations without last element
        string[] recursivePermutations = Permutations(new string(new_input));

      
        // add last element to all permuations
        int newPermutations = recursivePermutations.Length * len;
        //Console.WriteLine("#new permutations {0}", newPermutations);
        //Console.WriteLine("#recursive permutations {0}", recursivePermutations.Length);

        string[] output = new string[newPermutations];

        //Console.WriteLine("len {0}", len);
        int j = 0;
        for (int i = 0; i < recursivePermutations.Length; i++)
        {
          string[] addedPermutations = permutationAdder(adder, recursivePermutations[i]);
          //Console.WriteLine("permutations[{1}] = {0}", new string(recursivePermutations[i]), i);
          foreach (string k in addedPermutations)
          {
            output[j] = k;
            j++;
            //Console.WriteLine("j = {0} -> {1}", j, new string(k)); 
          }
        }
        return output;
    }
  }

  static string[] permutationAdder(char adder, string permutationString)
  {
    char[] permutation = permutationString.ToCharArray();
    int len = permutation.Length;
    //System.Console.Write("--Adder method\n");
    
    string[] output = new string[len + 1];
    for (int i = 0; i < len + 1; i++)
    {
      char[] extra_permutation = new char[len + 1];
      extra_permutation[i] = adder;

      for (int j = 0; j < len + 1; j++)
      {
        if (j < i)
        {
          extra_permutation[j] = permutation[j];
        }
        if (j > i)
        {
          extra_permutation[j] = permutation[j - 1];
        }
      }
      output[i] = new string(extra_permutation);

      //Console.WriteLine("{0}", new string(extra_permutation));
    }
    return output;
  }
}
