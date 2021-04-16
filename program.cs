using System;
using static System.Console;

namespace ControlFlow
{
  class Program
  {
    static void Main(string[] args)
    {

      Random r = new Random();
      int newRandom, counter = 0;

      while (counter < 5)
      {
        /* get a random number between 0 and 99 inclusive */
        newRandom = r.Next(0, 100);

        WriteLine("Random number " + counter + " was " + newRandom);

        /* increment our counter */
        counter += 1;
      }
      ReadLine();
    }
  }
}
