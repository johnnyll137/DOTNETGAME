﻿using System;
using System.Collections.Generic;

namespace Game
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("One day you are at your desk working on some code.");
            Console.WriteLine("You decide to take a break to get a quick snack.");
            Console.WriteLine("As you walk into the kitchen the light go out !");
            Console.WriteLine("Then you hear a hissing sound coming from the refrigerator.");

            Hero hero = new Hero();

            Console.WriteLine("What is your name human!");
            hero.heroName = Console.ReadLine();

            Console.WriteLine("Think quick what are you going to do {0}???", hero.heroName);
            Console.WriteLine("You are very afraid and tired from computing all night");

            hero.lives = 3;

            Console.WriteLine("You remember that you only have {0} lives in you.", hero.lives);


            Console.WriteLine("A wild Patrick Appears");
            alienDraw1();

            Console.WriteLine("you look around and see 3 things you can use as a weapon");
            Console.WriteLine("which weapon do you want to pick?");


            Weapons weapon = new Weapons();
            string[,] weapons1 = new string[3, 2] { { "Torch (it)", "1000" }, { "Freeze (make harder)", "100" }, { "Candle (burn with prayers)", "500" } };
            string[,] weapons2 = new string[3, 2] { { "Spoon (her)", "1000" }, { "Whip Cream (on it)", "100" }, { "Fork (it)", "500" } };
            string[,] weapons3 = new string[3, 2] { { "Toothpick (poker face)", "1000" }, { "Vodka (martini)", "100" }, { "Mouth (smash)", "500" } };


            Alien alien1 = new Alien();
            alien1.healthPoints = 1000;
            alien1.alienName = "Patrick";
            alien1.strenght = new string[1] { "Freeze (make harder)" };
            alien1.weakness = new string[2] { "Torch (it)", "Candle (burn with prayers)" };

            Alien alien2 = new Alien();
            alien2.healthPoints = 1000;
            alien2.alienName = "Anna";
            alien2.strenght = new string[1] { "Whip Cream (on it)" };
            alien2.weakness = new string[2] { "Spoon (her)", "Fork (it)" };

            Alien alien3 = new Alien();
            alien3.healthPoints = 1000;
            alien3.alienName = "Gaga";
            alien3.strenght = new string[1] { "Vodka (martini)" };
            alien3.weakness = new string[2] { "Toothpick (poker face)", "Mouth (smash)" };




            var stages = new List<Tuple<Alien, Hero, string[,]>>();
            stages.Add(Tuple.Create(alien1, hero, weapons1));
            stages.Add(Tuple.Create(alien2, hero, weapons2));
            stages.Add(Tuple.Create(alien3, hero, weapons3));

            foreach (var stage in stages)
            {

                //Moved to method stageCompleted
                stageCompleted(stage);
            }





            while (alien1.healthPoints > 0 && hero.lives > 0)
            {
                Console.WriteLine("Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons1[0, 0], weapons1[1, 0], weapons1[2, 0]);
                string selection = Console.ReadLine();
                int points = 0;
                switch (selection)
                {
                    case "a":
                        points = Convert.ToInt32(weapons1[0, 1]);
                        alien1.healthPoints = alien1.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
                        //Inline Condition
                        hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "b":
                        points = Convert.ToInt32(weapons1[1, 1]);
                        alien1.healthPoints = alien1.healthPoints + points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
                        //Inline Condition
                        hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "c":
                        points = Convert.ToInt32(weapons1[1, 1]);
                        alien1.healthPoints = alien1.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
                        //Inline Condition
                        hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                }
            }



            if (alien1.healthPoints <= 0)
            {
                Console.WriteLine("You have melted your friend and you left behind a puddle.");
                Console.WriteLine("You managed to defeat the foe with {0} lives remaining... Good Luck {1}", hero.lives, hero.heroName);
            }
            else if (hero.lives <= 0)
            {
                Console.WriteLine("You have expended your stay on this earth my friend... goodbye.");
            }


            Console.WriteLine("A wild cat shapped Anna the Banana Split Appears tho");

            alienDraw2();

            Console.WriteLine("you look around and see 3 things you can use as a weapon");
            Console.WriteLine("which weapon do you want to pick?");

            while (alien2.healthPoints > 0 && hero.lives > 0)
            {
                Console.WriteLine("Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons2[0, 0], weapons2[1, 0], weapons2[2, 0]);
                string selection = Console.ReadLine();
                int points = 0;
                switch (selection)
                {
                    case "a":
                        points = Convert.ToInt32(weapons2[0, 1]);
                        alien2.healthPoints = alien2.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien2.healthPoints);
                        //Inline Condition
                        hero.lives = alien2.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "b":
                        points = Convert.ToInt32(weapons2[1, 1]);
                        alien2.healthPoints = alien2.healthPoints + points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien2.healthPoints);
                        //Inline Condition
                        hero.lives = alien2.healthPoints > 0 ? hero.lives - 1 : hero.lives;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "c":
                        points = Convert.ToInt32(weapons2[1, 1]);
                        alien2.healthPoints = alien2.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien2.healthPoints);
                        //Inline Condition
                        hero.lives = alien2.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                }
            }



            if (alien2.healthPoints <= 0)
            {
                Console.WriteLine("You gave her mad affection with either spooning or cream, she is gone.");
            }
            else if (hero.lives <= 0)
            {
                Console.WriteLine("You have expended your stay on this earth my friend... goodbye.");
            }



            Console.WriteLine("A wild GaGa type olive is around the corner. HOLY@!!!!!!!SSHHhhhhhhiii");

            alienDraw3();

            Console.WriteLine("you look around and see 3 things you can use as a weapon");
            Console.WriteLine("which weapon do you want to pick?");

            while (alien3.healthPoints > 0 && hero.lives > 0)
            {
                Console.WriteLine("Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons3[0, 0], weapons3[1, 0], weapons3[2, 0]);
                string selection = Console.ReadLine();
                int points = 0;
                switch (selection)
                {
                    case "a":
                        points = Convert.ToInt32(weapons3[0, 1]);
                        alien3.healthPoints = alien3.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien3.healthPoints);
                        //Inline Condition
                        hero.lives = alien3.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "b":
                        points = Convert.ToInt32(weapons3[1, 1]);
                        alien3.healthPoints = alien3.healthPoints + points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien3.healthPoints);
                        //Inline Condition
                        hero.lives = alien3.healthPoints > 0 ? hero.lives - 1 : hero.lives;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "c":
                        points = Convert.ToInt32(weapons3[1, 1]);
                        alien3.healthPoints = alien3.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien3.healthPoints);
                        //Inline Condition
                        hero.lives = alien3.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                }
            }

            if (alien3.healthPoints <= 0)
            {
                Console.WriteLine("You poker her face pretty hard bro. but she was born that way. if you made it this far you will live sir.");
            }
            else if (hero.lives <= 0)
            {
                Console.WriteLine("You have expended your stay on this earth my friend... goodbye.");
            }


        }

        public static bool stageCompleted(Tuple<Alien, Hero, string[,]> stage)
        {

            //Define your variables
            var alien1 = stage.Item1;
            var hero = stage.Item2;
            var weapons1 = stage.Item3;

            while (alien1.healthPoints > 0 && hero.lives > 0)
            {
                Console.WriteLine("Choice A = {0} , or , Choice B {1} , or , Choice C {2}", weapons1[0, 0], weapons1[1, 0], weapons1[2, 0]);
                string selection = Console.ReadLine();
                int points = 0;
                switch (selection)
                {
                    case "a":
                        points = Convert.ToInt32(weapons1[0, 1]);
                        alien1.healthPoints = alien1.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
                        //Inline Condition
                        hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "b":
                        points = Convert.ToInt32(weapons1[1, 1]);
                        alien1.healthPoints = alien1.healthPoints + points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
                        //Inline Condition
                        hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                    case "c":
                        points = Convert.ToInt32(weapons1[1, 1]);
                        alien1.healthPoints = alien1.healthPoints - points;
                        Console.WriteLine("Great job! You have hit the enemy with {0} points!", points);
                        Console.WriteLine("Remaining Enemy healthPoints {0}", alien1.healthPoints);
                        //Inline Condition
                        hero.lives = alien1.healthPoints > 0 ? hero.lives - 1 : hero.lives + 1;
                        Console.WriteLine("Hero Remaining lives: {0}", hero.lives);
                        break;
                }
            }



            if (alien1.healthPoints <= 0)
            {
                Console.WriteLine("You have melted your friend and you left behind a puddle.");
                Console.WriteLine("You managed to defeat the foe with {0} lives remaining... Good Luck {1}", hero.lives, hero.heroName);
                return true;
            }
            else if (hero.lives <= 0)
            {
                Console.WriteLine("You have expended your stay on this earth my friend... goodbye.");
                return false;
            }


            return false;
        }



        public static void alienDraw1()
        {
            string alien1 = @"
   _...___
 .'_ (.) _'.
/  (.) (.)  \
|  ,_____.  |      __
\     '-'   /_-_-_/ /
 '_+PATRIK+.'-_-_-\_\
 __//   \\__
(___)   (___)";
            Console.WriteLine(alien1);
        }

        public static void alienDraw2()
        {
            string alien2 = @"
    /\.-.../`\     /#\
   /_\ /_   \ \--.  \ \
 / /.\ /.\   \ \--. / /
/  \_/ \_/    \ \ \/ /
:(_)_______(_): | \ X
 \  \/ \/  ; ./ |  \--\
  ##__GAGA____##|...\--\     
  (,,,)(,,,)   (,,,)(,,,)";
            Console.WriteLine(alien2);
        }

        public static void alienDraw3()
        {
            string alien3 = @"	
		
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
            Console.WriteLine(alien3);
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
    }

    public class Weapons
    {
        string[,] weapons1 = new string[3, 2] { { "Spoon (her)", "9000" }, { "Whip Cream (on it)", "1" }, { "Fork (it)", "25" } };
        string[,] weapons2 = new string[3, 2] { { "Torch (it)", "9000" }, { "Freeze (make harder)", "1" }, { "Candle (burn with prayers)", "5" } };
        string[,] weapons3 = new string[3, 2] { { "Toothpick (poker face)", "9000" }, { "Vodka (martini)", "1" }, { "Mouth (smash)", "15" } };
    }

}
