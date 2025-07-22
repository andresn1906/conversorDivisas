using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        Decimal valorCop = 0m;
        Decimal USD = 0.00026m;
        Decimal GBP = 0.00020m;
        Decimal EUR = 0.00024m;
        Decimal JP = 0.038m;
        Decimal CH = 0.0019m;
        Decimal MX = 0.0045m;
        Decimal BR = 0.0014m;

        Console.WriteLine("Conversor de divisas a diferentes formatos por países:");
        Console.ReadKey();

        Console.WriteLine('Valor de COP a convertir: ');
        valorCop = Convert.ToDecimal(Console.ReadLine());
        
        ($"Colombia (moneda original): {valorCop.ToString("C2", new CultureInfo("es-CO"))}")
        Decimal valorUSD = valorCop * USD;
        Console.WriteLine($"Estados Unidos: {valorUSD.ToString("C2", new CultureInfo("en-US"))}");
        Decimal valorGBP = valorCop * GBP;
        Console.WriteLine($"Reino Unido: {valorGBP.ToString("C2", new CultureInfo("en-GB"))}");
        Decimal valorEUR = valorCop * EUR;
        Console.WriteLine($"Francia: {valorEUR.ToString("C2", new CultureInfo("fr-FR"))}");
        Decimal valorJP = valorCop * JP;
        Console.WriteLine($"Japón: {valorJP.ToString("C2", new CultureInfo("ja-JP"))}");
        Decimal valorCH = valorCop * CH;
        Console.WriteLine($"China: {valorCH.ToString("C2", new CultureInfo("zh-CN"))}");
        Decimal valorBR = valorCop * BR;
        Console.WriteLine($"Rusia: {valorBR.ToString("C2", new CultureInfo("ru-RU"))}");
        Decimal valorMX = valorCop * MX;
        Console.WriteLine($"México: {valorMX.ToString("C2", new CultureInfo("es-MX"))}");
        
        Console.ReadKey();
    }
}