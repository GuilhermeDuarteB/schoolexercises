
int[,] nAluno = new int[4, 2];

for (int i = 0; i <= nAluno.GetLength(0); i++)
{
    Console.Clear();
    Console.WriteLine("Insira o Numero de Aluno");
    nAluno[i, 0] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira a idade");
    nAluno[i, 1] = Convert.ToInt32(Console.ReadLine());
}
int maioridade =0, Aluno = 0;
for (int i = 0;i < nAluno.GetLength(0); i++)
{
    int idade = nAluno[i, 1];
    if (idade > maioridade)
    {
        maioridade = idade;
        Aluno = nAluno[i, 0];
    }
}
Console.WriteLine("O aluno tem " + maioridade + " e o seu número é " + Aluno);