
        int[,] alunos = new int[4, 2];
        for (int i = 0; i < alunos.GetLength(0); i++)
        {
            Console.WriteLine("Qual o numero do aluno ");
            alunos[i, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a sua idade");
            alunos[i, 1] = Convert.ToInt32(Console.ReadLine());
        }
        int maiorIdade = 0;
        int NumeroAluno = 0;
        for (int i = 0; i < alunos.GetLength(0); i++)
        {

            int Idade = alunos[i, 1];
            if (Idade > maiorIdade)
            {
                maiorIdade = Idade;
                NumeroAluno = alunos[i, 0];
            }
        }
        Console.WriteLine("O aluno que tem " + maiorIdade + "e o numero é " + NumeroAluno);