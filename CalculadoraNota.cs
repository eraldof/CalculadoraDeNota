//compila > csc programa.cs

using System;

class CalculadoraNota
{
    static void Main()
    {

        Console.WriteLine("===== Calculadora de Nota =====");

        int saida = 1;

        while (saida == 1)
        {

            Console.Write("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());


            if (nota1 < 0 || nota2 < 0 || nota3 < 0)
            {
                Console.WriteLine("Notas inválidas!!\nTente novamente!");
            }
            else if (nota1 > 10 || nota2 > 10 || nota3 > 10)
            {
                Console.WriteLine("Notas inválidas!!\nTente novamente!");
            }
            else
            {
                double media = (nota1 + nota2 + nota3) / 3;

                if (media >= 7)
                {
                    Console.WriteLine("\nParabéns, você foi aprovado com média {0}! :)\n", media);
                }
                else if (media >= 5 && media < 7)
                {
                    double nota_final = (5-(media*0.6f))/0.4f ;
                    Console.WriteLine("\nVocê ficou com média {0}\nPrecisa tirar no mínimo {1} para ser aprovado!\n", media, Math.Round(nota_final,1));
                }
                else
                {
                    Console.WriteLine("\nVocê foi reprovado! :(\nMédia: {0}\n", media);
                }


                Console.WriteLine("Você deseja continuar calculando? digite 1 para continuar e 0 para sair.");
                saida = int.Parse(Console.ReadLine()); // Critério de Encerramento
                Console.Write("\n\n");
                
                while (saida != 0 && saida != 1) // Insistência de erro
                {
                    Console.WriteLine("Numero inválido! Digite 1 para continuar ou 0 para sair.");
                    saida = int.Parse(Console.ReadLine());
                }
            }

        }
        Console.WriteLine("Até a próxima!");
        Console.WriteLine("Encerrando a calculadora... ");
    } 
}