using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Decimal valor = 190605.557m;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Conversor de divisas a diferentes formatos por países:");
        Console.ReadKey();
        Console.WriteLine($"Estados Unidos: {valor.ToString("C2", new CultureInfo("en-US"))}");
        Console.WriteLine($"Reino Unido: {valor.ToString("C2", new CultureInfo("en-GB"))}");
        Console.WriteLine($"Francia: {valor.ToString("C2", new CultureInfo("fr-FR"))}");
        Console.WriteLine($"Japón: {valor.ToString("C2", new CultureInfo("ja-JP"))}");
        Console.WriteLine($"España: {valor.ToString("C2", new CultureInfo("es-ES"))}");
        Console.WriteLine($"Portugal: {valor.ToString("C2", new CultureInfo("pt-PT"))}");
        Console.WriteLine($"Italia: {valor.ToString("C2", new CultureInfo("it-IT"))}");
        Console.WriteLine($"China: {valor.ToString("C2", new CultureInfo("zh-CN"))}");
        Console.WriteLine($"Alemania: {valor.ToString("C2", new CultureInfo("de-DE"))}");
        Console.WriteLine($"Rusia: {valor.ToString("C2", new CultureInfo("ru-RU"))}");
        Console.WriteLine($"Colombia: {valor.ToString("C2", new CultureInfo("es-CO"))}");
        Console.WriteLine($"México: {valor.ToString("C2", new CultureInfo("es-MX"))}");
        Console.ReadKey();
    }
}