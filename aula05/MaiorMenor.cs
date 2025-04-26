// 2 - Comparação maior menor

Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2) {
    Console.WriteLine(num1 . "é maior que " . num2);
} else if (num2 > num1) {
    Console.WriteLine(num2 . "é maior que " . num1);
} else {
    Console.WriteLine("Os números são iguais");
}