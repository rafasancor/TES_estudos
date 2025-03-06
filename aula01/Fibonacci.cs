// Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.

using System;

class Fibonacci
{
    static void Main()
    {
        // Solicita ao usuário o valor para até onde deve imprimir a sequência Fibonacci
        Console.Write("Digite um número inteiro positivo: ");
        int n = int.Parse(Console.ReadLine());

        // Verifica se o número é válido (positivo)
        if (n <= 0)
        {
            Console.WriteLine("Por favor, insira um número positivo.");
            return;
        }

        // Inicializa os dois primeiros números da sequência Fibonacci
        int a = 0, b = 1;

        // Imprime o primeiro número (0) caso o número seja maior que 0
        if (n >= 0)
        {
            Console.Write(a);
        }

        // Imprime os números seguintes da sequência até o número informado
        while (b <= n)
        {
            Console.Write(", " + b);
            int temp = b;
            b = a + b;  // Próximo número da sequência
            a = temp;   // Atualiza o número anterior
        }

        Console.WriteLine(); // Finaliza com uma linha em branco
    }
}
