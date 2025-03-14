namespace Motors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statisztika statisztika = new();
            statisztika.ReadFromFile("motors.txt");
            Console.WriteLine("Tartalmaz-e Harley-Davidsont: " + statisztika.Contains("Harley-Davidson"));
            Console.WriteLine("Tartalmaz-e Ferrarit: " + statisztika.Contains("Ferrari"));
            Console.WriteLine("Összár: " + statisztika.SumPrices(statisztika.Motors));
            Console.WriteLine("Legrégebbi motor: " + statisztika.Oldest());
            Console.WriteLine("Royal Enfield összár: " + statisztika.SumBasedOnBrand("Royal Enfield"));
            statisztika.Sort();
        }
    }
}
