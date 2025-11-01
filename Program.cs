using System;

namespace OpamHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte magicNumber;
            string moreLess;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вітаю в грі де потрібно вгадати число! (У тебе 3 спроби)");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Задай діапазон пошуку! (від 10 до 255)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            magicNumber = GetMagicNumber(Convert.ToInt32(Console.ReadLine()));
            Console.ResetColor();
            
            
            byte attempts = 3;
            while (attempts > 0)
            {

                
                Console.Write("Введіть число: ");
                int x = Convert.ToInt32(Console.ReadLine());
                
                if (x > magicNumber) moreLess = "менше";
                else moreLess = "більше";
                
                attempts--;
                
                if (x == magicNumber)
                {
                    WinGame(attempts);
                    break;
                }

                if (attempts == 0)
                {
                    LoseGame();
                    break;
                }
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Спробуйте знову... (Спроб: {attempts}).\nЗагадане число {moreLess}");
                Console.ResetColor();
            }

        }

        private static void WinGame(byte attempts)
        {
            if (attempts != 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Вітаю, ти вгадав число з {3 - attempts} спроби!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("А ти молодчина, вгадав з першої спроби!");
                Console.ResetColor();
            }
        }

        private static void LoseGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажаль ти програв!");
            Console.ResetColor();
        }

        private static byte GetMagicNumber(int  number)
        {
            if(number > 255) number = 255;
            if (number < 10) number = 10;
            Console.ResetColor();
            byte magicNumber = (byte)new Random().Next(0, number);
            Console.WriteLine(magicNumber);
            return magicNumber;
        }
    }
};

