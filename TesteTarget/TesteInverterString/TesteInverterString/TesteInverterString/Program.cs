using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        string saida = InverterString(entrada);

        Console.WriteLine("String invertida: " + saida);
    }

    static string InverterString(string str)
    {
        char[] arr = str.ToCharArray();
        int inicio = 0;
        int fim = arr.Length - 1;

        while (inicio < fim)
        {
            // Troca os caracteres
            char temp = arr[inicio];
            arr[inicio] = arr[fim];
            arr[fim] = temp;

            // Move os índices
            inicio++;
            fim--;
        }

        return new string(arr);
    }
}