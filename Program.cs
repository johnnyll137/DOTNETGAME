using System;
using System.Collections.Generic;

namespace Game
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("One day you are at your desk working on some code.");
            Console.WriteLine("You decide to take a break to get a quick snack.");
            Console.WriteLine("As you walk into the kitchen the lights go out!");
            Console.WriteLine("Then you hear a hissing sound coming from the refrigerator.");

            Hero hero = new Hero();

            Console.WriteLine("A mysterious unfriendly voice from the darkness asks you.");
            Console.WriteLine("What is your name human?!");

            hero.heroName = Console.ReadLine();

            Console.WriteLine("Think quick what are you going to do {0}???", hero.heroName);
            Console.WriteLine("You are very afraid and tired from coding all night.");

            hero.lives = 3;

            Console.WriteLine("You remember that you only have {0} lives in you.", hero.lives);
            Console.WriteLine("You see an odd figure standing in front of you...");
            Console.WriteLine("You look around and see 3 items you can use as weapons");

            //Weapons weapon = new Weapons();
            string[,] weapons1 = new string[3, 2] { { "Torch (it)", "1000" }, { "Freeze Ray (make harder)", "100" }, { "Candle (burn with prayers)", "500" } };
            string[,] weapons2 = new string[3, 2] { { "Toothpick (poker face)", "1000" }, { "Vodka (martini)", "100" }, { "Mouth (smash)", "500" } };
            string[,] weapons3 = new string[3, 2] { { "Spoon (her)", "1000" }, { "Whip Cream (on it)", "100" }, { "Fork (it)", "500" } };
            string[,] weapons4 = new string[3, 2] { { "ChopSticks", "1000" }, { "Wasabi", "100" }, { "Soy Sauce", "500" } };

            Alien alien = new Alien();
            alien.healthPoints = 1000;

            Alien alien1 = new Alien();
            //alien1.healthPoints = 1000;
            alien1.alienName = "Patrick the Dry Ice Cube";
            alien1.strenght = new string[1] { "Freeze (make harder)" };
            alien1.weakness = new string[2] { "Torch (it)", "Candle (burn with prayers)" };
            alien1.endMessage = "After you took care of the dastardly Dry Ice Cube, you need a quick drink to calm your nerves.  You already have some ice, so why not.  You reach for the olives and suddenly an old dry olive jumps out at you. ";

            Alien alien2 = new Alien();
            //alien2.healthPoints = 1000;
            alien2.alienName = "Gaga the Dry Olive";
            alien2.strenght = new string[1] { "Vodka (martini)" };
            alien2.weakness = new string[2] { "Toothpick (poker face)", "Mouth (smash)" };
            alien2.endMessage = "Applause to you!  You have dodged a bad romance with that lil’ monster.  Never mind the drink, how about something sweet?  You reach for some ice cream in the freezer, coast is clear, now for some cherries and nuts, nothing strange there.  Finally you can’t have a banana split without the…";

            Alien alien3 = new Alien();
            //alien3.healthPoints = 1000;
            alien3.alienName = "Anna the Banana Split";
            alien3.strenght = new string[1] { "Whip Cream (on it)" };
            alien3.weakness = new string[2] { "Spoon (her)", "Fork (it)" };
            alien3.endMessage = "So you might never look at a banana split the same way again, but at least you didn't slip.  Now might be a good time to call for some back up, but before you could reach it you see something rolling toward you!";

            Alien alien4 = new Alien();
            //alien4.healthPoints = 1000;
            alien4.alienName = "Sooki Sushi";
            alien4.strenght = new string[1] { "Wasabi" };
            alien4.weakness = new string[2] { "ChopSticks", "Soy Sauce" };
            alien4.endMessage = "With the evil sushi slayed, the lights turn back on and the hissing coming from your refrigerator stops.  You are free to snack and code another day. YOU SAVED THE EARTH!";


            var stages = new List<Tuple<Alien, Hero, string[,], string, string, string>>();
            stages.Add(Tuple.Create(alien1, hero, weapons1, alienDraw1(), alien1.alienName, alien1.endMessage));
            stages.Add(Tuple.Create(alien2, hero, weapons2, alienDraw2(), alien2.alienName, alien2.endMessage));
            stages.Add(Tuple.Create(alien3, hero, weapons3, alienDraw3(), alien3.alienName, alien3.endMessage));
            stages.Add(Tuple.Create(alien4, hero, weapons4, alienDraw4(), alien4.alienName, alien4.endMessage));

            foreach (var stage in stages)
            {
                //Moved to method stageCompleted
                stageCompleted(stage);
            }

        }

        public static bool stageCompleted(Tuple<Alien, Hero, string[,], string, string, string> stage)
        {
            Alien alien = new Alien();
            alien.healthPoints = 1000;

            //Define your variables
            var alien1 = stage.Item1;
            var hero = stage.Item2;
            var weapons1 = stage.Item3;
            var enemyDraw = stage.Item4;
            var alienName = stage.Item5;
            var endMessage = stage.Item6;

            while (alien.healthPoints > 0 && hero.lives > 0)
            {
                Console.WriteLine(alienName);
                Console.WriteLine(enemyDraw);

                Console.WriteLine(" Weapons: Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons1[0, 0], weapons1[1, 0], weapons1[2, 0]);
                string selection = Console.ReadLine();
                int points = 0;
                switch (selection)
                {
                    case "A":
                        points = Convert.ToInt32(weapons1[0, 1]);
                        alien.healthPoints = alien.healthPoints - points;
                        Console.WriteLine("Awesomeness! You have hit the alien with {0} points!", points);
                        Console.WriteLine("Remaining alien healthPoints {0}", alien.healthPoints);
                        //Inline Condition
                        hero.lives = alien.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "B":
                        points = Convert.ToInt32(weapons1[1, 1]);
                        alien.healthPoints = alien.healthPoints + points;
                        Console.WriteLine("OH NO!!! You made the alien stronger by {0} points!", points);
                        Console.WriteLine("Remaining alien healthPoints {0}", alien.healthPoints);
                        //Inline Condition
                        hero.lives = alien.healthPoints > 0 ? hero.lives - 1 : hero.lives;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "C":
                        points = Convert.ToInt32(weapons1[1, 1]);
                        alien1.healthPoints = alien.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the alien with {0} points!", points);
                        Console.WriteLine("Remaining alien healthPoints {0}", alien.healthPoints);
                        //Inline Condition
                        hero.lives = alien.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                }
            }
            if (alien1.healthPoints <= 0)
            {
                Console.WriteLine(endMessage);
                return true;
            }
            else if (hero.lives <= 0)
            {
                Console.WriteLine("You have expended your stay on this earth my friend... goodbye.  GAME OVER! YOU LOSE!!!");
                return false;
            }
            return false;
        }

        public static string alienDraw1()
        {
            return @"
   _...___
 .'_ (.) _'.
/  (.) (.)  \
|  ,_____.  |      __
\     '-'   /_-_-_/ /
 '_+PATRIK+.'-_-_-\_\
 __//   \\__
(___)   (___)";

        }

        public static string alienDraw2()
        {
            return @"
    /\.-.../`\     /#\
   /_\ /_   \ \--.  \ \
 / /.\ /.\   \ \--. / /
/  \_/ \_/    \ \ \/ /
:(_)_______(_): | \ X
 \  \/ \/  ; ./ |  \--\
  ##__GAGA____##|...\--\     
  (,,,)(,,,)   (,,,)(,,,)";

        }

        public static string alienDraw3()
        {
            return @"	
      __.           __.
  __ {_/        __ {_/ 
  \_}\\ ___     \_}\\ ___.
  / \    / \    /  \   / |
 /  o____o  \   /  O____O \
/ #       #  \ / #       # \
| -_-_-_-_-_ | -_-_-_-_-_ |=^|^\
\    -===-==ANNA==-====- .'=.|./
 '.         .''.           .'
   '-.....-'   '-........-'
";

        }
        public static string alienDraw4()
        {
            return @"

     ,;''OO'';,
    |'',_OO_,''|
    | (.) (.)  |
    |    =     |
    |   ~~~~   | 
     ''.____.''  
     ***Sooki***
";
        }
    }

    public class Hero
    {
        public string heroName
        {
            get;
            set;
        }

        public int lives
        {
            get;
            set;
        }

        public string currentWeapon
        {
            get;
            set;
        }
    }

    public class Alien
    {
        public string alienName
        {
            get;
            set;
        }

        public string[] weakness
        {
            get;
            set;
        }

        public string[] strenght
        {
            get;
            set;
        }

        public int healthPoints
        {
            get;
            set;
        }

        public string endMessage
        {
            get;
            set;
        }
    }
}

