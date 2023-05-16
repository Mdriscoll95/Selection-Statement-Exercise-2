namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string? subject = Console.ReadLine();

            switch (subject.ToLower())
            {
            case "math":
                    Console.WriteLine("Math is awesome");
               break;
            case "science":
                    Console.WriteLine("Ah I havent taken science before");
                break;
            case "history":
                Console.WriteLine("I love history");
                break;
             case "french":
                Console.WriteLine("c'est Bien");
                break;
             case "english":
                Console.WriteLine("its alright");
                break;
             case "theatre arts":
                Console.WriteLine("love it");
                break;
             default:
                    Console.WriteLine("i forgot about that one");
                    break;


            }


        }
    }
}