using Core.Utils;

namespace UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var parsedAmount = NumberPrompt("Please enter an integer number of dice to roll");
                var parsedSides = NumberPrompt("Please enter an integer for size of dice (e.g. 6 for a d6)");
                int total = 0;
                for (int i = 0; i < parsedAmount; i++)
                {
                    int confusion = DiceRoller.Dice(parsedSides);
                    total += confusion;
                    Console.WriteLine(confusion);
                }
                Console.WriteLine(total);
            }
        }
        public static int NumberPrompt(string prompt)
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            int parsedInput;
            if (input == "Exit")
            { 
                Environment.Exit(0);    
            }
            var isValidNum = int.TryParse(input, out parsedInput);
            if (isValidNum == false)
            {
                Console.WriteLine("No, please enter an integer, dickhead");
                return NumberPrompt(prompt);
            }
            else
            {
                return parsedInput;
            }
        }
    }
}