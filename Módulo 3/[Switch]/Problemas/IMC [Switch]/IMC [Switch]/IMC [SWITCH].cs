double IMC = 0,peso=0, altura=0;

Console.WriteLine("Insira o seu peso em KG");
peso = double.Parse (Console.ReadLine());

Console.WriteLine("Insira a sua altura em metros");
altura = double.Parse(Console.ReadLine());

IMC = (peso / (altura * altura));
Console.WriteLine("O teu IMC é de " + IMC);

switch (IMC)
{
    case <= 18.5:
        Console.WriteLine("Abaixo do Peso");
        break;
        case var n when n >= 18.5 && n <= 24.9:
            Console.WriteLine("Peso Normal");
        break;
    case var n when n >= 25 && n <= 29.9:
        Console.WriteLine("Sobrepeso");
        break;
    case var n when n >= 30 && n <= 34.9:
        Console.WriteLine("Grau 1 de Obesidade");
        break;
    case var n when n >= 35 && n <= 39.9:
        Console.WriteLine("Grau 2 de Obesidade");
        break;
    case > 40:
        Console.WriteLine("Grau 3 de Obesidade");
        break;
}