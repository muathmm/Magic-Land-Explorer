using Magic_Land_Explorer.Tasks;
using Newtonsoft.Json;

namespace Magic_Land_Explorer
{
     class Program
    {
        static void Main(string[] args)
        {
            // Ensure the file path is correctly referenced
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string jsonPath = Path.Combine(basePath, "data", "MagicLandData.json");

            if (!File.Exists(jsonPath))
            {
                Console.WriteLine($"Error: File not found at {jsonPath}");
                return;
            }

            string json = File.ReadAllText(jsonPath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Show filtered destinations (Duration < 100 minutes)");
                Console.WriteLine("2- Show destination with longest duration");
                Console.WriteLine("3- Sort destinations by name");
                Console.WriteLine("4- Show top 3 destinations by duration");
                Console.WriteLine("5- Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayFilteredDestinations(categories);
                        break;
                    case "2":
                        DisplayLongestDurationDestination(categories);
                        break;
                    case "3":
                        DisplaySortedDestinations(categories);
                        break;
                    case "4":
                        DisplayTop3DurationDestinations(categories);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void DisplayFilteredDestinations(List<Category> categories)
        {
            var destinations = FilterDestinations.GetFilteredDestinations(categories);
            foreach (var dest in destinations)
            {
                Console.WriteLine($"Name: {dest.Name}, Duration: {dest.Duration}");
            }
        }

        static void DisplayLongestDurationDestination(List<Category> categories)
        {
            var destination = LongestDuration.GetLongestDurationDestination(categories);
            if (destination != null)
            {
                Console.WriteLine($"Name: {destination.Name}, Duration: {destination.Duration}");
            }
        }

        static void DisplaySortedDestinations(List<Category> categories)
        {
            var destinations = SortByName.GetSortedDestinations(categories);
            foreach (var dest in destinations)
            {
                Console.WriteLine(dest.Name);
            }
        }

        static void DisplayTop3DurationDestinations(List<Category> categories)
        {
            var destinations = Top3Duration.GetTop3DurationDestinations(categories);
            foreach (var dest in destinations)
            {
                Console.WriteLine($"Name: {dest.Name}, Duration: {dest.Duration}");
            }
        }
    }
}
