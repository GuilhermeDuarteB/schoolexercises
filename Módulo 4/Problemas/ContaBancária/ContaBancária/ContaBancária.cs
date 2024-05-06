Main();
static void Main()
{
    ParteInicial();
}

static void ParteInicial()
{
    string nomeConta = "";
    int rInicial;
    Console.WriteLine("Bem-vindo ao Casa Banco!");
    Console.WriteLine("Caso não tenha conta prima 1");
    Console.WriteLine("Caso tenha conta prima 2");
    Console.WriteLine("Caso queira sair do MultiBanco prima 3");
    rInicial = Convert.ToInt32(Console.ReadLine());
    switch (rInicial)
    {
        case 1:
            CriarAcc(ref nomeConta);
            break;
        case 2:
            PIN();
            break;
        case 3:
            return;
    }
}

static void CriarAcc(ref string nomeConta)
{
    string Nome, email;
    int Idade, codigo;
    Console.WriteLine("Para criar a sua conta necessito que:");
    Console.WriteLine("Insira o seu nome:");
    Nome = Console.ReadLine();
    Console.WriteLine("OK " + Nome + ", por favor insira a sua idade:");
    Idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Estamos quase a acabar! Agora insira o seu e-mail:");
    email = Console.ReadLine();
    Console.WriteLine("Agora para finalizar, por favor crie o seu código secreto:");
    codigo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("OK! Bem-vindo " + Nome + ", espero que goste da Casa Banco!");
}

static void PIN()
{
    int codigo, opcao;
    Console.WriteLine("Inserir código secreto:");
    codigo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insira a opção que pretende: \n Ir para o Menu (1) \n Voltar á tela anterior (2)");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            return;
    }
}
decimal saldoconta = 0;
static void MenuInicial()
{
    int opcaoEscolhida;
    Console.WriteLine("Escolha uma das opções");
    Console.WriteLine("•Depósito (1)");
    Console.WriteLine("•Saque (2)");
    Console.WriteLine("•Consulta de Saldo (3)");
    Console.WriteLine("•Sair do Multibanco (4)");
    opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        case 1:
            Deposito(ref saldoconta);
            break;
        case 2:
           Levantar(ref saldoconta);
            break;
        case 3:
            CheckSaldo(ref saldoconta);
            break;
        case 4:
            break;
    }
}


static decimal Deposito(ref decimal saldoconta)
{
    int resposta;
    Console.WriteLine("Inserir valor que pretende depositar");
    decimal deposito = Convert.ToDecimal(Console.ReadLine());
    saldoconta = saldoconta + deposito;
    Console.WriteLine("Valor depositado!");
    Console.WriteLine("O seu saldo atual é de " + saldoconta + "$");
    Console.WriteLine("Pretende voltar ao Menu Inicial? \n 1=Sim \n 2=Não");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            break;
    }
    return saldoconta;
}

static decimal Levantar(ref decimal saldoconta)
{
    int resposta = 0;
    Console.WriteLine("Que valor pretende levantar?");
    decimal saldoLevantar = Convert.ToDecimal(Console.ReadLine());
    if (saldoconta > saldoLevantar)
    {
        while (saldoconta > saldoLevantar)
        {
            Console.WriteLine("Você não tem dinheiro suficiente para levantar essa quantia, tente novamente");
            Console.WriteLine("Que valor pretende levantar?");
            saldoLevantar = Convert.ToDecimal(Console.ReadLine());
        }
    }
    saldoconta = saldoconta - saldoLevantar;
    Console.WriteLine("Valor levantado! \n O valor atual na sua conta é de " + saldoconta + "$");
    Console.WriteLine("Pretende voltar ao Menu Inicial? \n 1=Sim \n 2=Não");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            break;
    }
    return saldoconta;
}

static decimal CheckSaldo(ref decimal saldoconta)
{
    int resposta = 0;
    Console.WriteLine("O se saldo atual é de " + saldoconta);
    Console.WriteLine("Pretende voltar ao Menu Inicial? \n 1=Sim \n 2=Não");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            MenuInicial();
            break;
        case 2:
            break;
    }
    return saldoconta;
}