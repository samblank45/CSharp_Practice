using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    /*  create an array of integer-based test scores */
    /*  NOTE:  array indices start with zero */
    int[] Scores = new int[] { 105, 92, 81, 93, 100 };
    int MyScore;

    /* loop through the following loop 5 times - once for each element of our Scores array */
    for (int i = 4; i >= 0; i--)
    {

      /*  assign the MyScore variable to the i'th element of the Scores array */
      MyScore = Scores[i];

      switch (MyScore)
      {
        case 105:
          WriteLine("Our test score was 105.");
          break;
        case 92:
          WriteLine("Our test score was 92.");
          break;
        case 81:
          WriteLine("Our test score was 81.");
          break;
        default:
          WriteLine("Our test score was not 105, 92 or 81.");
          break;
      }
    }
  }
}
