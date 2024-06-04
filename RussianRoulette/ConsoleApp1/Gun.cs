using System.Linq.Expressions;

public class Gun
{
    public int NumChambers {get; set;}
    public int NumBulletsToLoad {get; set;}
    public int CurrentChamber {get; set;}

    public int[] LoadedChambers {get; set;}
    public int fire;
    
    public Gun()
    {
        LoadedChambers = new int[6];
        NumChambers = 6;
        NumBulletsToLoad = 1;
        CurrentChamber = 0;
    }

    public void Load(int numBullets, int numChambers)
    {
        int loadedBullets = 0;
        this.LoadedChambers = new int[numChambers];
        this.NumChambers = numChambers;

        if(numBullets > numChambers)
        {
            numBullets = numChambers;
        }

        this.NumBulletsToLoad = numBullets;
        
        //this part will load the bullets in chambers
        Random rand = new Random();
        while(loadedBullets != NumBulletsToLoad)
        {
            Loop:
            int chamberToLoad = rand.Next(0, numChambers);
            if(LoadedChambers[chamberToLoad] != 1)
            {
                LoadedChambers[chamberToLoad] = 1;
                loadedBullets++;
            }
            goto Loop;
        }
    }
}