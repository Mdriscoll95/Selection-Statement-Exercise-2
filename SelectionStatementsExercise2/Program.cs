namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
            case "Math":
                    Console.WriteLine("Math is awesome");
               break;
            case "science":
                    Console.WriteLine("Ah I havent taken science before");
                break;
            case "history":
                Console.WriteLine("I love history");
                break;
             case "French":
                Console.WriteLine("c'est Bien");
                break;
             case "English":
                Console.WriteLine("its alright");
                break;
             case "theatre arts":
                Console.WriteLine("love it");
                break;

            }


        }
    }
}