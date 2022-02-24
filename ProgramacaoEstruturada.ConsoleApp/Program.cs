using System;

namespace ProgramacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] armazena_valor = new int[9];

            for (int i = 0; i < armazena_valor.Length; i++)
            {
                Console.WriteLine("Informe o valor, posição " + i + ":");
                armazena_valor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nInforme o valor que deseja remover: ");
            int remove_valor = Convert.ToInt32(Console.ReadLine());

            int maior_valor = Apresenta_maior_valor(ref armazena_valor);

            int menor_valor = Apresenta_menor_valor(armazena_valor);

            decimal media = Calcula_media(armazena_valor);

            int[] tres_maiores = Apresenta_maiores_valores(armazena_valor);

            int[] valor_negativo = Apresenta_valor_negativo(armazena_valor);

            Remove_valor(ref armazena_valor, remove_valor);


            Imprimir("\nO maior valor é: " + maior_valor);
            Imprimir("O menor valor é: " + menor_valor);
            Imprimir("A média é: " + media);
            Imprimir("Os três maiores valores são: " + string.Join(" ,", tres_maiores));
            Imprimir("Valor(es) negativo(s): " + string.Join(" ,", valor_negativo));
            Imprimir("Sequência: " + string.Join(" ,", armazena_valor) + "\n");

            static void Imprimir(string mensagem)
            {
                Console.WriteLine(mensagem);
            }
            Console.ReadLine();
        }

        static int Apresenta_maior_valor(ref int[] armazena_valor)
        {
            int maior_valor = int.MinValue;

            for (int i = 0; i < armazena_valor.Length; i++)
            {
                if (armazena_valor[i] > maior_valor)
                {
                    maior_valor = armazena_valor[i];
                }
            }
            return maior_valor;
        }

        static int Apresenta_menor_valor(int[] armazena_valor)
        {
            int menor_valor = int.MaxValue;

            for (int i = 0; i < armazena_valor.Length; i++)
            {
                if (armazena_valor[i] < menor_valor)
                {
                    menor_valor = armazena_valor[i];
                }
            }
            return menor_valor;
        }

        static decimal Calcula_media(int[] armazena_valor)
        {
            decimal total = 0;

            for (int i = 0; i < armazena_valor.Length; i++)
            {
                total += armazena_valor[i];
            }

            decimal media = total / armazena_valor.Length;
            return media;
        }

        static int[] Apresenta_maiores_valores(int[] armazena_valor)
        {
            Array.Sort(armazena_valor);

            Array.Reverse(armazena_valor);

            int[] tres_maiores = new int[3];

            for (int i = 0; i < tres_maiores.Length; i++)
            {
                tres_maiores[i] = armazena_valor[i];
            }
            return tres_maiores;
        }

        static int[] Apresenta_valor_negativo(int[] armazena_valor)
        {
            int quantidade_negativos = 0;

            for (int i = 0; i < armazena_valor.Length; i++)
            {
                if (armazena_valor[i] < 0)
                {
                    quantidade_negativos++;
                }
            }

            int[] valor_negativo = new int[quantidade_negativos];
            int j = 0;

            for (int i = 0; i < valor_negativo.Length; i++)
            {
                if (armazena_valor[i] < 0)
                {
                    valor_negativo[j] = armazena_valor[i];
                    j++;
                }
            }
            return valor_negativo;
        }

        static void Remove_valor(ref int[] armazena_valor, int remove_valor)
        {
            int quantidade_remover = 0;

            for (int i = 0; i < armazena_valor.Length; i++)
            {
                if (armazena_valor[i] == remove_valor)
                {
                    quantidade_remover++;
                }
            }

            int[] nova_sequencia = new int[armazena_valor.Length - quantidade_remover];

            int j = 0;

            for (int i = 0; i < nova_sequencia.Length; i++)
            {
                if (armazena_valor[i] != remove_valor)
                {
                    nova_sequencia[j] = armazena_valor[i];
                    j++;
                }
            }
            armazena_valor = nova_sequencia;
        }
    }
}
