namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration syntax

            dogName = "Rexie"; // Initialized --- assigning a value

            int dogAge = 2; // Declaring and initializing variable at the same time

            char firstInitial = 'R';

            bool isThirsty = true;

            double dogWeight = 45.5;

            decimal dogHeight = 14.5m ;


            Console.WriteLine($"My dog's name is {dogName}, her first initial is {firstInitial}. She is {dogAge} years old.");
            Console.WriteLine($"She weighs {dogWeight} pounds and she is {dogHeight} inches tall. ");
            Console.WriteLine($"It is {isThirsty}, she is always thirsty.");
        }
    }
}
