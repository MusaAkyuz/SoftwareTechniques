using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Creater
    {
        public Game FactoryMethod(Games gameType)
        {
            Game game = null;
            switch (gameType)
            {
                case Games.Atari:
                    game = new Atari();
                    break;
                case Games.PC:
                    game = new PC();
                    break;
                default: 
                    throw new ArgumentException();
            }
            return game;
        }
    }

    public enum Games
    {
        Atari,
        PC
    }
}
