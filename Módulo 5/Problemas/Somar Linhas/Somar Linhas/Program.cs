
int[,] matriz = new int[3, 3];
int fila1=0,fila2=0,fila3 = 0;


for (int i = 0; i < matriz.GetLength(0); i++)
{
    Console.Clear();
    Console.WriteLine("Insira os números que pretende na primeira linha");
    matriz[i, 0] = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("Insira os números que pretende na segunda linha");
    matriz[i, 1] = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Insira os números que pretende na terceira linha");
    matriz[i, 2] = Convert.ToInt32(Console.ReadLine());
}
