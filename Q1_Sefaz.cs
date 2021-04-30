using System;
using System.Collections.Generic;

// Questão 1
class MainClass {
  public static void Main (string[] args) {
    
    List<float> q = new List<float> { 0.5f, 1.0f, 1.5f, 2.0f };  
    List<int> g = new List<int>{ 0, 1, 0, 1 };

    CorrigirProva(q, g);
  }

  public static void CorrigirProva(List<float> questoes, List<int> gabarito)
  {
    float total = 0.0f;
    int numQuestao = 0;

    Console.WriteLine("Correção da prova:");

    for (int i = 0; i < gabarito.Count; i++)
    {
    	numQuestao = i + 1;

	    if (gabarito[i] == 0)
      {
        Console.WriteLine("A questão {0} está errada.", numQuestao);
      }
      else if (gabarito[i] == 1)
      {
        total += questoes[i];
        Console.WriteLine("A questão {0} está certa.", numQuestao); 
      }
    }
    Console.WriteLine();
    Console.WriteLine("Nota total da prova: {0}", total);

  }

}
