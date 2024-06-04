using System.Runtime.InteropServices;

public class Revolver : Gun
{
    public Revolver()
    {
        Random rand = new Random();
        LoadedChambers[rand.Next(1,6) - 1] = 1;
    }
    
    //loads the gun (implemented in Gun)

    /*
    public void Load()
    {
        Random rand = new Random();
        int loadChamber = rand.Next(1,6);
        LoadedChambers[loadChamber - 1] = 1;
    }
    */

    //spins the cylinder
    public void Spin()
    {
        Random rand = new Random();
        CurrentChamber = rand.Next(1,6);
    }

    //now you are shooting the gun (at yourself)
    public string Shoot()
    {
        string msg = string.Empty;
        if(LoadedChambers[CurrentChamber - 1] == 1)
        {
            msg = "die";
        }
        else
        {
            msg = "live";
        }
        if(CurrentChamber < 6)
        {
            CurrentChamber++;
        }
        if(CurrentChamber == 6)
        {
            CurrentChamber = 0;
        }
        return msg;
    }
}

public class RPG : Gun
{
    public RPG()
    {
        Random rand = new Random();
        LoadedChambers = new int[1];
        CurrentChamber = 0;
        NumChambers = 1;
        NumBulletsToLoad = rand.Next(0,1);
    }

    public string Shoot()
    {
        string msg = string.Empty;
        if(LoadedChambers[0] == 1)
        {
            msg = "die";
        }
        else
        {
            msg = "live";
        }
        return msg;
    }
}
public class ShotGun : Gun
{
    public int fire { get; set;}
    public ShotGun()
    {
        fire = 1;
    }
    public ShotGun(int Fire)
    {
        this.fire = Fire;
    }
    public void DoubleBarrel()
    {
        Random rand = new Random();
        int bulletChoice = rand.Next(1,2);
        if(bulletChoice == fire)
        {
            Console.WriteLine("Die");
        }
        {
            Console.WriteLine("live");
        }
    }
}
/*
public class RPG : Gun
{
    public void RPG()
    {
        Die
    }
}
*/