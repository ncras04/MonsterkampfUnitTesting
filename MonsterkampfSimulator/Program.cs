namespace MonsterkampfSimulator
{
    internal class Program
    {

        public static Monster player1;
        public static Monster player2;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool CheckValidMonster(Monster _monster1, Monster _monster2)
        {
            if (_monster1 == _monster2)
            {
                return false;
            }
            else return true;
        }


    }
}
