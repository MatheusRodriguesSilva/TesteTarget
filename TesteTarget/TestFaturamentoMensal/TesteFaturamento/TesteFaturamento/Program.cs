using System;

class Program
{
    static void Main()
    {
        double[] faturamentoDiario = { 150.0, 200.0, 250.0, 180.0, 220.0, 270.0, 210.0, 190.0, 230.0, 280.0, 260.0, 240.0 };

        if (faturamentoDiario.Length == 0)
        {
            Console.WriteLine("Nenhum dado de faturamento disponível.");
            return;
        }

        double menorFaturamento = faturamentoDiario[0];
        double maiorFaturamento = faturamentoDiario[0];
        double somaFaturamento = 0.0;

        foreach (double faturamento in faturamentoDiario)
        {
            if (faturamento < menorFaturamento)
                menorFaturamento = faturamento;

            if (faturamento > maiorFaturamento)
                maiorFaturamento = faturamento;

            somaFaturamento += faturamento;
        }

        double mediaMensal = somaFaturamento / faturamentoDiario.Length;

        int diasAcimaDaMedia = 0;
        foreach (double faturamento in faturamentoDiario)
        {
            if (faturamento > mediaMensal)
                diasAcimaDaMedia++;
        }

        Console.WriteLine($"Menor valor de faturamento: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
