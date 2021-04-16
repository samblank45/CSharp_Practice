using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace ControlFlow
{
  class Program
  {
    static void Main(string[] args)
    {
      WriteLine("if statement example.");
      Write("Enter a character: ");

      /* cast the unspecified input datatype to a character datatype */
      char inputChar = System.Convert.ToChar(ReadLine());
      char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

      /* switch is comparable to if ... else if ... else */
      switch (inputChar)
      {
        case 'a':
          WriteLine("The input character was an a.");
          break;

        case 'e':
          WriteLine("The input character was an e.");
          break;

        case 'i':
          WriteLine("The input character was an i.");
          break;

        case 'o':
          WriteLine("The input character was an o.");
          break;

        case 'u':
          WriteLine("The input character was a u.");
          break;

        default:
          WriteLine("The input character was not a vowel.");
          break;
      }
    }
  }
}
