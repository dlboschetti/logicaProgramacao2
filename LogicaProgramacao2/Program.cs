using System;

namespace LogicaProgramacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura de dados
            //pilha - Last In, First out (LIFO)
            //fila - First In, First Out (FIFO)
            //lista - Lista não organizada

            int[] numeros = new int[10];

            // Estrutura de atribuicao de dados

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
            }


            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            // Fila
            //int[] numeros = new int[5];
            //    numeros[3] = 1;
            //    numeros[4] = 10;
            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);


            ////Estrutura de Repetição    
            //int resposta = 0;
            //int erro = 0;
            //int count = 1;


            //while (resposta != 2)
            //{
            //    if (count >= 2)
            //        erro++;

            //    Console.WriteLine("Qual o nome do presidente atual do Brasil? ");
            //    Console.WriteLine("1-Fernando Henrique Cardoso.");
            //    Console.WriteLine("2-Jair Bolsonaro.");
            //    Console.WriteLine("3-Lula.");
            //    Console.WriteLine("4-Trancredo Neves.");
            //    Console.WriteLine("5-Dilma");
            //    Console.WriteLine("6-Castelo Branco");
            //    Console.WriteLine("7-Sarney");
            //    Console.WriteLine("8-Michel Temer");

            //    resposta = Convert.ToInt32(Console.ReadLine());

            //    count++;
            //}

            //double nota = 10;
            //if (erro != 0)
            //    nota = nota / erro;

            //Console.WriteLine($"VENCEU! Sua nota é: {nota}");

            //int resposta = Convert.ToInt32(Console.ReadLine());

            //if (resposta == 2)
            //{
            //    Console.WriteLine("Venceu!");
            //}
            //else
            //{
            //    Console.WriteLine("Perdeu!");
            //}


            //Console.WriteLine("Digite o numero inicial: ");
            //int inicial = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o numero final: ");
            //int final = Convert.ToInt32(Console.ReadLine());

            //if (final <=inicial)
            //{
            //    Console.WriteLine("Erro: O numero FINAL não pode ser menor que o INICIAL. ");
            //}
            //else
            //{
            //    Console.WriteLine("Numeros impares(I) ou numeros pares(P)");
            //    string tipo = Console.ReadLine();

            //    switch (tipo.ToLower())
            //    {
            //        case "p":
            //            for (int i = inicial; i < final; i++)
            //            {
            //                if (i % 2 ==0)
            //                    Console.WriteLine(i);
            //            }
            //            break;

            //        case "i":
            //            for (int i = inicial; i < final; i++)
            //            {
            //                if (i % 2 == 1)
            //                    Console.WriteLine(i);
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Vc não digitou o tipo do numero correto!");
            //            break;
            //    }
            //}
            //int numero = 1;

            //while(numero % 2 ==1)
            //{
            //    Console.WriteLine("Digite um numero par: ");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Obrigado por digitar o numero par!"); 

            // FOR
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}



            //while

            //int inteiro= 0;
            //while (inteiro<10)
            //{
            //    Console.WriteLine(inteiro);
            //    inteiro = inteiro + 1;
            //}
        }
    }
}
