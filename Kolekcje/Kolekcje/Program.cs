using Classes;
using System.Linq;

internal class Program
{

    static void DisplayElements(List<int> list)
    {
        Console.WriteLine("**List**");
        foreach (int i in list)
        {
            Console.Write(i + ", ");
        }
        Console.WriteLine();
    }

    static List<Person> GetEmpolyees()
    {
        List<Person> employees = new List<Person>()
        {
        new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
        new Person(new DateTime(1995, 6, 3), "John", "Wick"),
        new Person(new DateTime(1996, 4, 2), "Bob", "Wick"),
        new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
        new Person(new DateTime(2000, 2, 2), "John", "Smith"),
        new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
        new Person(new DateTime(2003, 2, 2), "Ed", "Smith"),

        };
        return employees;
    }



    private static void Main(string[] args)
    {
        //List<int> intList = new List<int>() {  6, 1, 20, 3, 45, 60, 100, 2};

        //DisplayElements(intList);

        //Console.WriteLine("New element: ");
        //string userInput = Console.ReadLine();
        //int intValue = int.Parse(userInput);

        //intList.Add(intValue);

        //DisplayElements(intList);

        //Console.WriteLine("SORT");
        //intList.Sort();

        //DisplayElements(intList);      



        List<Person> employees = GetEmpolyees();

        List<Person> youngEmployyes = employees.Where(e => e.GetDateOfBirth() > new DateTime(2000, 1, 1)).ToList();

        Console.WriteLine($"Young employyes count: { youngEmployyes.Count }");

   

        Person bob = youngEmployyes.FirstOrDefault(e => e.FirstName == "Bob");

        if (bob != null)
        {
            bob.SayHi();
        }
        else
        {
            Console.WriteLine("Error");
        }



    }
}