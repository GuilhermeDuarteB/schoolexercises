// See https://aka.ms/new-console-template for more information
float Base;
float Altura;
float area;
float perimetro;
float escolha;
Console.WriteLine("pretende ter a area,o perimetro ou ambos? ambos=1 ; Area=2 ; Perimetro=3");

//Calcular Ambos (Area + Perimetro)
escolha = Convert.ToInt32(Console.ReadLine());
if (escolha == 1)
{

    //Calcular Perimetro
    Console.WriteLine("Para calcular o Perimetro preciso de:");
    Console.WriteLine("Inserir a Base do Retângulo");
    Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserir Altura do Retângulo");
    Altura = Convert.ToInt32(Console.ReadLine());
    perimetro = Altura * 2 + Base * 2;
    Console.WriteLine("O perimetro é " + perimetro);

    //Calcular Area
    Console.WriteLine("Para calcular a Area preciso de:");
    Console.WriteLine("Inserir a Base do Retângulo");
    Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserir a Altura do Retângulo");
    Altura = Convert.ToInt32(Console.ReadLine());
    area = Base * Altura;
    Console.WriteLine("A area é " + area);

}

//Apenas calcular Area
if (escolha == 2)
{
    Console.WriteLine("Para calcular a Area preciso de:");
    Console.WriteLine("Inserir a Base do Retângulo");
    Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserir a Altura do Retângulo");
    Altura = Convert.ToInt32(Console.ReadLine());
    area = Base * Altura;
    Console.WriteLine("A area é " + area);

}

    //Apenas calcular Perimetro
    if (escolha == 3)
{
        Console.WriteLine("Para calcular o Perimetro preciso de:");
        Console.WriteLine("Inserir a Base do Retângulo");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserir a Altura do Retângulo");
        Altura = Convert.ToInt32(Console.ReadLine());
        perimetro = Altura * 2 + Base * 2;
        Console.WriteLine("O perimetro é " + perimetro);
}

