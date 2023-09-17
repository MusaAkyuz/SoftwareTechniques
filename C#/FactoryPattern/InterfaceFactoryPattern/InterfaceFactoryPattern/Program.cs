namespace InterfaceFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Atari atari = new Atari();
            atari.Platform();

            PC pC = new PC();
            pC.Platform();
        }
    }

    interface Game
    {
        void Platform();
    }

    class Atari : Game
    {
        public void Platform()
        {
            Console.WriteLine("Atari game");
        }
    }

    class PC : Game
    {
        public void Platform()
        {
            Console.WriteLine("PC game");
        }
    }
}
