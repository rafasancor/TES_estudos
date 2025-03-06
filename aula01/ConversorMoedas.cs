using System;

public class ConversorMoedas
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- CONVERSOR DE MOEDAS ---");
        Console.Write("Digite o valor em reais (R$): ");
        
        // Usa double para suportar casas decimais
        double real = Convert.ToDouble(Console.ReadLine());

        // Taxas de câmbio
        double taxaDolar = 5.17;
        double taxaEuro = 6.14;
        double taxaPeso = 0.05;

        // Conversões
        double dolar = real / taxaDolar;
        double euro = real / taxaEuro;
        double peso = real / taxaPeso;

        // Exibe os resultados formatados
        Console.WriteLine($"Valor em Dólar: ${dolar:F2}");
        Console.WriteLine($"Valor em Euro: €{euro:F2}");
        Console.WriteLine($"Valor em Peso Argentino: ${peso:F2}");
    }
}
