int produtos;

Console.WriteLine("Insira o código do produto que pretende (1-5)");
produtos = Convert.ToInt32(Console.ReadLine());

switch (produtos)
{
    case 1:
        Console.WriteLine("Código 1: Produto A - 10,00 euros");
        break;
    case 2:
        Console.WriteLine("Código 2: Produto B - 20,00 euros");
        break;
    case 3:
        Console.WriteLine("Código 3: Produto C - 30,00 euros");
        break;
    case 4:
        Console.WriteLine("Código 4: Produto D - 40,00 euros");
        break;
    case 5:
        Console.WriteLine("Código 5: Produto E - 50,00 euros");
        break;
}