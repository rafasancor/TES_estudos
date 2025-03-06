// Escrever um algoritmo que receba a altura e a largura de um retângulo e calcule a sua área.

using System;

public class MedidaArea
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva a altura: ");
        int altura = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escreva a largura: ");
        int largura = Convert.ToInt32(Console.ReadLine());

        int area = altura * largura;
        
        Console.WriteLine("Area: " + area);

    }
}