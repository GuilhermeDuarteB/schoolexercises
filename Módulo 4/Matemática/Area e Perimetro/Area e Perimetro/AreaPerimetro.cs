MenuInicial();
static void MenuInicial()
{
    int resposta = 0;
    Console.WriteLine("Bem vindo ao programa de calculo de Area e Perimetro de um retângulo \n Calcular Área (1)" +
        "\n Calcular Perimetro (2) \n Sair do Programa (3)");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            Área();
               break;
            case 2:
            Perimetro();
            break;
            case 3:
            break;
    }
}

static void Área()
{
    double Base = 0, Altura = 0, Area = 0;
    int opcao;
    Console.WriteLine("Insira a base do retângulo");
    Base = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insira a Altura do retângulo");
    Altura = Convert.ToDouble(Console.ReadLine());
    Area = Base * Altura;
    Console.WriteLine("A área do seu retângulo é de " + Area);
    Console.WriteLine("O que pretende fazer agora? \n Voltar ao Menu Inicial (1) \n " +
        "Calcular o Perimetro do Retângulo (2) \n Sair da Calculadora de Área e Perimetro(3)");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            Perimetro();
            break;
    case 3:
break;

    }
}

static void Perimetro()
{
    double Base = 0, Altura = 0, Perimetro = 0;
    int opcao;
    Console.WriteLine("Insira a base do retângulo");
    Base = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Insira a Altura do retângulo");
    Altura = Convert.ToDouble(Console.ReadLine());
    Perimetro = 2 * (Base + Altura);
    Console.WriteLine("O Perimetro do seu retângulo é de " + Perimetro);
    Console.WriteLine("O que pretende fazer agora? \n Voltar ao Menu Inicial (1) \n " +
        "Calcular a Área do Retângulo (2) \n Sair da Calculadora de Área e Perimetro(3)");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            Área();
            break;
        case 3:
            break;

    }
}