int numeros, media, total, vezes;
numeros = 0;

media = 0;

total = 0;

vezes = 0;



Console.WriteLine("Insira uma série de números inteiros positivos, caso queria terminar a lista digite 0");



while (true)

{

    numeros = Convert.ToInt32(Console.ReadLine());

    if (numeros == 0)

    {

        break;

    }

    else if (numeros != 0)

    {

        total = total + numeros;

        vezes = vezes + 1;

    }

}

media = total / vezes;

Console.WriteLine("A média total da lista de números é " + media);