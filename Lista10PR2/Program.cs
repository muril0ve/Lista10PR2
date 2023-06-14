using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void Exercicio1()
        {
            
            {
                Console.Write("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                float[] numeros = new float[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write("Digite o número {i + 1}: ");
                    numeros[i] = float.Parse(Console.ReadLine());
                }

                float menor = numeros[0];
                float maior = numeros[0];
                float soma = numeros[0];

                for (int i = 1; i < tamanho; i++)
                {
                    if (numeros[i] < menor)
                        menor = numeros[i];

                    if (numeros[i] > maior)
                        maior = numeros[i];

                    soma += numeros[i];
                }

                float media = soma / tamanho;

                Console.WriteLine("Menor número: " + menor);
                Console.WriteLine("Maior número: " + maior);
                Console.WriteLine("Média: " + media);
            }

        }
        public static void Exercicio2()
        {
            Console.WriteLine("here ex2 will be encoded");
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] numeros = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o número : ");
                numeros[i] = float.Parse(Console.ReadLine());
            }

            float menor = numeros[0];
            float maior = numeros[0];
            float soma = numeros[0];

            for (int i = 1; i < tamanho; i++)
            {
                if (numeros[i] < menor)
                    menor = numeros[i];

                if (numeros[i] > maior)
                    maior = numeros[i];

                soma += numeros[i];
            }



            float media = soma / tamanho;
            Console.WriteLine("média:" + media);

            for (int i = 0; i < tamanho; i++)
            {

                if (numeros[i] >= media)
                {
                    Console.WriteLine("os numeros mairoes q a media: " + numeros[i]);

                }
            }
            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] <= media)
                {
                    Console.WriteLine("os numeros menores q a media: " + numeros[i]);


                }
            }
        }
        public static void Exercicio3()
        {
            Console.WriteLine("here ex3 will be encoded");
            int[] numero;
            int tamanho, soma = 0, media;

            Console.WriteLine("entre com o tamanho: ");
            tamanho = int.Parse(Console.ReadLine());
            numero = new int[tamanho];
            Random rand = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                numero[i] = rand.Next(1, 10000);

            }
            for (int i = 0; i < tamanho; i++)
            {
                soma += numero[i];
            }
            media = soma / tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                if (numero[i] >= media)
                {
                    Console.WriteLine("os numeros maiores ou iguais a media sao: " + numero[i]);
                }
            }
            Console.WriteLine("media= " + media);
        



        }
        public static void Exercicio4()
        {
            Console.WriteLine("here ex4 will be encoded");
            string[] n;
            int tamanho = int.Parse(Console.ReadLine());


            for (int i = 0; i <= 0; i++)
            {
               
                Console.WriteLine("digite as assinaturas:");
                n[i] = Console.ReadLine();            
            }

            for (int i = 0; i < tamanho; i--)
            {
                Console.WriteLine("nomes: " + n[i]);
            }

            

        }
        public static void Exercicio5()
        {
            Console.WriteLine("here ex5 will be encoded");

        }

        static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("=================MENU=================");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para executar o exercício 5 - digite 5");
                Console.WriteLine("para sair digite 0");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank you for using my system!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                }

            } while (option != 0);



        }
    }
}
