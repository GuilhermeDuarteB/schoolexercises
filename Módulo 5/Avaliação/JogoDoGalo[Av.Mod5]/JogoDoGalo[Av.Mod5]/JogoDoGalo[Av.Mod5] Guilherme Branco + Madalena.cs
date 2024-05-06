using System;

class Program
{
    static char[,] tabuleiro = new char[3, 3]; // Matriz 3x3 para representar o tabuleiro
    static char jogadorAtual = 'X'; // Jogador atual, 'X' ou 'O'
    static bool jogoAcabou = false; // Flag para indicar se o jogo terminou

    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        int opcao = 0;
        Console.WriteLine("---------------------------------------------------------Menu---------------------------------------------------------");
        Console.WriteLine("Bem-vindo ao Jogo do Galo :D");
        Console.WriteLine("Por favor insira embaixo a opção que pretende realizar");
        Console.WriteLine("Iniciar Jogo (1) \nRegras (2) \nCréditos(3) \nSair do Jogo (0)");
        opcao = Convert.ToInt32(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                IniciarJogo();
                break;
            case 2:
                Regras();
                break;
            case 3:
                Creditos();
                break;
            case 0:
                break;
        }
    }

    static void Regras()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------------------Regras---------------------------------------------------------");
        int opcao;
        Console.WriteLine("Para jogares tens de seguir todas estas regras!");
        Console.WriteLine("1 - O jogo é feito para apenas dois jogadores. (não pode dupla de 3)");
        Console.WriteLine("2 - O primeiro jogador a conseguir uma linha com a sua devida figura (O ou X) ganha o jogo.");
        Console.WriteLine("3 - Tens sempre de fazer uma linha com 3 símbolos iguais");
        Console.WriteLine("4 - O nome dos jogadores não poderá ser igual.");
        Console.WriteLine("5 - Lembrem-se que é um jogo, o intuito do jogo é divertirem-se, por isso não se matem XD");
        Console.WriteLine("Boa sorte!!!!!!!!<3333333");
        Console.WriteLine("Agora que sabes as Regras, por favor insere a opção que pretendes:\n" +
        "Iniciar Jogo (1)\nVoltar ao Menu Inicial (2)");
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

    static void Creditos()
    {
        int opcao = 0;
        Console.Clear();
        Console.WriteLine("Trabalho realizado por:\nGuilherme Branco nº10\nMadalena Pernes nº14\nDisciplina de Linguagem de Programação.");
        Console.WriteLine("Agora que sabes quem fez o jogo, por favor insere a opção que pretendes:\n" +
        "Iniciar Jogo (1)\nVoltar ao Menu Inicial (2)");
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
        Console.WriteLine("--------------------------------------------------------Configurações---------------------------------------------------");
        Console.WriteLine("Antes de começarmos, é necessário inserir o nome de cada " +
        "um dos jogadores (máximo 2 jogadores)." +
        "\nOs nomes não podem ser idênticos.");
        Console.WriteLine("Inserir o Nome do Primeiro Jogador");
        Nome1 = Console.ReadLine();
        Console.WriteLine("Bem-vindo " + Nome1);
        Console.WriteLine("\n");
        Console.WriteLine("Inserir o Nome do Segundo Jogador");
        Nome2 = Console.ReadLine();
        while (Nome2 == Nome1)
        {
            Console.WriteLine("Nome inválido, por favor insira um Nome que não seja igual ao Nome do Jogador 1");
            Nome2 = Console.ReadLine();
        }
        Console.WriteLine("Bem-vindo " + Nome2);
        Console.WriteLine("\n");
        ConfigsJogo(Nome1, Nome2);
    }

    static void ConfigsJogo(string Nome1, string Nome2)
    {
        Console.Clear();
        Console.WriteLine("Agora vamos configurar o jogo!");
        Console.WriteLine("Quem será o primeiro Jogador a jogar?");
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
        Console.WriteLine("Antes de começar o jogo, por favor insira abaixo o número de rondas que pretende jogar.");
        int rondas = 0;
        rondas = Convert.ToInt32(Console.ReadLine());
        Jogo(rondas, ordem, Nome1, Nome2);
    }

    static void Jogo(int rondas, int ordem, string Nome1, string Nome2)
    {
        // Pontuação
        int PontosP1 = 0;
        int PontosP2 = 0;
        int Empates = 0;

        //Jogo P1 primeiro
        if (ordem == 1)
        {
            // r1 = nº de rondas a serem contadas
            int r1 = 0;
            while (r1 != rondas)
            {
                Console.WriteLine("O jogador " + Nome1 + " irá começar o jogo!");
                for (int rodada = 1; rodada <= rondas; rodada++)
                {
                    Console.Clear();
                    Console.WriteLine($"Rodada {rodada} de {rondas}\n");

                    tabuleiro = new char[3, 3]; // Reinicia o tabuleiro a cada rodada
                    jogadorAtual = (ordem == 1) ? 'X' : 'O'; // Define o jogador atual com base na ordem

                    jogoAcabou = false;

                    while (!jogoAcabou)
                    {
                        ExibirTabuleiro();

                        Console.WriteLine($"É a vez do jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)}");
                        Console.Write("Escolha uma posição (1-9): ");
                        int posicao = Convert.ToInt32(Console.ReadLine());

                        if (posicao >= 1 && posicao <= 9)
                        {
                            int linha = (posicao - 1) / 3;
                            int coluna = (posicao - 1) % 3;

                            if (tabuleiro[linha, coluna] == '\0')
                            {
                                tabuleiro[linha, coluna] = jogadorAtual;

                                if (VerificarVencedor())
                                {
                                    ExibirTabuleiro();
                                    Console.WriteLine($"O jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)} venceu!");
                                    AtualizarPontuacao(jogadorAtual, ref PontosP1, ref PontosP2);
                                    jogoAcabou = true;
                                }
                                else if (VerificarEmpate())
                                {
                                    ExibirTabuleiro();
                                    Console.WriteLine("O jogo terminou em empate!");
                                    Empates++;
                                    jogoAcabou = true;
                                }
                                else
                                {
                                    jogadorAtual = (jogadorAtual == 'O') ? 'X' : 'O'; // Alterna para o próximo jogador
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posição inválida! Por favor, escolha outra posição.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posição inválida! Por favor, escolha uma posição de 1 a 9.");
                        }
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("Jogo finalizado!\n");
                Console.WriteLine("Pontuação:");
                Console.WriteLine($"Jogador {Nome1} (X): {PontosP1} ponto(s)");
                Console.WriteLine($"Jogador {Nome2} (O): {PontosP2} ponto(s)");
                Console.WriteLine($"Empates: {Empates}");
                Console.WriteLine("\nObrigado por jogar!");
                Console.WriteLine("\nPor favor selecione uma das opções:");
                Console.WriteLine("\n Voltar ao Menu (1)\n Recomeçar Jogo (2)\n Créditos(3)\n Sair do Jogo (0)");
                int opcao = 0;
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        Menu();
                        break;
                    case 2:
                        IniciarJogo();
                        break;
                    case 3:
                        Creditos();
                        break;
                }
                r1++;
            }
        }

        //Caso Player 2 seja primeiro
        if (ordem == 2)
        {
            int r2 = 0;
            while (r2 != rondas)
            {
                for (int rodada = 1; rodada <= rondas; rodada++)
                {
                    Console.Clear();
                    Console.WriteLine("O jogador " + Nome2 + " irá começar o jogo!");
                    Console.WriteLine($"Rodada {rodada} de {rondas}\n");

                    tabuleiro = new char[3, 3]; // Reinicia o tabuleiro a cada rodada
                    jogadorAtual = (ordem == 2) ? 'X' : ','; // Define o jogador atual com base na ordem

                    jogoAcabou = false;

                    while (!jogoAcabou)
                    {
                        ExibirTabuleiro();

                        Console.WriteLine($"É a vez do jogador {jogadorAtual} - {(jogadorAtual == 'O' ? Nome1 : Nome2)}");
                        Console.Write("Escolha uma posição (1-9): ");
                        int posicao = Convert.ToInt32(Console.ReadLine());

                        if (posicao >= 1 && posicao <= 9)
                        {
                            int linha = (posicao - 1) / 3;
                            int coluna = (posicao - 1) % 3;

                            if (tabuleiro[linha, coluna] == '\0')
                            {
                                tabuleiro[linha, coluna] = jogadorAtual;

                                if (VerificarVencedor())
                                {
                                    ExibirTabuleiro();
                                    Console.WriteLine($"O jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)} venceu!");
                                    AtualizarPontuacao(jogadorAtual, ref PontosP1, ref PontosP2);
                                    jogoAcabou = true;
                                }
                                else if (VerificarEmpate())
                                {
                                    ExibirTabuleiro();
                                    Console.WriteLine("O jogo terminou em empate!");
                                    Empates++;
                                    jogoAcabou = true;
                                }
                                else
                                {
                                    jogadorAtual = (jogadorAtual == 'O') ? 'X' : 'O'; // Alterna para o próximo jogador
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posição inválida! Por favor, escolha outra posição.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posição inválida! Por favor, escolha uma posição de 1 a 9.");
                        }
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("Jogo finalizado!\n");
                Console.WriteLine("Pontuação:");
                Console.WriteLine($"Jogador {Nome1} (X): {PontosP1} ponto(s)");
                Console.WriteLine($"Jogador {Nome2} (O): {PontosP2} ponto(s)");
                Console.WriteLine($"Empates: {Empates}");
                Console.WriteLine("\nObrigado por jogar!");
                Console.WriteLine("\nPor favor selecione uma das opções:");
                Console.WriteLine("\n Voltar ao Menu (1)\n Recomeçar Jogo (2)\n Créditos(3)\n Sair do Jogo (0)");
                int opcao = 0;
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        Menu();
                        break;
                    case 2:
                        IniciarJogo();
                        break;
                    case 3:
                        Creditos();
                        break;
                }
                r2++;
            }
        }


        //Caso seja ordem aletaroria

        if (ordem == 3)
        {
            //Sorteio Nomes
            Random random = new Random();
            int SNomes = random.Next(1, 3);

            //Player 1 começa
            if (SNomes == 1)
            {
                int r3 = 0;
                while (r3 != rondas)
                {
                    Console.WriteLine("O jogador " + Nome1 + " irá começar o jogo!");
                    for (int rodada = 1; rodada <= rondas; rodada++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Rodada {rodada} de {rondas}\n");

                        tabuleiro = new char[3, 3]; // Reinicia o tabuleiro a cada rodada
                        jogadorAtual = (ordem == 1) ? 'O' : 'X'; // Define o jogador atual com base na ordem

                        jogoAcabou = false;

                        while (!jogoAcabou)
                        {
                            ExibirTabuleiro();

                            Console.WriteLine($"É a vez do jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)}");
                            Console.Write("Escolha uma posição (1-9): ");
                            int posicao = Convert.ToInt32(Console.ReadLine());

                            if (posicao >= 1 && posicao <= 9)
                            {
                                int linha = (posicao - 1) / 3;
                                int coluna = (posicao - 1) % 3;

                                if (tabuleiro[linha, coluna] == '\0')
                                {
                                    tabuleiro[linha, coluna] = jogadorAtual;

                                    if (VerificarVencedor())
                                    {
                                        ExibirTabuleiro();
                                        Console.WriteLine($"O jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)} venceu!");
                                        AtualizarPontuacao(jogadorAtual, ref PontosP1, ref PontosP2);
                                        jogoAcabou = true;
                                    }
                                    else if (VerificarEmpate())
                                    {
                                        ExibirTabuleiro();
                                        Console.WriteLine("O jogo terminou em empate!");
                                        Empates++;
                                        jogoAcabou = true;
                                    }
                                    else
                                    {
                                        jogadorAtual = (jogadorAtual == 'O') ? 'X' : 'O'; // Alterna para o próximo jogador
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Posição inválida! Por favor, escolha outra posição.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posição inválida! Por favor, escolha uma posição de 1 a 9.");
                            }
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }

                    Console.Clear();
                    Console.WriteLine("Jogo finalizado!\n");
                    Console.WriteLine("Pontuação:");
                    Console.WriteLine($"Jogador {Nome1} (X): {PontosP1} ponto(s)");
                    Console.WriteLine($"Jogador {Nome2} (O): {PontosP2} ponto(s)");
                    Console.WriteLine($"Empates: {Empates}");
                    Console.WriteLine("\nObrigado por jogar!");
                    Console.WriteLine("\nPor favor selecione uma das opções:");
                    Console.WriteLine("\n Voltar ao Menu (1)\n Recomeçar Jogo (2)\n Créditos(3)\n Sair do Jogo (0)");
                    int opcao = 0;
                    opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 0:
                            break;
                        case 1:
                            Menu();
                            break;
                        case 2:
                            IniciarJogo();
                            break;
                        case 3:
                            Creditos();
                            break;
                    }
                    r3++;
                }
            }

            //Sorteio player 2 começa
            if (SNomes == 2)
            {
                int r4 = 0;
                while (r4 != rondas)
                {
                    Console.WriteLine("O jogador " + Nome2 + " irá começar o jogo!");
                    for (int rodada = 1; rodada <= rondas; rodada++)
                    {
                        Console.Clear();
                        Console.WriteLine($"Rodada {rodada} de {rondas}\n");

                        tabuleiro = new char[3, 3]; // Reinicia o tabuleiro a cada rodada
                        jogadorAtual = (ordem == 1) ? 'O' : 'X'; // Define o jogador atual com base na ordem

                        jogoAcabou = false;

                        while (!jogoAcabou)
                        {
                            ExibirTabuleiro();

                            Console.WriteLine($"É a vez do jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)}");
                            Console.Write("Escolha uma posição (1-9): ");
                            int posicao = Convert.ToInt32(Console.ReadLine());

                            if (posicao >= 1 && posicao <= 9)
                            {
                                int linha = (posicao - 1) / 3;
                                int coluna = (posicao - 1) % 3;

                                if (tabuleiro[linha, coluna] == '\0')
                                {
                                    tabuleiro[linha, coluna] = jogadorAtual;

                                    if (VerificarVencedor())
                                    {
                                        ExibirTabuleiro();
                                        Console.WriteLine($"O jogador {jogadorAtual} - {(jogadorAtual == 'X' ? Nome1 : Nome2)} venceu!");
                                        AtualizarPontuacao(jogadorAtual, ref PontosP1, ref PontosP2);
                                        jogoAcabou = true;
                                    }
                                    else if (VerificarEmpate())
                                    {
                                        ExibirTabuleiro();
                                        Console.WriteLine("O jogo terminou em empate!");
                                        Empates++;
                                        jogoAcabou = true;
                                    }
                                    else
                                    {
                                        jogadorAtual = (jogadorAtual == 'O') ? 'X' : 'O'; // Alterna para o próximo jogador
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Posição inválida! Por favor, escolha outra posição.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Posição inválida! Por favor, escolha uma posição de 1 a 9.");
                            }
                        }

                        Console.WriteLine("\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }

                    Console.Clear();
                    Console.WriteLine("Jogo finalizado!\n");
                    Console.WriteLine("Pontuação:");
                    Console.WriteLine($"Jogador {Nome1} (X): {PontosP1} ponto(s)");
                    Console.WriteLine($"Jogador {Nome2} (O): {PontosP2} ponto(s)");
                    Console.WriteLine($"Empates: {Empates}");
                    Console.WriteLine("\nObrigado por jogar!");
                    Console.WriteLine("\nPor favor selecione uma das opções:");
                    Console.WriteLine("\n Voltar ao Menu (1)\n Recomeçar Jogo (2)\n Créditos(3)\n Sair do Jogo (0)");
                    int opcao = 0;
                    opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 0:
                            break;
                        case 1:
                            Menu();
                            break;
                        case 2:
                            IniciarJogo();
                            break;
                        case 3:
                            Creditos();
                            break;
                    }
                    r4++;
                }
            }

        }

    }

    static void ExibirTabuleiro()
    {
        Console.Clear();
        Console.WriteLine("   1   2    3");
        Console.WriteLine(" +---+---+---+");
        for (int linha = 0; linha < 3; linha++)
        {
            Console.Write($"{linha + 1} | ");
            for (int coluna = 0; coluna < 3; coluna++)
            {
                char simbolo = tabuleiro[linha, coluna];
                Console.Write($"{simbolo} | ");
            }
            Console.WriteLine("\n +---+---+---+");
        }
        Console.WriteLine();
    }

    static bool VerificarVencedor()
    {
        // Verifica linhas
        for (int linha = 0; linha < 3; linha++)
        {
            if (tabuleiro[linha, 0] == jogadorAtual && tabuleiro[linha, 1] == jogadorAtual && tabuleiro[linha, 2] == jogadorAtual)
                return true;
        }

        // Verifica colunas
        for (int coluna = 0; coluna < 3; coluna++)
        {
            if (tabuleiro[0, coluna] == jogadorAtual && tabuleiro[1, coluna] == jogadorAtual && tabuleiro[2, coluna] == jogadorAtual)
                return true;
        }

        // Verifica diagonais
        if (tabuleiro[0, 0] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual)
            return true;

        if (tabuleiro[0, 2] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 0] == jogadorAtual)
            return true;

        return false;
    }

    static bool VerificarEmpate()
    {
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                if (tabuleiro[linha, coluna] == '\0')
                    return false;
            }
        }
        return true;
    }

    static void AtualizarPontuacao(char jogadorAtual, ref int PontosP1, ref int PontosP2)
    {
        if (jogadorAtual == 'X')
            PontosP1++;
        else
            PontosP2++;
    }
}
