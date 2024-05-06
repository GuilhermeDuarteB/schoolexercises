string letra;
int NLetra=0;
Console.WriteLine("Insira a letra que pretende saber se é Vogal ou Consoante");
letra = Console.ReadLine();
if (letra != "a" & letra != "A" & letra != "e" & letra != "E" & letra != "i" & letra != "I" & letra != "o"
    & letra != "O" & letra != "u" & letra != "U") 
{
    NLetra = 2;
}
else
{
    NLetra = 1;
}
switch (NLetra)
{
    case 1:
        Console.WriteLine("A letra " + letra + " é uma vogal");
        break;
    case 2:
        Console.WriteLine("A letra " + letra + " é uma consoante");
        break;
}