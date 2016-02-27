using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Menu
    {
        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Welcome to Sample RPG Game\n");
                Console.WriteLine("1 - Start Game");
                Console.WriteLine("2 - Exit Game");
                Console.Write("Your Choice : ");
                String result = Console.ReadLine();
                if (result.Trim() == "2") exit = true;
                if (result.Trim() == "1") DoGame();
            } while (!exit);
        }

        private void DoGame()
        {
            bool exit = false;
            do
            {
                CharacterClass cha;
                Console.WriteLine();
                Console.WriteLine("Select your charachter type\n");
                Console.WriteLine("1 - Warrior");
                Console.WriteLine("2 - Wizard");
                Console.Write("Your Choice : ");
                String result = Console.ReadLine();
                if (result.Trim() == "1")
                {
                    cha = new Warrior();
                    if (BuildCharachter(cha)) exit = true;
                }
                if (result.Trim() == "2")
                {
                    cha = new Wizard();
                    if (BuildCharachter(cha)) exit = true;
                }
            } while (!exit);
        }

        private bool BuildCharachter(CharacterClass cha)
        {
            Console.Write("Charachter name : ");
            cha.Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(cha.ToString());
            while (true)
            {
                Console.WriteLine("");
                Console.Write("Keep Charachter (y/n)? ");
                string result = Console.ReadLine();
                if (result.Trim().ToUpper() == "Y") return true;
                if (result.Trim().ToUpper() == "N") return false;
            }

        }
    }
}
