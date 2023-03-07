using DataConnecting;
using Newtonsoft.Json;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        var people = LoadPerson();
        var addresses = LoadAddresses();

        var joinedData = people.Join(addresses,
            p => p.Id,
            a => a.PersonId,
            (person, address) => new { person.Name, address.Street, address.City});

        foreach (var element in joinedData)
        {
            Console.WriteLine($"Name: {element.Name}, address: {element.Street}, city: {element.City}");
        }


        //foreach (var p in people)
        //{
        //    var address = addresses.FirstOrDefault(a => a.PersonId == p.Id);
        //    if(address != null)
        //    {
        //        Console.WriteLine($"Name: {p.Name}, address: {address.Street}, city: {address.City}");
        //    }

        //}


        var joinedDataGroup = people.GroupJoin(addresses,
            p => p.Id,
            a => a.PersonId,
            (person, addresses) => new { person.Name, Addressess = addresses });

        foreach (var element in joinedDataGroup)
        {
            Console.WriteLine($"Name: {element.Name}");
            foreach(var address in element.Addressess)
            {
                Console.WriteLine($"\t City: {address.City}, street: {address.Street}");
            }
        }
    }

    private static List<Person> LoadPerson()
    {
        var currentDir = Directory.GetCurrentDirectory();
        var jsonFullPath = Path.GetRelativePath(currentDir, "Person/People.json");

        var json = File.ReadAllText(jsonFullPath);

        return JsonConvert.DeserializeObject<List<Person>>(json);
    }

    private static List<Address> LoadAddresses()
    {
        var currentDir = Directory.GetCurrentDirectory();
        var jsonFullPath = Path.GetRelativePath(currentDir, "Person/Addresses.json");

        var json = File.ReadAllText(jsonFullPath);

        return JsonConvert.DeserializeObject<List<Address>>(json);
    }


}