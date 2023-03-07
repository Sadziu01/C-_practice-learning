internal class Program
{
    static void ReadFiles()
    {
        var document1 = File.ReadAllText(@"D:\TextFiles\document1.txt");
        var document2 = File.ReadAllLines(@"D:\TextFiles\document2.txt");

        var document2String = string.Join(Environment.NewLine, document2);

        Console.WriteLine(document1);

        Console.WriteLine("------------");

        Console.WriteLine(document2String);
    }

    static void GenerateDocuments()
    {
        Console.WriteLine("Insert name:");
        var name = Console.ReadLine();

        Console.WriteLine("Insert orderNumber:");
        var orderNumber = Console.ReadLine();

        var template = File.ReadAllText(@"D:\TextFiles\template.txt");
        var document = template.Replace("{name}", name)
            .Replace("{orderNumber}", orderNumber)
            .Replace("{dateTime}", DateTime.Now.ToString());

        File.WriteAllText($"D:/TextFiles/document-{name}.txt", document);
    }

    static void ScanAndAppend()
    {
        var files = Directory.GetFiles(@"D:\TextFiles\Append\", "*.txt", SearchOption.AllDirectories);
        foreach(var file in files)
        {
            File.AppendAllText(file, Environment.NewLine + "All rights reserved");
        }
    }

    private static void Main(string[] args)
    {
        //ReadFiles();
        //GenerateDocuments();
        ScanAndAppend();

    }
}