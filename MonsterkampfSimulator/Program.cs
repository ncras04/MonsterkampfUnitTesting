namespace MonsterkampfSimulator
{
    public class Program
    {

        public static Monster player1;
        public static Monster player2;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool CheckValidMonster(Monster _monster1, Monster _monster2)
        {
            if (_monster1.GetType() == _monster2.GetType())
            {
                Console.WriteLine("Monster are the same");
                return false;
            }
            Console.WriteLine("Different monsters!");
            return true;
        }


    }
}
