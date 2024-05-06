float Salario;
double Aumento, Total;
string Nome;

Console.WriteLine("Olá, bem vindo por favor insira o seu nome");
Nome = Console.ReadLine();

Console.WriteLine("Olá " + Nome + " por favor insira o seu salário atual.");
Salario = Convert.ToInt32(Console.ReadLine());

if (Salario >= 1000) 
{
    Aumento = Salario * 0.12;
    Total = Salario + Aumento;

    Console.WriteLine("Parabéns o seu salário aumentou em " + Aumento + " euros e ficará a " + Total + " euros!");
        }
else if (Salario >= 1200)
{
    Aumento = Salario * 0.10;
    Total = Salario + Aumento;

    Console.WriteLine("Parabéns o seu salário aumentou em " + Aumento + " euros e ficará a " + Total + " euros!");
}
else if (Salario >= 1400) 
{
    Aumento = Salario * 0.08;
    Total = Salario + Aumento;

    Console.WriteLine("Parabéns o seu salário aumentou em " + Aumento + " euros e ficará a " + Total + " euros!");
}