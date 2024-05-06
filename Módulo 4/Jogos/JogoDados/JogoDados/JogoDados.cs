Menu();

static void Menu()
{
    Console.Clear();
    int opcao = 0;
        Console.WriteLine("Bem-Vindo ao jogo de dados! \n Por favor insira uma das " +
            "opções do que " +
        "pretende fazer \n Iniciar Jogo (1) \n Regras (2) \n Sair (0) ");
        opcao = Convert.ToInt32(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                IniciarJogo();
                break;
            case 2:
                Regras();
                break;
            case 0:
                break;
            default:
                break;
        }
    }

static void Regras()
{
    Console.Clear();
    int opcao;
    Console.WriteLine("Para jogares tens de seguir todas estas regras!");
    Console.WriteLine("1 - Ao iniciar o jogo os nomes dos dois jogadores têm de ser diferentes.");
    Console.WriteLine("2 - O jogo terá várias rodadas e o jogador que tiver o maior número de pontos " +
        "no final será o vencedor!");
    Console.WriteLine("3 - Em caso de empate o jogo continuará até desempatar");
    Console.WriteLine("Agora que sabes as Regras por favor insere a opção que pretendes" +
        " \n Iniciar Jogo (1) \n Voltar ao Menu Inicial (2)");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            IniciarJogo();
            break;
        case 2:
            Menu();
            break;
    }
}
static void IniciarJogo()
{

    Console.Clear();
    string Nome1, Nome2;
    Console.WriteLine("Antes de começarmos é necessário inserir o nome de cada " +
        "um dos jogadores (máximo 2 jogadores)." +
        "\nOs nomes não podem ser idênticos.");
    Console.WriteLine("Inserir o Nome do Primeiro Jogador");
    Nome1 = Console.ReadLine();
    Console.WriteLine("Bem vindo " + Nome1);
    Console.WriteLine("\n");
    Console.WriteLine("Inserir o Nome do Segundo Jogador");
    Nome2 = Console.ReadLine();
    while (Nome2 == Nome1)
    {
        Console.WriteLine("Nome inválido, por favor insira um Nome que não seja igual ao Nome do Jogador 1");
        Nome2 = Console.ReadLine();
    }
    Console.WriteLine("Bem vindo " + Nome2);
    Console.WriteLine("\n");
    ConfigsJogo(Nome1, Nome2);
}



    static void ConfigsJogo(string Nome1, string Nome2)
{
    Console.Clear();
    Console.WriteLine("Agora vamos configurar o jogo!");
        Console.WriteLine("Quem será o primeiro Jogador a lançar o dado?");
        Console.WriteLine(Nome1 + " (1)");
        Console.WriteLine(Nome2 + " (2)");
        Console.WriteLine("Sortear Aleatoriamente (3)");
       int ordem = Convert.ToInt32(Console.ReadLine());
    switch (ordem)
    {
        case 1:
            ordem = 1;
            EscolhaRondas(ordem, Nome1, Nome2);
            break;

            case 2:
            ordem = 2;
            EscolhaRondas(ordem, Nome1, Nome2);
            break;

            case 3:
            ordem = 3;
            EscolhaRondas(ordem, Nome1, Nome2);
            break;
    }
            }


static void EscolhaRondas(int ordem, string Nome1, string Nome2)
{
    Console.Clear();
        Console.WriteLine("Antes de começar o jogo por favor insira abaixo o número de rondas que pretende, escrevendo" +
                " um número de 3 (mínimo) a 5 (máximo) dependendo das rondas que pretende jogar.");
        int rondas = 0;
        rondas = Convert.ToInt32(Console.ReadLine());

    while (rondas != 3 & rondas != 4 & rondas != 5)
    {
            Console.WriteLine("Número inválido de rondas, por favor insira " +
                "um número de rondas sendo o número 3 (minimo) a 5 (máximo). ");
            rondas = Convert.ToInt32(Console.ReadLine());
    }
    Jogo(rondas, ordem, Nome1, Nome2);
}


static void Jogo(int rondas, int ordem, string Nome1, string Nome2)
{

    //Pontuacao
    int PontosP1 = 0;
    int PontosP2 = 0;
    int empates = 0;


    Console.Clear();

    //Jogo Player1
    if (ordem == 1)
    {
        int i1=0;
           while (i1 != rondas)
        {
            //Dado 1
            Random randomp1 = new Random();
            int dadoP1 = randomp1.Next(1, 7);

            //Dado2
            Random RandomP2 = new Random();
            int dadoP2 = RandomP2.Next(1, 7);


            Console.WriteLine(Nome1 + " lançou o dado.");
            Console.WriteLine(Nome1 + " tirou " + dadoP1);
            Console.WriteLine("\n Pressionar qualquer botão para continuar.");
            Console.ReadLine();
            Console.WriteLine(Nome2 + " lançou o dado.");
            Console.WriteLine(Nome2 + " tirou " + dadoP2);
            Console.WriteLine("\n Pressionar qualquer botão para continuar.");
            Console.ReadLine();



            if (dadoP1 > dadoP2)
            {
               PontosP1 = Dado1Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
            }

            if (dadoP2 > dadoP1)
            {
                PontosP2 = Dado2Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
            }

            if (dadoP1 == dadoP2)
            {
                Console.WriteLine("Ambos os dados foram iguais por isso nenhum dos jogadores pontuou.");
                empates = empates + 1;
                i1 = i1 - 1;
            }
            Console.Clear();
            i1 = i1 +1;
        }
       if (PontosP1 > PontosP2)
        {
            P1Wins(Nome1,Nome2,PontosP1,PontosP2,empates);
        }

        if (PontosP2 > PontosP1)
        {
            P2Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
        }
        Console.WriteLine("Aperte qualquer tecla para continuar.");
        Console.ReadLine();
        Console.Clear();
        FimJogo();
    }

    //Jogo Player2

    if (ordem == 2)
    {
        int i2 = 0;
        while (i2 != rondas)
        {
            //Dado 1
            Random randomp1 = new Random();
            int dadoP1 = randomp1.Next(1, 7);

            //Dado2
            Random RandomP2 = new Random();
            int dadoP2 = RandomP2.Next(1, 7);


            Console.WriteLine(Nome2 + " lançou o dado.");
            Console.WriteLine(Nome2 + " tirou " + dadoP2);
            Console.WriteLine("\n Pressionar qualquer botão para continuar.");
            Console.ReadLine();
            Console.WriteLine(Nome1 + " lançou o dado.");
            Console.WriteLine(Nome1 + " tirou " + dadoP1);
            Console.WriteLine("\n Pressionar qualquer botão para continuar.");
            Console.ReadLine();

            
            if (dadoP1 > dadoP2)
            {
               PontosP1= Dado1Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
            }

            if (dadoP2 > dadoP1)
            {
                PontosP2 = Dado2Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
            }

            if (dadoP1 == dadoP2)
            {
                Console.WriteLine("Ambos os dados foram iguais por isso nenhum dos jogadores pontuou.");
                empates = empates + 1;
                i2 = i2 - 1;
            }
            Console.Clear();
            i2 = i2 + 1;
        }
        if (PontosP1 > PontosP2)
        {
            P1Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
        }

        if (PontosP2 > PontosP1)
        {
            P2Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
        }
        Console.WriteLine("Aperte qualquer tecla para continuar.");
        Console.ReadLine();
        Console.Clear();
        FimJogo();
    }

    //Jogo PlayersAleatorios

    if (ordem == 3)
    {
        //Sorteio Nomes
        Random random = new Random();
        int SNomes = random.Next(1,3);
        
        if (SNomes == 1)
        {
            int i3 = 0;
            while (i3 != rondas)
            {
                //Dado 1
                Random randomp1 = new Random();
                int dadoP1 = randomp1.Next(1, 7);

                //Dado2
                Random RandomP2 = new Random();
                int dadoP2 = RandomP2.Next(1, 7);


                Console.WriteLine(Nome1 + " lançou o dado.");
                Console.WriteLine(Nome1 + " tirou " + dadoP1);
                Console.WriteLine("\n Pressionar qualquer botão para continuar.");
                Console.ReadLine();
                Console.WriteLine(Nome2 + " lançou o dado.");
                Console.WriteLine(Nome2 + " tirou " + dadoP2);
                Console.WriteLine("\n Pressionar qualquer botão para continuar.");
                Console.ReadLine();

                if (dadoP1 > dadoP2)
                {
                   PontosP1= Dado1Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
                }

                if (dadoP2 > dadoP1)
                {
                  PontosP2=  Dado2Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
                }

                if (dadoP1 == dadoP2)
                {
                    Console.WriteLine("Ambos os dados foram iguais por isso nenhum dos jogadores pontuou.");
                    empates = empates + 1;
                    i3 = i3 - 1;
                }
                Console.Clear();
                i3 = i3 + 1;
            }
            if (PontosP1 > PontosP2)
            {
                P1Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
            }

            if (PontosP2 > PontosP1)
            {
                P2Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
            }
            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            FimJogo();
        }

        else if (SNomes == 2)
        {
            int i4 = 0;
            while (i4 != rondas)
            {
                //Dado 1
                Random randomp1 = new Random();
                int dadoP1 = randomp1.Next(1, 7);

                //Dado2
                Random RandomP2 = new Random();
                int dadoP2 = RandomP2.Next(1, 7);


                Console.WriteLine(Nome2 + " lançou o dado.");
                Console.WriteLine(Nome2 + " tirou " + dadoP2);
                Console.WriteLine("\n Pressionar qualquer botão para continuar.");
                Console.ReadLine();
                Console.WriteLine(Nome1 + " lançou o dado.");
                Console.WriteLine(Nome1 + " tirou " + dadoP1);
                Console.WriteLine("\n Pressionar qualquer botão para continuar.");
                Console.ReadLine();


                if (dadoP1 > dadoP2)
                {
                 PontosP1 =  Dado1Wins(Nome1,PontosP1,Nome2,PontosP2,empates);
                }

                if (dadoP2 > dadoP1)
                {
                   PontosP2 = Dado2Wins(Nome1, PontosP1, Nome2, PontosP2, empates);
                }

                if (dadoP1 == dadoP2)
                {
                    Console.WriteLine("Ambos os dados foram iguais por isso nenhum dos jogadores pontuou.");
                    empates = empates + 1;
                    i4 = i4 - 1;
                }
                Console.Clear();
                i4 = i4 + 1;
            }
            if (PontosP1 > PontosP2)
            {
                P1Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
            }

            if (PontosP2 > PontosP1)
            {
                P2Wins(Nome1, Nome2, PontosP1, PontosP2, empates);
            }
            Console.WriteLine("Aperte qualquer tecla para continuar.");
            Console.ReadLine();
            Console.Clear();
            FimJogo();
        }
    }
}

static void P1Wins(string Nome1, string Nome2, int PontosP1, int PontosP2, int empates)
{
    Console.WriteLine("Parabéns, o Jogador " + Nome1 + " venceu o jogo!");
    Console.WriteLine("Pontuação Final:");
    Console.WriteLine(Nome1 + " " + PontosP1);
    Console.WriteLine(Nome2 + " " + PontosP2);
    Console.WriteLine("Empates: " + empates);
}

static void P2Wins(string Nome1, string Nome2, int PontosP1, int PontosP2, int empates)
{
    Console.WriteLine("Parabéns, o Jogador " + Nome2 + " venceu o jogo!");
    Console.WriteLine("Pontuação Final:");
    Console.WriteLine(Nome1 + " " + PontosP1);
    Console.WriteLine(Nome2 + " " + PontosP2);
    Console.WriteLine("Empates: " + empates);
}

static int Dado1Wins(string Nome1, int PontosP1, string Nome2, int PontosP2, int empates)
{
    Console.WriteLine("O " + Nome1 + " recebeu 1 ponto! \n ");
    PontosP1 = PontosP1 + 1;
    Console.WriteLine("Pontuação Atual: \n" + Nome1 + ":" + PontosP1);
    Console.WriteLine(Nome2 + ":" + PontosP2);
    Console.WriteLine("Empates: " + empates);
    return PontosP1;
}

static int Dado2Wins(string Nome1, int PontosP1, string Nome2, int PontosP2, int empates)
{
    Console.WriteLine("O " + Nome2 + " recebeu 1 ponto! \n ");
    PontosP2 = PontosP2 + 1;
    Console.WriteLine("Pontuação Atual: \n" + Nome1 + ":" + PontosP1);
    Console.WriteLine(Nome2 + ":" + PontosP2);
    Console.WriteLine("Empates: " + empates);
    return PontosP2;
}

static void FimJogo()
{
    Console.WriteLine("Agora após o jogo o que pretende fazer?");
    Console.WriteLine(" Voltar ao Menu Inicial (1) \n Recomeçar o Jogo (2) \n Sair do Jogo (0)");
    int escolhafinal = Convert.ToInt32(Console.ReadLine());
    switch (escolhafinal)
    {
        case 1:
            Menu();
            break;
        case 2:
            IniciarJogo();
            break;
        case 0:
            break;
    }
}
