// Passos para resolucao do exercicio
// 1. criar um vetor de 1000 posicoes
// 2. preencher o vetor com valores aleatorios
// 3. imprimir o vetor na tela. 
// 4. ordenar o vetor com Bubble Sort

// criar um vetor de valores inteiros
int[] vetor = new int [10];

// gerar um valor aleatorio
Random r = new Random();
// teste de valor aleatorio - Console.WriteLine(r.Next(10));

// preencher o vetor com valores aleatorios (vetor.Length)
for (int i = 0; i < 10; i++) {
    vetor[i] = r.Next(100);
}

// imprimir o vetor com valores aleatorios
for (int i = 0; i < 10; i++) {
    Console.Write(vetor[i] + " ");
}

// ordernar o vetor com bubble sort 
 for (int i = 0; i < 9; i++) {
    // trocar valores
    if (vetor[i] > vetor[i + 1]) {
        int aux = vetor[i];
        vetor[i] = vetor[i+1];
        vetor[i+1] = aux;
    }
}

Console.Write("\n");
// imprimir o vetor com valores ordenados
for (int i = 0; i < 10; i++) {
    Console.Write(vetor[i] + " ");
}