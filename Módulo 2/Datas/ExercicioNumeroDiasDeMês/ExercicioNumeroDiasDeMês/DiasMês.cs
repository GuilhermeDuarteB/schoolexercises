using System.Globalization;

int Ano, mes;
Console.WriteLine("Aqui irá encontrar o número de dias de um mês de um determinado ano!");
    Console.WriteLine("Por favor insira o mês que pretende saber quantos dias tem");
mes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Agora insira o ano");
Ano = Convert.ToInt32(Console.ReadLine());
DateTimeFormatInfo dinfo = new DateTimeFormatInfo();
string nummes = dinfo.GetMonthName(mes);
int numdias = DateTime.DaysInMonth(Ano, mes);
Console.WriteLine("O número de dias do mês {0} é: {1}", nummes, numdias);
    