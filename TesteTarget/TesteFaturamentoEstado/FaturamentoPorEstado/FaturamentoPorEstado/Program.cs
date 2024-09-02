using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var faturamento = new Dictionary<string, decimal>
        {
            {"SP", 67836.43m},
            {"RJ", 36678.66m},
            {"MG", 29229.88m},
            {"ES", 27165.48m},
            {"Outros", 19849.53m}
        };

        decimal totalFaturamento = 0;
        foreach (var estado in faturamento)
        {
            totalFaturamento += estado.Value;
        }

        foreach (var estado in faturamento)
        {
            decimal percentual = (estado.Value / totalFaturamento) * 100;
            Console.WriteLine($"Estado: {estado.Key}, Percentual: {percentual:F2}%");
        }
    }
}