double espessura = 0.074, espessuraCm,espessuraM, espessuraKms;
int dobragens;
Console.WriteLine("Quantas vezes pretende dobrar?");
dobragens = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < dobragens; i++)
{
    espessura = espessura * 2;
}
espessuraCm = espessura / 10;
espessuraM = espessuraCm / 100;
espessuraKms = espessuraM / 1000; Console.WriteLine("Espessura Final (mm): " + espessura);
Console.WriteLine("Espessura Final (cm): " + espessuraCm);
Console.WriteLine("Espessura Final (M): " + espessuraM);
Console.WriteLine("Espessura Final (KM): " + espessuraKms);

