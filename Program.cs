using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHud1._0
{
    class Program
    {
        //components ..... - values
        static int health;
        //static int shield;
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
            //Console.WriteLine("Shield " + shield);
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
            //method exclusive integer
            //int remainingDamage;
            //hits shield first
            //shield = shield - damage;
            //if (shield <= 0) 
            //{
               // remainingDamage = damage - shield;
               // shield = 0;
                //whatever damage is left will be removed off health when shiled is broken....
                health = health - damage;
           //}
           //if health is 0, checks for lives removes and if lives are above or equal to 0 health will be restored....
            if (health <= 0)
            {
                health = 0;
                lives = lives - 1;
                if (lives >= 0)
                {
                    health = 100;
                }
            }
            
        }

        // Multiplyer for high score
        static void AddScore(int enemypoints, int multiply)
        {
            score = score * multiply;

            score = score + enemypoints;
        }

        //static void Life()
        //{
            //if (health >= 0)
            //{
                //lives = lives - 1;
            //}
        //}

       
        
           
                   

        






        // Hud for gameplay, updated after changes.
        
        // Shows the HUD ^
        static void Main(string[] args)

        {
            lives = 3;
            //shield = 50;
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
            Console.WriteLine("NELNOR Kills enemy! 200 points!");
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
            Console.WriteLine("NELNOR Kills the two enemies,  400 points!");
            AddScore(400, 1);
            ShowHud();
            Console.ReadKey(true);
            //
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NElNOR picks up X2 score multiplier");
            //AddScore(400 * 1) + 200 = 600
            //AddScore(400(200x2 enemies) = 400 * 2(x2 multiplier)) = 800
            //800 + 600 = 1200
            //console is giving me 1600

            Console.ReadKey(true);
            Console.WriteLine("4 enemies apear!");
            Console.WriteLine("NELNOR killed two but was slayn by the other two");
            AddScore(200, 2);
            Console.ReadKey(true);
            Console.WriteLine("Restart!");
            TakeDamage(50);
            //Life();
            ShowHud();
            Console.ReadKey(true);
            








        }








    }

}


