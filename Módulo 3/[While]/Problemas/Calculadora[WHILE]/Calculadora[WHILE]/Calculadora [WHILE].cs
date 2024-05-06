int respostaInicial, TotalVezes;
double N1, N2, NTotal; 
do
{
    Console.WriteLine("Que operação pretende efetuar?");
    Console.WriteLine("Adição (1)");
    Console.WriteLine("Subtração (2)");
    Console.WriteLine("Multiplicação (3)");
    Console.WriteLine("Divisão (4)");
    Console.WriteLine("Sair (5)");
    respostaInicial = Convert.ToInt32(Console.ReadLine());

    if (respostaInicial == 1)
    {
        N1 = 0;
        N2 = 0;
        NTotal = 0;
        TotalVezes = 0;
        do
        {          
            Console.WriteLine("Inserir números");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            TotalVezes = TotalVezes + 1;
        } while (TotalVezes < 1);
        NTotal = N1 + N2;
        Console.WriteLine("O resultado da sua conta deu " + NTotal);
    }
    if (respostaInicial == 2)
    {
        N1 = 0;
        N2 = 0;
        NTotal = 0;
        TotalVezes = 0;
        do
        {
            Console.WriteLine("Inserir números");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            TotalVezes = TotalVezes + 1;
        } while (TotalVezes < 1);
        NTotal = N1 - N2;
        Console.WriteLine("O resultado da sua conta deu " + NTotal);
    }
    if (respostaInicial == 3)
    {
        N1 = 0;
        N2 = 0;
        NTotal = 0;
        TotalVezes = 0;
        do
        {
            Console.WriteLine("Inserir números");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            TotalVezes = TotalVezes + 1;
        } while (TotalVezes < 1);
        NTotal = N1 * N2;
        Console.WriteLine("O resultado da sua conta deu " + NTotal);
    }
    if (respostaInicial == 4)
    {
        N1 = 0;
        N2 = 0;
        NTotal = 0;
        TotalVezes = 0;
        do
        {
            Console.WriteLine("Inserir números");
            N1 = Convert.ToInt32(Console.ReadLine());
            N2 = Convert.ToInt32(Console.ReadLine());
            TotalVezes = TotalVezes + 1;
        } while (TotalVezes < 1);
        NTotal = N1 / N2;
        Console.WriteLine("O resultado da sua conta deu " + NTotal);
    }
} while (respostaInicial<5);