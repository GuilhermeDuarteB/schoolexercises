Main();
    static void Main()
{
    MenuInicial();
}

static void MenuInicial()
{
    int rInicial=0;
    Console.WriteLine("Bem vindo á calculadora o que pretende calcular?\n 1 - Somar \n 2 - Subtrair \n " +
        "3 - Multiplicar\n 4 - Dividir \n 0 - Sair");
    rInicial = Convert.ToInt32(Console.ReadLine());
    switch (rInicial)
    {
        case 0:
            break;
        case 1:
            Somar();
            break;
            case 2:
            Subtrair();
            break;
            case 3:
            Multiplicar();
            break;
        case 4:
            Dividir();
           break;
    }
}

static void Somar()
{
    int resposta=0;
    float N1, N2, Soma;
    Console.WriteLine("Insira o primeiro número para somar");
    N1 = (float)double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo número para somar");
    N2 = (float)double.Parse(Console.ReadLine());
    Soma = N1 + N2;
    Console.WriteLine("A soma dos dois números inseridos é de " + Soma);
    Console.WriteLine("Pretende voltar ao Menu Inicial(1) ou Sair da Calculadora(2)");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
            case 2:
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

static void Subtrair()
{
    int resposta = 0;
    float N1, N2, Subtracao;
    Console.WriteLine("Insira o primeiro número para subtrair");
    N1 = (float)double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo número para subtrair");
    N2 = (float)double.Parse(Console.ReadLine());
    Subtracao = N1 - N2;
    Console.WriteLine("A soma dos dois números inseridos é de " + Subtracao);
    Console.WriteLine("Pretende voltar ao Menu Inicial(1) ou Sair da Calculadora(2)");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

static void Multiplicar()
{
    int resposta = 0;
    float N1, N2, Multiplicacao;
    Console.WriteLine("Insira o primeiro número para multiplicar");
    N1 = (float)double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo número para multiplicar");
    N2 = (float)double.Parse(Console.ReadLine());
    Multiplicacao = N1 * N2;
    Console.WriteLine("A multiplicação dos dois números inseridos é de " + Multiplicacao);
    Console.WriteLine("Pretende voltar ao Menu Inicial(1) ou Sair da Calculadora(2)");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

static void Dividir()
{
    int resposta = 0;
    float N1, N2, divisao;
    Console.WriteLine("Insira o primeiro número para dividir");
    N1 = (float)double.Parse(Console.ReadLine());
    Console.WriteLine("Insira o segundo número para dividir");
    N2 = (float)double.Parse(Console.ReadLine());
   divisao = N1 / N2;
    Console.WriteLine("A divisão dos dois números inseridos é de " + divisao);
    Console.WriteLine("Pretende voltar ao Menu Inicial(1) ou Sair da Calculadora(2)");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}