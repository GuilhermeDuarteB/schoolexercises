int NTotal = 0, NResposta = 0;

Console.WriteLine("Inserir lista de 6 números");
for (int i = 0; i != 6; i++)
{
    NResposta = Convert.ToInt32(Console.ReadLine());
    NTotal = NTotal - NResposta;
}
Console.WriteLine("O minimo possível desses números é " + NTotal);