float Num1, Num2, Num3;

Console.WriteLine("Inserir o primeiro número.");
Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserir o segundo número");
Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserir o terceiro número");
Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2 && Num1 > Num3)
{
    Console.WriteLine("O maior número é " + Num1);
}
else if (Num2 > Num1 && Num2 > Num3)
{
    Console.WriteLine("O maior número é " + Num2);
}
else if (Num3 > Num1 && Num3 > Num2)
{
    Console.WriteLine("O maior número é " + Num3);
}