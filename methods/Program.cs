using System.Reflection.Metadata.Ecma335;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DrawChoice();

            while (!Joke())
                Console.Clear();
        }

        public static void TypeText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();

        }

        public static void DrawChoice()
        {
            int drawChoice;
            Console.WriteLine("              What would you like to draw?              ");
            Console.WriteLine("  1. Bus       2. Apple       3. Sword       4. Clover  ");
            Console.WriteLine();
            Console.Write("Choose: ");
            while ((!Int32.TryParse(Console.ReadLine(), out drawChoice)) || drawChoice >= 5)
            {
                Console.WriteLine("Invalid Input.");
                Console.WriteLine();
                Console.Write("Choose: ");
            }
            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to draw your ASCII art.");
            Console.ReadLine();
            Console.Clear();
            if (drawChoice == 1)
                DrawBus();
            if (drawChoice == 2)
                DrawApple();
            if (drawChoice == 3)
                DrawSword();
            if (drawChoice == 4)
                DrawClover();
        }

        static void DrawBus()
        {
            Console.WriteLine("--------------BUS--------------");
            Console.WriteLine();
            Console.WriteLine("                          __\r\n .-----------------------'  |\r\n/| _ .---. .---. .---. .---.|\r\n|j||||___| |___| |___| |___||\r\n|=|||=======================|\r\n[_|j||(O)\\__________|(O)\\___] hjw\r\n");
        }

        static void DrawApple()
        {
            Console.WriteLine("--------------APPLE--------------");
            Console.WriteLine();
            Console.WriteLine(" ,--./,-.\r\n/,-._.--~\\\r\n __}  {\r\n\\`-._,-`-,\r\n `._,._,'   hjw\r\n");
        }

        static void DrawSword()
        {
            Console.WriteLine("--------------SWORD--------------");
            Console.WriteLine();
            Console.WriteLine("        )         \r\n          (            \r\n        '    }      \r\n      (    '      \r\n     '      (   \r\n      )  |    ) \r\n    '   /|\\    `\r\n   )   / | \\  ` )   \r\n  {    | | |  {   \r\n }     | | |  .\r\n  '    | | |    )\r\n (    /| | |\\    .\r\n  .  / | | | \\  (\r\n}    \\ \\ | / /  .        \r\n (    \\ `-' /    }\r\n '    / ,-. \\    ' \r\n  }  / / | \\ \\  }\r\n '   \\ | | | /   } \r\n  (   \\| | |/  (\r\n    )  | | |  )\r\n    .  | | |  '\r\n       J | L\r\n /|    J_|_L    |\\\r\n \\ \\___/ o \\___/ /\r\n  \\_____ _ _____/\r\n        |-|\r\n        |-|\r\n        |-|\r\n   hs  ,'-'.\r\n       '---'\r\n");
        }

        static void DrawClover()
        {
            Console.WriteLine("--------------CLOVER--------------");
            Console.WriteLine();
            Console.WriteLine("                 ***          ***\r\n              ***....**     **...***\r\n             **........** **.......**\r\n      ***    **..........*.........**    ***\r\n   **.....**  **..................**  **.....**\r\n **.........**  **..............**  **.........**\r\n*..............*   *..........*   *..............*\r\n **..............*   *......*   *..............**\r\n   **..............** *....* **..............**\r\n     *......................................*\r\n   **..............**........**..............**\r\n **..............*    *....*....*..............**\r\n*..............*    *........* ...*..............*\r\n **.........**    *............* ...**.........**\r\n   **.....**   **...............**....**.....**\r\n      ***    **...................**.....***\r\n           **...........*...........**....*\r\n            **.........* *.........** *......*..*..*\r\n              *......**   **......*     *........*\r\n                **  *       * **           *...*\r\n                                              *");
        }



        public static bool Joke()
        {
            TypeText("Knock Knock");
            string resp1 = Console.ReadLine().Trim().ToLower();
            if ((resp1 != "whos there?") || (resp1 != "who's there") || (resp1 != "whos there") || (resp1 != "who's there?"))
            {
                return false;
            }
            TypeText("Bat.");
            string resp2 = Console.ReadLine().Trim().ToLower();
            if ((resp2 != "bat who") || (resp2 != "bat who?"))
            {
                return false;
            }
            TypeText("Bat you weren't expecting me today.");
            return true;
        }

    }
}
