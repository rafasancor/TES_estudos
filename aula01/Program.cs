using System;

class Program
{
    // Função para implementar o algoritmo Bubble Sort
    static void BubbleSort(int[] array)
    {
        int n = array.Length;

        // Loop externo: percorre o vetor várias vezes
        for (int i = 0; i < n - 1; i++)
        {
            // Loop interno: compara elementos adjacentes
            for (int j = 0; j < n - i - 1; j++)
            {
                // Se o elemento atual for maior que o próximo, troque-os
                if (array[j] > array[j + 1])
                {
                    // Troca de valores
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        // Cria um vetor com 1000 elementos
        int[] valores = new int[1000];

        // Preenche o vetor com números aleatórios entre 1 e 10000
        Random rand = new Random();
        for (int i = 0; i < valores.Length; i++)
        {
            valores[i] = rand.Next(1, 10001); // Gera números de 1 a 10000
        }

        // Chama a função BubbleSort para ordenar os números
        BubbleSort(valores);

        // Imprime os valores ordenados
        Console.WriteLine("Valores ordenados:");
        for (int i = 0; i < 100; i++)  // Vamos mostrar só os primeiros 100 para não sobrecarregar a tela
        {
            Console.Write(valores[i] + " ");
        }
        Console.WriteLine(); // Nova linha no final
    }
}
