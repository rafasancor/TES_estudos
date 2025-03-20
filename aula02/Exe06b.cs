// Passos para resolucao do exercicio
// 1. criar um vetor de 1000 posicoes
// 2. preencher o vetor com valores aleatorios
// 3. imprimir o vetor na tela. 
// 4. ordenar o vetor com Bubble Sort

// criar um vetor de valores inteiros
int[] vetor = new int[10];
int i;

Random r = new Random();

// preencher o vetor com valores aleatorios
for (i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(100);
}

// imprimir o vetor com valores aleatorios
for (i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

// ordernar o vetor com bubble sort
Array.Sort(vetor);

Console.Write("\n");
// imprimir o vetor com valores ordenados
for (i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}