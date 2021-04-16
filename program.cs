using System;
using static System.Console;

public class Program
{
  public static void Main()
  {
    int[,] twodim = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

    int dim1 = twodim.GetLength(0);
    int dim2 = twodim.GetLength(1);

    for (int i = 0; i < dim1; i++)
    {
      for (int j = 0; j < dim2; j++)
      {
        WriteLine("twodim[{0}, {1}] = {2}", i, j, twodim[i, j]);
      }
    }
  }
}