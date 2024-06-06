namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game(GunMenu());


            static void Game(Gun gun)
            {
                Console.WriteLine($"You chose {gun}");
                if (gun.GetType() == typeof(Revolver))
                {
                    //fix this
                    Revolver gun2 = gun as Revolver;
                    gun2.Load(1, 6);
                    gun2.Spin();
                    string life = gun2.Shoot();
                    if (life == "die")
                    {
                        DeathScreen();
                    }
                    else
                    {
                        LifeScreen();
                    }
                }
                else if(gun.GetType() == typeof(ShotGun))
                {
                    ShotGun gun2 = gun as ShotGun;
                    gun2.Load(1, 6);
                    string life = gun2.DoubleBarrel();
                    if (life == "die")
                    {
                        DeathScreen();
                    }
                    else
                    {
                        LifeScreen();
                    }
                }
                else if(gun.GetType() == typeof(RPG))
                {
                    RPG gun2 = gun as RPG;
                    gun2.Load(1, 1);
                    string life = gun2.Shoot();
                    if (life == "die")
                    {
                        DeathScreen();
                    }
                    else
                    {
                        LifeScreen();
                    }
                }
            }

            static Gun GunMenu()
            {
                Console.Clear();
                Console.WriteLine("What gun do you want to load? ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Use the arrow keys to choose and Enter to select");
                Console.WriteLine("--------------------------------");

                ConsoleKeyInfo key;
                int option = 1;
                bool isSelected = false;
                (int left, int top) = Console.GetCursorPosition(); //puts cursor back to the top. (so if the up key is pressed continuously it does not say option -4 is selected)
                string color = "\x1b[42m"; //this is the color that appears over a selected option (the [42m is the color of the text and \x1b is a unicode character that allows us to do this

                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top); //sets cursor at the top and does not repeat allll these console.writelines
                    Console.WriteLine($"{(option == 1 ? color : null)}[1] Revolver\x1b[0m");
                    Console.WriteLine($"{(option == 2 ? color : null)}[2] Shotgun\x1b[0m");
                    Console.WriteLine($"{(option == 3 ? color : null)}[3] RPG\x1b[0m");


                    key = Console.ReadKey(true);


                    switch (key.Key) //when key is pressed:
                    {
                        case ConsoleKey.DownArrow:
                            option = (option == 3 ? option = 1 : option + 1); //if the cursor is at the last option and the user presses down, it will return to the top/first option. otherwise it goes down one
                            break;
                        case ConsoleKey.UpArrow:
                            option = (option == 1 ? option = 3 : option - 1); //if the cursor is at the first option and the user pressed up, it will return to the last/bottom option. otherwise it just goes up one
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;
                    };
                    Console.WriteLine($"Selected Gun {option}"); //test string to make sure it works
                };

                Console.Clear();

                //w.i.p
                switch (option)
                {

                    case 1:
                        return new Revolver();
                    case 2:
                        return new ShotGun();
                    case 3:
                        return new RPG();
                    default:
                        return new Revolver();
                }
            }

            static void LifeScreen()
            {
                //Console.Clear();
                Console.WriteLine("You lived!");

                Console.WriteLine("\nWould you like to retry?\n");

                ConsoleKeyInfo key;
                int retryOption = 1;
                bool isSelected = false;
                (int left, int top) = Console.GetCursorPosition(); //puts cursor back to the top. (so if the up key is pressed continuously it does not say option -4 is selected)
                string color = "\x1b[42m"; //this is the color that appears over a selected option (the [42m is the color of the text and \x1b is a unicode character that allows us to do this

                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top); //sets cursor at the top and does not repeat allll these console.writelines
                    Console.Write($"{(retryOption == 1 ? color : null)}YES\x1b[0m");
                    Console.Write($"{(retryOption == 2 ? color : null)}\tNO\x1b[0m");

                    key = Console.ReadKey(true);


                    switch (key.Key) //when key is pressed:
                    {
                        case ConsoleKey.LeftArrow:
                            retryOption = (retryOption == 2 ? retryOption = 1 : retryOption + 1); //if the cursor is at the left option and the user presses left, it will return to the right option.
                            break;
                        case ConsoleKey.RightArrow:
                            retryOption = (retryOption == 1 ? retryOption = 2 : retryOption - 1); //if the cursor is at the right option and the user pressed right, it will return to the left option.
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;

                    };
                }

                switch (retryOption)
                {
                    case 1: //yes retry
                        Game(GunMenu());
                        break;
                    case 2: //no exit
                        Console.Clear();
                        Console.WriteLine("Thanks for playing");
                        break;
                }
            }


            static void DeathScreen()
            {

                Console.Clear();
                Console.WriteLine(@"             ^
            | |
        @#####@
        (###   ###)-.
    .(###     ###) \
    /  (###   ###)   )
    (=-  .@#####@|_--""
    /\    \_|l|_/ (\
(=-\     |l|    /
    \  \.___|l|___/
    /\      |_|   /
(=-\._________/\
    \             /
    \._________/
        #  ----  #
        #   __   #
        \########/");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████
███████████████████████████");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\tYou died");
                Console.WriteLine(@"███████████████████████████
███████▀▀▀░░░░░░░▀▀▀███████
████▀░░░░░░░░░░░░░░░░░▀████
███│░░░░░░░░░░░░░░░░░░░│███
██▌│░░░░░░░░░░░░░░░░░░░│▐██
██░└┐░░░░░░░░░░░░░░░░░┌┘░██
██░░└┐░░░░░░░░░░░░░░░┌┘░░██
██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██
██▌░│██████▌░░░▐██████│░▐██
███░│▐███▀▀░░▄░░▀▀███▌│░███
██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██
██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██
████▄─┘██▌░░░░░░░▐██└─▄████
█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████
████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████
█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████
███████▄░░░░░░░░░░░▄███████
██████████▄▄▄▄▄▄▄██████████
███████████████████████████");


                Console.WriteLine("\nWould you like to retry?\n");

                ConsoleKeyInfo key;
                int retryOption = 1;
                bool isSelected = false;
                (int left, int top) = Console.GetCursorPosition(); //puts cursor back to the top. (so if the up key is pressed continuously it does not say option -4 is selected)
                string color = "\x1b[42m"; //this is the color that appears over a selected option (the [42m is the color of the text and \x1b is a unicode character that allows us to do this

                while (!isSelected)
                {
                    Console.SetCursorPosition(left, top); //sets cursor at the top and does not repeat allll these console.writelines
                    Console.Write($"{(retryOption == 1 ? color : null)}YES\x1b[0m");
                    Console.Write($"{(retryOption == 2 ? color : null)}\tNO\x1b[0m");

                    key = Console.ReadKey(true);


                    switch (key.Key) //when key is pressed:
                    {
                        case ConsoleKey.LeftArrow:
                            retryOption = (retryOption == 2 ? retryOption = 1 : retryOption + 1); //if the cursor is at the left option and the user presses left, it will return to the right option.
                            break;
                        case ConsoleKey.RightArrow:
                            retryOption = (retryOption == 1 ? retryOption = 2 : retryOption - 1); //if the cursor is at the right option and the user pressed right, it will return to the left option.
                            break;
                        case ConsoleKey.Enter:
                            isSelected = true;
                            break;

                    };
                }
                
                switch(retryOption)
                {
                    case 1: //yes retry
                        Game(GunMenu());
                        break;
                    case 2: //no exit
                        Console.Clear();
                        Console.WriteLine("Thanks for playing");
                        break;
                }

            }
        }
    }
}