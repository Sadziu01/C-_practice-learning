internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Insert input:");
        string userInput = Console.ReadLine();

        //SubString(userInput);
        //Replace(userInput);
        //Modify(userInput);
        //AlterTextCase(userInput);
        //Split(userInput);
        CheckString(userInput);

    }

    private static void CheckString(string userInput)
    {
        bool isTextFile = userInput.EndsWith(".txt");
        bool startsWithDocPrefix = userInput.StartsWith("doc-");

        bool containsText = userInput.Contains("text", StringComparison.CurrentCultureIgnoreCase);

        Console.WriteLine(isTextFile);
        Console.WriteLine(startsWithDocPrefix);
        Console.WriteLine(containsText);
    }

    private static void Split(string userInput)
    {
        string[] inputParts = userInput.Split(" ");
        string firstname = inputParts[0];
        string lastname = inputParts[inputParts.Length - 1];

        Console.WriteLine(firstname + " " + lastname);
    }

    private static void AlterTextCase(string userInput)
    {
        string upperCased = userInput.ToUpper();
        Console.WriteLine(upperCased);

        string lowerCased = userInput.ToLower();
        Console.WriteLine(lowerCased);
    }

    private static void Modify(string userInput)
    {
        //string removedString = userInput.Remove(5);
        //string insertedString = userInput.Insert(5, "INSERT");

        string trimmedString = userInput.Trim();
        Console.WriteLine(trimmedString);
    }

    private static void Replace(string userInput)
    {
        string template = "Hello {name}, how are you?";
        string output = template.Replace("{name}", userInput);
        Console.WriteLine(output);
    }

    private static void SubString(string userInput)
    {
        if (userInput.Length > 10)
        {
            string startSubString = userInput.Substring(0, 10);
            string endSubString = userInput.Substring(userInput.Length - 10);
            Console.WriteLine($"{startSubString} ... {endSubString}");
            Console.WriteLine(userInput);
        }
    }
}