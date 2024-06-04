// See https://aka.ms/new-console-template for more information
using System.Drawing;


GunMenu();


static void DeathScreen(){

Console.Clear();
Console.WriteLine(@"/̵͇̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿");
System.Threading.Thread.Sleep(3000);
Console.Clear();
Console.WriteLine(@"/̵͇̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿💥");
System.Threading.Thread.Sleep(2000);
Console.Clear();

Console.WriteLine("You died");
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

}


static Gun GunMenu(){

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

Console.WriteLine($"Selected Gun {option}");
//w.i.p
switch (option){
    
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


