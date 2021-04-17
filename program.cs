using System;
using static System.Console;

namespace AllAboutStrings
{

  class Program
  {

    static void Main(string[] args)
    {
      string myName = "sam blank";
      for (int i = 0; i <= myName.Length; i++)
      {
        WriteLine("Character {0} in myName is {1}", i, myName[i]);
      }
    }
  }
}
