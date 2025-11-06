using OefAthlete.Models;

namespace OefAthlete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Athlete fastestRunner = new Athlete("Dummy", double.PositiveInfinity);
            do 
            {
                Console.Write("Naam: ");
                string nameInput = Console.ReadLine();
                if (nameInput.Equals("STOP"))
                {
                    break;
                }
                Console.Write("Looptijd: ");
                int.TryParse(Console.ReadLine(), out int secondsInput);
                Athlete newAthlete = new Athlete(nameInput, secondsInput);
                if (newAthlete != null && newAthlete.RunTime < fastestRunner.RunTime)
                {
                    fastestRunner = newAthlete;
                }
            }   
            while (true); // Untill input is "STOP"
            Console.WriteLine(fastestRunner.ToString());
        }
    }
}
