using System;

class Programa
{
    static void Main()
    {
        Console.Write("Digite para verificar se pertence a sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Número inválido.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        if (numero < 0) return false;

        int a = 0;
        int b = 1;

        while (a < numero)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a == numero;
    }
}