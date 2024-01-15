namespace SelectionStatementsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome! Keep solving those equations!");
                    break;
                case "english":
                    Console.WriteLine("Great choice! Improve your language skills and enjoy reading!");
                    break;
                case "science":
                    Console.WriteLine("Science is fascinating! Explore the wonders of the natural world.");
                    break;
                case "history":
                    Console.WriteLine("History is rich with stories! Discover the past and learn from it.");
                    break;
                case "art":
                    Console.WriteLine("Art is a wonderful expression! Keep creating and exploring your creativity.");
                    break;
                default:
                    Console.WriteLine($"I'm not familiar with {favoriteSubject}, but it sounds interesting!");
                    break;
            }

            // Extra Switch Statement Practice (Bartender Kata)
            Console.WriteLine("\nBartender Kata:");

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            switch (age)
            {
                case int a when a < 18:
                    Console.WriteLine("Sorry, you're too young to drink.");
                    break;
                case int a when a >= 18 && a < 21:
                    Console.WriteLine("You can have some non-alcoholic beverages.");
                    break;
                default:
                    Console.WriteLine("What would you like to drink?");
                    break;
            }
        }
    }
}