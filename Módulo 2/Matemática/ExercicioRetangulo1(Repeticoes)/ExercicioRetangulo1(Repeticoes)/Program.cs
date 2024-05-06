using System.Net;
using System.Runtime.Intrinsics.Arm;

float Base;
float Altura;
float area;
float perimetro;
float Ambos;
float Escolha;
float total;
int resposta;
total = 0;
Console.WriteLine("pretende ter a area,o perimetro ou ambos? ambos=1 ; Area=2 ; Perimetro=3");
Escolha = Convert.ToInt32(Console.ReadLine());
if (Escolha == 1)
{
    do
    {
        Console.WriteLine("Para calcular o Perimetro preciso de:");
        Console.WriteLine("Inserir a Base do Retângulo");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserir Altura do Retângulo");
        Altura = Convert.ToInt32(Console.ReadLine());
        perimetro = Altura * 2 + Base * 2;
        Console.WriteLine("O perimetro é " + perimetro);
        Console.WriteLine("Para calcular a Area preciso de:");
        Console.WriteLine("Inserir a Base do Retângulo");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserir a Altura do Retângulo");
        Altura = Convert.ToInt32(Console.ReadLine());
        area = Base * Altura;
        Console.WriteLine("A area é " + area);
        total = total + 1;
        Console.WriteLine("Deseja continuar a calcular ambos? Se quiser parar inserir 1, se deseja continuar insira 2");
        resposta = Convert.ToInt32(Console.ReadLine());
        if (resposta == 1)
            Console.ReadKey();
    } while (total = Convert.ToBoolean(Console.ReadLine) total = total + 1);
}

    if (Escolha ==2)
{
    Console.WriteLine("Para calcular a Area preciso de:");
    Console.WriteLine("Inserir a Base do Retângulo");
    Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserir a Altura do Retângulo");
    Altura = Convert.ToInt32(Console.ReadLine());
    area = Base * Altura;
    Console.WriteLine("A area é " + area);
    Console.WriteLine("Deseja continuar a calcular ambos? Se quiser parar inserir 1, se deseja continuar insira 2");
    resposta = Convert.ToInt32(Console.ReadLine());
    if (resposta == 1)
    {

    }
}

    if (Escolha == 3)
{
    Console.WriteLine("Para calcular o Perimetro preciso de:");
    Console.WriteLine("Inserir a Base do Retângulo");
    Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserir Altura do Retângulo");
    Altura = Convert.ToInt32(Console.ReadLine());
    perimetro = Altura * 2 + Base * 2;
    Console.WriteLine("O perimetro é " + perimetro);
    Console.WriteLine("Deseja continuar a calcular ambos? Se quiser parar inserir 1, se deseja continuar insira 2");
    resposta = Convert.ToInt32(Console.ReadLine());
    if (resposta == 1)
    {

    }
}