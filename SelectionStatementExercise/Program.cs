using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {

        

        static void Main(string[] args)
        {

            //exercise 1

            var randomNumber = new Random();
            var favNumber = randomNumber.Next(1, 1000);

            // The following code will allow the user to guess what your favorite number is
            // (be sure to prompt the user what to input):
            
            
            int userInput;
            do
            {
                Console.WriteLine("Guess what my favorite number is");
                userInput = int.Parse(Console.ReadLine());

                if (userInput == favNumber)
                {
                    Console.WriteLine("You guessed the number!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("Too Low");
                }

            }
            while (userInput != favNumber);

            //exercie 2

            Console.WriteLine("What is your favorite subject");
            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine("I love math");
                    break;

                case "science":
                    Console.WriteLine("I love science");
                    break;

                case "history":
                    Console.WriteLine("I love history");
                    break;

                case "english":
                    Console.WriteLine("I love english");
                    break;
                default:
                    Console.WriteLine($"learning is fun, I have not heard of the subject {userInput} before.");
                    break;
            }
    }
}
