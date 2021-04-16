using System;

namespace VariableDefinition
{
  class Program
  {
    static void Main(string[] args)
    {
      /* variable initialization */
      int a = 10, b = 20, c0, c1;
      double c2, c3, c4, c5;
      string person;

      /* variable reassignment */
      c0 = b + a; /* {0} */
      c1 = b - a; /* {1} */
      c2 = b / a; /* {2} */
      c3 = b * a; /* {3} */
      c4 = b % a; /* {4} */
      c5 = Math.Pow(b, a);  /* {5} */
      person = "rick";  /* {6} */

      /* 0,1,2 are elements - think of it as indexes */
      Console.WriteLine("b + a = {0}, b - a = {1}, b / a = {2}, b*a={3}, b%a={4}" + "Math.pow(b,a)={5}, person = {6}", c0, c1, c2, c3, c4, c5, person);
    }
  }

}