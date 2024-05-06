using System.ComponentModel.Design;
using System.Net.Http.Headers;

RegistarLivros();
static void RegistarLivros()
{
   double menorpreco = 500;
    double maiorpreco = 0;
    string livromenorpreco = "";
        string livromaiorpreco = "";
    double precototal = 0;


    string[] titulos = new string[2];
    string[] autores = new string[2];
    double[] preco = new double[2];
    for (int i = 0; i < titulos.Length; i++)
    {
        Console.Clear(); // dar clear na consola para ficar mais organizado
        Console.WriteLine("Insira o nome do livro que pretende registar"); // perguntar titulo livro
        titulos[i] = Console.ReadLine();

        Console.WriteLine(); // espaçamento entre respostas/perguntas


        Console.WriteLine("Insira o autor do livro que pretende registar"); // perguntar autor
        autores[i] = Console.ReadLine();
       
        Console.WriteLine(); // espaçamento entre respostas/perguntas
       
        Console.WriteLine("Insira o preço do livro que pretende registar"); // perguntar preço
        preco[i] = double.Parse(Console.ReadLine());
        precototal = precototal + preco[i];


        if (preco[i] < menorpreco)
        {
            menorpreco = preco[i];
            livromenorpreco = titulos[i];
        }

        if (preco[i] > maiorpreco)
        {
            maiorpreco = preco[i];
           livromaiorpreco = titulos[i];
        }

        Console.WriteLine(); // espaçamento entre respostas/perguntas

    }
    Console.WriteLine("Livros registados, muito obrigado! \nPretende ser redirecionado para o Menu (1) ou sair da aplicação (0) ?");
    int escolha = 0;
    bool loop = true;
    escolhaerrada: // caso a escolha seja invalida no switch volta-se a perguntar tudo

    escolha = Convert.ToInt32(Console.ReadLine());
    while (loop == true) 
    {
        switch (escolha)
        {
            case 0:
               loop = false; 
            break;
            
            case 1:
                loop = false;
                Menu(ref menorpreco, ref maiorpreco, ref livromaiorpreco, ref livromenorpreco, ref precototal);
            break;

                default:
                Console.WriteLine("Opção inválida, tente novamente");
                goto escolhaerrada; // voltar atrás porque a escolha é invalida
        }
    }
}

static void Menu(ref double menorpreco, ref double maiorpreco, ref string livromaiorpreco, ref string livromenorpreco, ref double precototal)
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao programa da biblioteca o que pretende fazer agora?");
    Console.WriteLine(); // espaçamento
    Console.WriteLine("Verificar preços dos livros (menor, maior e média de preços) (1)");
    Console.WriteLine("Verificar livros de um autor específico (2)");
    Console.WriteLine("Sair da aplicação (0)");

    int escolha2 = 0;
    bool loop2 = true;

escolhaerrada2: // caso a escolha seja invalida no switch volta-se a perguntar tudo

    escolha2 = Convert.ToInt32(Console.ReadLine());
    while (loop2 == true)
    {
        switch (escolha2)
        {
            case 0:
                loop2 = false;
                break;

            case 1:
                loop2 = false;
                Preços(ref menorpreco, ref maiorpreco, ref livromaiorpreco, ref livromenorpreco, ref precototal);
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente");
                goto escolhaerrada2; // voltar atrás porque a escolha é invalida
        }
    }
}

static void Preços(ref double menorpreco, ref double maiorpreco, ref string livromaiorpreco, ref string livromenorpreco, ref double precototal)
{
    Console.Clear() ;
    double media = 0;
    media = precototal / 2;
    Console.WriteLine("Livro com preço mais baixo:\n" + livromenorpreco + ":" + menorpreco);
    Console.WriteLine("Livro com preço mais alto:\n" + livromaiorpreco + ":" + maiorpreco);
    Console.WriteLine("Preço médio de todos os livros: " + media);
    Console.WriteLine("O que pretende fazer agora?");
    Console.WriteLine("Ir para o Menu Inicial (1)");
    Console.WriteLine("Sair da aplicação");

    int escolha = 0;
    bool loop = true;

    while (loop == true) 
    {
    switch (escolha)
        {
            case 1:
                loop = false;
                Menu(ref menorpreco, ref maiorpreco, ref livromaiorpreco, ref livromenorpreco, ref precototal);
                break;

            case 0:
                loop = false;
                break;
        }
    }
}