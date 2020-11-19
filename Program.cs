using System;

namespace arraye
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Array e Vetor"); //Armazena quantas informações que eu precisar

            // //Declarar o tipo do vetor
            // string[] nomes = new string[1000]; //quero armazenar 10 numeros

            // nomes[0] = "Carlos";  // alocando valores
            // nomes[1] = "Joyce";
            // nomes[2] = "Laiane";

            // Console.WriteLine("Nome: "+nomes[1]);


            // int numero = 1;

            // Console.WriteLine($"O valor de variavel numero é de {numero}");

            // int numero = 3;

            // Console.WriteLine($"O valor de variavel numero é de {numero}");

            Console.WriteLine("Digite seu nome: ");
            string[] nomes = new string[10];
            int[] idades = new int[10];

            for (var contador = 0; contador <10; contador++)
            {
                Console.WriteLine($"Digite o {contador+1}ª nome");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                nomes[contador] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Nomes Cadastrados");

            for(var contador = 0; contador <10; contador++){
                Console.WriteLine(+nomes[contador]);
                Console.WriteLine(+idades[contador]);

            } 
           


            
        }
    }
}
