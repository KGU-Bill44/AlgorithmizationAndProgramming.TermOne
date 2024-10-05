public class Starter
{
    public static void Main(string[] args)
    {

        for (int globalIteretion = 0; globalIteretion < 5; globalIteretion++)
        {
            for (int innerIteretion = 0; innerIteretion < globalIteretion; innerIteretion++)
            {
                Console.Write(" " + 2);
            }
            Console.WriteLine(" " + 3);

            int startPosition = 10 - globalIteretion;
            for (int innerIteretion = 0; innerIteretion < globalIteretion; innerIteretion++)
            {
                Console.Write(" " + startPosition);
                startPosition = startPosition + 1;
            }
            Console.WriteLine(" " + 0);
        }
    }
}