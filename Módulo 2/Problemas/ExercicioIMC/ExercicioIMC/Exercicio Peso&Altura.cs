float Peso, Altura, IMC;
string Nome;


Console.WriteLine("Olá, bem vindo peço que por favor insira as seguintes informações");
Console.WriteLine("AVISO: Lembrando que este teste apenas calcula a sua Massa Corporal, por conta disso o seu resultado não é completamente verdade, a sua saude também depende de outros fatores.");
Console.WriteLine("Insira o seu nome");
Nome = Console.ReadLine();

Console.WriteLine("Ok " + Nome + " por favor insira o seu peso em quilogramas .");
Peso = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ok, agora por favor insira a sua Altura. (m,cm)");
Altura= float.Parse(Console.ReadLine());

IMC = (Peso / (Altura * Altura));

if (IMC < 18.5)
{
    Console.WriteLine("Você está abaixo do Peso!");
}
else if (IMC >18.5 && IMC < 24.9)
{
    Console.WriteLine("Você está dentro do Peso normal.");
}
else if (IMC >25 && IMC < 29.9)
{
    Console.WriteLine("Você está com Sobrepeso!");
}
else if (IMC >30 && IMC < 34.9)
{
    Console.WriteLine("CUIDADO você está no Grau de Obesidade de nível 1!");
}
else if (IMC >35 && IMC < 39.9)
{
    Console.WriteLine("CUIDADO você está no Grau de Obesidade de nível 2!");
}
else if (IMC > 40) 
{
    Console.WriteLine("CUIDADO você está no Grau de Obesidade de nível 3!");
}