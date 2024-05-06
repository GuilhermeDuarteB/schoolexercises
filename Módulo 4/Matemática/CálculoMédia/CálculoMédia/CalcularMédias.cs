Inicio();   
static void Inicio()
{
    int resposta;
    Console.WriteLine("Bem vindo ao Calculo de Médias! \n Por favor antes de iniciar insira o que quer fazer.");
    Console.WriteLine("Calcular a Média insira 1 \n Sair do Programa insira 2");
    resposta = Convert.ToInt32(Console.ReadLine());
    switch (resposta)
    {
        case 1:
            CalculoMédia();
            break;
            case 2:
            break;
    }

}

static void CalculoMédia()
{
    double resposta=0, Media = 0, NTotal=0;
    int vezes=0, menu;
    Console.WriteLine("Por favor insira os números para calcular a média \n Caso queria parar insira 0");
    while (true)
    {
        resposta = Convert.ToDouble(Console.ReadLine());
        NTotal = resposta + NTotal;
        
        if (resposta == 0)
        {
            break;
        }
        vezes = vezes + 1;
    }
    Media = (NTotal / vezes);
    Console.WriteLine("A média de todos os " + vezes + " números inseridos é " + Media);
    Console.WriteLine("Pretende voltar para o Menu Inicial (1), voltar a calcular as médias (2), ou sair da Calculadora de Médias (3)");
   menu = Convert.ToInt32(Console.ReadLine());
    switch (menu)
    {
        case 1:
            Inicio();
            break;
        case 2:
            CalculoMédia();
            break;
        case 3:
            break;
    }
}