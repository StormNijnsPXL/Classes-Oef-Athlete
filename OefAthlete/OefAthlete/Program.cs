using OefAthlete.Models;

namespace OefAthlete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Naam: ");
            string nameInput = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int secondsInput);
            Athlete newAthlete = new Athlete(nameInput, secondsInput);

        }
    }
}
