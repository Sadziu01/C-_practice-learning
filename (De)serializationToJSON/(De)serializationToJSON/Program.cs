using _De_serializationToJSON;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        //var player = new Player()
        //{
        //    Name = "Mario",
        //    Level = 1,
        //    HealthPoints = 100,
        //    Statistics = new List<Statistic>
        //    {
        //        new Statistic()
        //        {
        //            Name = "Strength",
        //            Points = 10,
        //        },

        //        new Statistic()
        //        {
        //            Name = "Intelligence",
        //            Points = 10,
        //        }
        //    }
        //};

        ////..
        //player.Level++;

        //string playerSerialized = JsonConvert.SerializeObject(player);

        //File.WriteAllText(@"D:\TextFiles\JSON\playerSerialized.json", playerSerialized);



        string playerSerialized = File.ReadAllText(@"D:\TextFiles\JSON\playerSerialized.json");
        Player player = JsonConvert.DeserializeObject<Player>(playerSerialized);
        
        Console.WriteLine(player.Name);
    }
}