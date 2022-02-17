using System;
   
 namespace Repetindo_Operacoes_Com_ForEach
 {
   class Program
    {
      static void Main(string[] args)
      {
        string[] nomes = { "Paulo", "Ana", "Felipe", "Laura" };           
          int x = 0;
            foreach (string nome in nomes)
              {
                x++; 
                Console.WriteLine($"O nome do {x}º aluno é {nome}.");
              }
            Console.ReadLine(); //O ReadLine é apenas p/ parar o console e verificar o resultado
      }
    }
  }