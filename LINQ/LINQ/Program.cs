using System.Globalization;
using CsvHelper;
using LINQ;

internal class Program
{
    static void Main(string[] args)
    {
        string csvPath = @"D:\REPO\TextFiles\googleplaystore1.csv";
        var googleApps = LoadGoogleAps(csvPath);

        //Display(googleApps);
        //GetData(googleApps);
        //ProjectData(googleApps);
        //DivideData(googleApps);
        //OrderData(googleApps);
        //DataSetOperation(googleApps);
        //DataVerivication(googleApps);
        //GroupData(googleApps);
        GroupDataOperations(googleApps);
    }

    static void GroupDataOperations(IEnumerable<GoogleApp> googleApps)
    {
        var categoryGroup = googleApps.GroupBy(g => g.Category);
            //.Where(g => g.Min(a => a.Reviews) >= 10);

        foreach (var group in categoryGroup)
        {
            var averageReviews =  group.Average(g => g.Reviews);
            var minReviews = group.Min(g => g.Reviews);
            var maxReviews = group.Max(g => g.Reviews);

            var reviewsCount = group.Sum(g => g.Reviews);


            var allAppsFromGroupHaveRatingOfThree = group.All(a => a.Rating > 3.0);

            Console.WriteLine($"Category: {group.Key}");
            Console.WriteLine($"averageReviews: {averageReviews}");
            Console.WriteLine($"minReviews: {minReviews}");
            Console.WriteLine($"maxReviews: {maxReviews}");
            Console.WriteLine($"reviewsCount: {reviewsCount}");
            Console.WriteLine($"allAppsFromGroupHaveRatingOfThree: {allAppsFromGroupHaveRatingOfThree}");
            Console.WriteLine($"-----------------------------------");
        }
    }

    static void GroupData(IEnumerable<GoogleApp> googleApps)
    {
        var categoryGroup = googleApps.GroupBy(a => new { a.Category, a.Type });

        foreach(var group in categoryGroup)
        {
            //var apps = artAndDesignGroup.Select(e => e);
            var apps = group.ToList();
            Display(apps);
        }

        //var artAndDesignGroup = categoryGroup.First(g => g.Key == Category.ART_AND_DESIGN);

        //var apps = artAndDesignGroup.Select(e => e);
        //var apps = artAndDesignGroup.ToList();
        //Display(apps);
    }

    static void DataVerivication(IEnumerable<GoogleApp> googleApps)
    {
        var allOperatorResult = googleApps.Where(app => app.Category == Category.WEATHER)
            .All(app => app.Reviews > 10);

        Console.WriteLine(allOperatorResult);

        var anyOperatorResult = googleApps.Where(app => app.Category == Category.WEATHER)
            .Any(app => app.Reviews > 3000000);

        Console.WriteLine(anyOperatorResult);
    }

    static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
    {
        var paidAppsCategories = googleApps.Where(app => app.Type == LINQ.Type.Paid)
            .Select(app => app.Category).Distinct();

        //Console.WriteLine($"Paid apps categories: {string.Join(", ", paidAppsCategories) }");

        var setA = googleApps.Where(app => app.Rating > 4.7 && app.Type == LINQ.Type.Paid && app.Reviews > 1000);

        var setB = googleApps.Where(app => app.Name.Contains("Pro") && app.Rating > 4.6 && app.Reviews > 10000);

        //Display(setA);

        //Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

        //Display(setB);

        //var appsUnion = setA.Union(setB);               //A i B
        //Console.WriteLine("Apps Union:");
        //Display(appsUnion);

        //var appsIntersect = setA.Intersect(setB);               //wspolne A i B
        //Console.WriteLine("Apps Intersect:");
        //Display(appsIntersect);

        var appsExcept = setA.Except(setB);               //sa w A ale nie są w B
        Console.WriteLine("Apps Except:");
        Display(appsExcept);
    }

    static void OrderData(IEnumerable<GoogleApp> googleApps)
    {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);
        //Display(highRatedBeautyApps);

        var sortedResult = highRatedBeautyApps.OrderByDescending(app => app.Rating)
            .ThenBy(app => app.Name);
        Display(sortedResult);

    }

    static void DivideData(IEnumerable<GoogleApp> googleApps)
    {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);
        //Display(highRatedBeautyApps);

        //var first5HighRatedBeautyApps = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000);
        //Display(first5HighRatedBeautyApps);

        var skippedResults = highRatedBeautyApps.Skip(5);
        Display(skippedResults);
    }

    static void ProjectData(IEnumerable<GoogleApp> googleApps)
    {
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
        var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);

        var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto()
        {
            Reviews = app.Reviews,
            Name = app.Name
        });

        foreach (var dto in dtos)
        {
            Console.WriteLine($"{dto.Name}: {dto.Reviews}");
        }

        var annonymousDtos = highRatedBeautyApps.Select(app => new
        {
            Reviews = app.Reviews,
            Name = app.Name,
            Category = app.Category
        });

        foreach (var dto in annonymousDtos)
        {
            Console.WriteLine($"{dto.Name}: {dto.Reviews}; {dto.Category}");
        }

        Console.WriteLine(string.Join(", ", highRatedBeautyAppsNames));

        var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
        Console.WriteLine(string.Join("; ", genres));
    }

    static void GetData(IEnumerable<GoogleApp> googleApps)
    {
        var highRatedApps = googleApps.Where(app => app.Rating > 4.6);
        var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.6 && app.Category == Category.BEAUTY);
        Display(highRatedBeautyApps);

        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

        var firstHighRatedBeautyApp = highRatedBeautyApps.SingleOrDefault(app => app.Reviews < 50);             //First , Last
        Console.WriteLine(firstHighRatedBeautyApp);
    }

    static void Display(IEnumerable<GoogleApp> googleApps)
    {
        foreach (var googleApp in googleApps)
        {
            Console.WriteLine(googleApp);
        }

    }
    static void Display(GoogleApp googleApp)
    {
        Console.WriteLine(googleApp);
    }

    static List<GoogleApp> LoadGoogleAps(string csvPath)
    {
        using (var reader = new StreamReader(csvPath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<GoogleAppMap>();
            var records = csv.GetRecords<GoogleApp>().ToList();
            return records;
        }

    }

}