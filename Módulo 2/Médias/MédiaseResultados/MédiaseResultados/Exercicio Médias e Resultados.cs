float Nota1, Nota2, Nota3;
float Media, MediaPonderada;
float NotaFinal;

Console.WriteLine("Inserir a Primeira Nota.");
Nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserir a Segunda Nota");
Nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserir a Terceira Nota");
Nota3 = Convert.ToInt32(Console.ReadLine());

Media = Nota1 + Nota2 + Nota3;
Media = Media / 3;
MediaPonderada = Nota1 * 3 + Nota2 * 4 + Nota3 * 5 / 3 + 4 + 5;
Console.WriteLine("A sua média é " + Media + " e a sua média ponderada é de " + MediaPonderada);

if (Media >= 9.5)
{
    Console.WriteLine("Parabéns estás Dispensado do Exame!");
}
else if (Media >= 7.5 & Media < 9.5)
{
    Console.WriteLine("Admitido a exame!");
}
else if (Media < 7.5)
{
    Console.WriteLine("Infelizmente estás Reprovado.");
}