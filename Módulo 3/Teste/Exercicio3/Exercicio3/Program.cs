int N, fatorial = 0;
Console.WriteLine("Insira um número inteiro positivo para calcular o fatorial do mesmo");

N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= N; i++)

{

    fatorial = fatorial + N * i;

}

Console.WriteLine("O fatorial de " + N + " é" + fatorial);