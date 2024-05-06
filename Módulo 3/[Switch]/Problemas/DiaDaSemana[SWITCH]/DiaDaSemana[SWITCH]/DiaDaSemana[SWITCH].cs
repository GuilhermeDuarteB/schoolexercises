int diaSemana;

Console.WriteLine("Insira o dia da semana que pretende saber");
diaSemana = Convert.ToInt32(Console.ReadLine());
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Segunda-Feira");
        break;
        case 2:
        Console.WriteLine("Terça-Feira");
        break;
            case 3:
        Console.WriteLine("Quarta-Feira");
        break;
    case 4:
        Console.WriteLine("Quinta-Feira");
        break;
    case 5:
        Console.WriteLine("Sexta-Feira");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
}