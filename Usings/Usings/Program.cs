using Usings;

internal class Program
{
    private static void Main(string[] args)
    {
        var filePath = @"D:\REPO\TextFiles\file.txt";
        var fileContent = File.ReadAllText(filePath);


        using (var someClass = new SomeClass())
        {
            someClass.Say("Hi!");
        }

        using (var readFileStream = new FileStream(filePath, FileMode.Open))
        {
            //readFileStream.Read();
        }


        //...

        var writeFileStream = new FileStream(filePath, FileMode.Open);

        //writeFileStream.Write();
        writeFileStream.Close();



    }
}