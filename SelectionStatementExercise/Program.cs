using System.Runtime.InteropServices;

namespace SelectionStatementExercise
{
    public class Program
    {


        //string ageInput = Console.ReadLine();

        //if (int.TryParse(ageInput, out yourAge)) 
        //{
        //    realAge = true;
        //}
        //else
        //{
        //    Console.WriteLine("Please enter a valid age");
        //}


        static void Main(string[] args)
        {
            //--------------exercise 1-------------------
            var randomNumber = new Random();
            var favNumber = randomNumber.Next(1, 1000);

            string userInput;
            int userOutput;

            do
            {
                Console.WriteLine("Guess what my favorite number is");
                userInput = Console.ReadLine();

                //if (userInput == null || userInput == "")
                //{
                //    Console.WriteLine("Not a valid input. Please Try again later");
                //}

                if (int.TryParse(userInput, out userOutput))
                {


                    if (userOutput == favNumber)
                    {
                        Console.WriteLine("You guessed the number!");
                    }
                    else if (userOutput > favNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else if (userOutput < favNumber)
                    {
                        Console.WriteLine("Too Low");
                    }

                }

                else
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                }

            } while (userOutput != favNumber);
            //-------------------------------------------

            //--------------exercise 2-------------------

            Console.WriteLine("What is your favorite subject");
            string userInput2 = Console.ReadLine();

            switch (userInput2.ToLower())
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
                    Console.WriteLine($"learning is fun, I have not heard of the subject {userInput2} before.");
                    break;
            }

        }

    }
}
