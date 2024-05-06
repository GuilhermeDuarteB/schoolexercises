using System.Security.Cryptography.X509Certificates;

int Mais10, Igual10, Menos10, Resposta;
string Nome;
Console.WriteLine("Inserir o seu nome");
Nome = Console.ReadLine();

Console.WriteLine("Quantos dias irá estar na residência?");
Resposta = Convert.ToInt32(Console.ReadLine());
if (Resposta > 10)
{
    Mais10 = Resposta * 50 + Resposta * 5;
    Console.WriteLine("Senhor " + Nome + " terá de pagar " + Mais10 + " euros por " + Resposta + " dias.");
}


if (Resposta == 10)
{
    Igual10 = Resposta * 50 + Resposta * 6;
    Console.WriteLine("Senhor " + Nome + " terá de pagar " + Igual10 + " euros por " + Resposta + " dias.");
}

if (Resposta < 10)
{
    Menos10 = Resposta * 50 + Resposta * 7;
    Console.WriteLine("Senhor " + Nome + " terá de pagar " + Menos10 + " euros por " + Resposta + " dias.");

}
Console.ReadKey();