
namespace AbstractFactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Creater creater = new Creater();
            Game atariOyunu = creater.FactoryMethod(Games.Atari);
            Game pcOyunu = creater.FactoryMethod(Games.PC);

            atariOyunu.Platform();
            pcOyunu.Platform();

            Console.Read();
        }
    }

    class Atari : Game
    {
        public override void Platform()
        {
            Console.WriteLine("Atari GAME");
        }
    }

    class PC : Game
    {
        public override void Platform()
        {
            Console.WriteLine("Pc GAME");
        }
    }
}