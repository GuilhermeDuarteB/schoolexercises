int numero;
Console.WriteLine("Que número pretende saber como se escreve por extenso?");
numero = Convert.ToInt32(Console.ReadLine());
switch (numero)
{
    case 1:
        Console.WriteLine("Um");
        break;
    case 2:
        Console.WriteLine("Dois");
        break ;
    case 3:
        Console.WriteLine("Três");
        break;
    case 4:
        Console.WriteLine("Quatro");
        break;
    case 5:
        Console.WriteLine("Cinco");
        break;
    case 6:
        Console.WriteLine("Seis");
        break;
    case 7:
        Console.WriteLine("Sete");
        break;
    case 8:
        Console.WriteLine("Oito");
        break;
    case 9:
        Console.WriteLine("Nove");
        break;
    case 10:
        Console.WriteLine("Dez");
        break;
}