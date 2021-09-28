using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHud1._0
{
    class Program
    {
        static int health;
        static int score;
        static float lives;
        

        static void ShowHud()
        {
            



            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("><><><><><><><><><><><><");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("NELNOR");
            Console.WriteLine("Health " + health);
            Console.WriteLine("Score " + score);
            Console.WriteLine("Lives " + lives);
            Console.WriteLine("><><><><><><><><><><><><");
            Console.ResetColor();
            Console.WriteLine(" ");
            Console.ReadKey(true);



        }


        // Damage Calculator
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        // Multiplyer for high score
        static void AddScore(int enemypoints, int multiply)
        {
            score = score * multiply;

            score = score + enemypoints;
        }

        static void Life()
        {
            if (health >= 0)
            {
                lives = lives - 1;
            }
        }

       
        
           
                   

        






        // Hud for gameplay, updated after changes.
        
        // Shows the HUD ^
        static void Main(string[] args)

        {
            lives = 3;
            health = 100;
            score = 0;
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Synth Fighters - Asthectic Protectors");
            Console.ReadKey(true);
            //
            Console.WriteLine("PRESS START");
            Console.ReadKey(true);
            Console.ResetColor();
            ShowHud();
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NELNOR Kills enemy!");
            AddScore(200, 1);
            ShowHud();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NELNOR encounters 2 more enemies!");
            Console.ReadKey(true);
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("takes half damage");
            Console.ReadKey(true);
            TakeDamage(50);
            ShowHud();
            Console.ReadKey(true);
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NELNOR Kills the two enemies");
            AddScore(400, 1);
            ShowHud();
            Console.ReadKey(true);
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NElNOR picks up X2 score multiplier");
            Console.ReadKey(true);
            Console.WriteLine("4 enemies apear! unfourtnuetly NELNOR has died");
            TakeDamage(50);
            Life();
            ShowHud();
            Console.ReadKey(true);
            








        }








    }

}


