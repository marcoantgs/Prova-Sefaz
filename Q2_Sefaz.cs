using System;

// Questão 2
class MainClass {
  public static void Main (string[] args) {

    while (true){
      Console.Write("Insira o nome do arquivo a ser lido: ");
      string nomeArquivo = Console.ReadLine();

      if (System.IO.File.Exists(nomeArquivo + ".txt"))
      {
        try
        {
          string[] linhas = System.IO.File.ReadAllLines(nomeArquivo + ".txt");

          Console.WriteLine();
          Console.WriteLine("Leitura efetuada!");

          Console.Write("Insira o nome do arquivo a ser gerado: ");
          string novoArquivo = Console.ReadLine();

          GerarArquivo(linhas, novoArquivo);
        }
        catch (System.IO.IOException e)
        {
          Console.WriteLine(e.Message);
          return;
        }
        break;
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("Este arquivo não existe!");
      }

    }
  
  }

  public static void GerarArquivo(string[] linhasArquivo, string novoArquivo)
  {
    int id = 1;

    using (System.IO.StreamWriter file = new System.IO.StreamWriter(novoArquivo + ".txt"))
    {
      foreach (string linha in linhasArquivo)
      {
        file.WriteLine("INSERT INTO Questao_2(dsc_obs) VALUES(‘{0}’) WHERE (id_questao_2) = {1}", linha, id);
        id += 2;
      }
    }

    Console.WriteLine();
    Console.WriteLine("Arquivo gerado! Fim da execução!");
  }

}
