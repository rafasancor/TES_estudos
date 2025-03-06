// Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.

using System;

public class MaiorNumero
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva o primeiro numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escreva o primeiro numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) {
            Console.WriteLine(num1 + " eh maior que " + num2);
        } else {
            Console.WriteLine(num2 + " eh maior que " + num1);
        }

    }
}
