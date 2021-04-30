using System;

// Questão 3
class MainClass
{
  private static int n;

  public static int getN()
  {
    return n;
  }

  public static void setN(int _n)
  {
    n = _n;
  }

  public static void Main(string[] args) {
    n = int.Parse(Console.ReadLine());

    int [,] arr = new int [n, n];

    for (int i = 0; i < n; i++)
    {
      int j = 0;
      string entrada = Console.ReadLine();
      string [] linha = entrada.Split(' ');
      
      foreach (string valor in linha)
      {
        if (AplicarRestricoes(int.Parse(valor)))
        {
          arr[i, j] = int.Parse(valor);
          j++;
        }
        else
        {
          Console.WriteLine("Erro! Os números informados precisam estar entre -100 e 100.");
          Environment.Exit(0);
        }
      }
    }
    diagonalDifference(arr);

  }

  public static void diagonalDifference(int [,] matriz)
  {
    int somaPrimaria = 0, somaSecundaria = 0, difAbsoluta = 0;

    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if (i == j)
        {
          somaPrimaria += matriz[i,j];
        }
      }
    }

    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < n; j++)
      {
        if ((i + j) == (n - 1))
        {
         somaSecundaria += matriz[i,j];
        }
      }
    }
    difAbsoluta = somaPrimaria - somaSecundaria;

    Console.WriteLine($"{Math.Abs(difAbsoluta)}");

  }

  public static bool AplicarRestricoes(int valor)
  {
    if (valor >= -100 && valor <= 100)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

}
