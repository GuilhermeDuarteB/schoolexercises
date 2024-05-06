int fim = 0, resposta;
Console.WriteLine("Insira um número que deseja a tabuada");
resposta = Convert.ToInt32(Console.ReadLine());
while (fim!=50)
{
    int NPrincipal = 0;
    NPrincipal = resposta;
    fim++;
    NPrincipal = NPrincipal * fim;
    Console.WriteLine(NPrincipal);
}