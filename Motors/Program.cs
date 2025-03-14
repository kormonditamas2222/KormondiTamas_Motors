namespace Motors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statisztika statisztika = new();
            statisztika.ReadFromFile("motors.txt");
            Console.WriteLine("Tartalmaz-e Bear 650-t: " + statisztika.Contains("Bear 650"));
            Console.WriteLine("Tartalmaz-e Ferrarit: " + statisztika.Contains("Ferrari"));
            Console.WriteLine("Összár: " + statisztika.SumPrices(statisztika.Motors));
            Console.WriteLine("Legrégebbi motor: " + statisztika.Oldest());
            Console.WriteLine("Royal Enfield összár: " + statisztika.SumBasedOnBrand("Royal Enfield"));
            statisztika.Sort();
        }
    }
}
