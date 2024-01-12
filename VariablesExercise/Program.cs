namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string newCar = "Jeep Trackhawk";
            int carDoor = 4;
            char carRatings = 'A';
            bool isSuv = true;
            double topSpeed = 2.8;
            decimal carPrice = 100000.58m;

            Console.WriteLine($"My dream car is the {newCar}, it is a {carDoor} door {isSuv}.");
            Console.WriteLine($"It has a top speed of {topSpeed} mpr");
            Console.WriteLine($"It is far from cheap and has an msrp of {carPrice}.");
            Console.WriteLine($"It has and excelent rating of {carRatings} on Autoreviews");
        }
    }
}
