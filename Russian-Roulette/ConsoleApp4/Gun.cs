using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Gun
    {
        public int NumChambers { get; set; }
        public int NumBulletsToLoad { get; set; }
        public int CurrentChamber { get; set; }

        public int[] LoadedChambers { get; set; }
        public int fire;

        public Gun()
        {
            LoadedChambers = new int[6];
            NumChambers = 6;
            NumBulletsToLoad = 1;
            CurrentChamber = 0;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public void Load(int numBullets, int numChambers)
        {
            int loadedBullets = 0;
            this.LoadedChambers = new int[numChambers];
            this.NumChambers = numChambers;

            if (numBullets > numChambers)
            {
                numBullets = numChambers;
            }

            this.NumBulletsToLoad = numBullets;

            //this part will load the bullets in chambers
            Random rand = new Random();
            do
            {
                int chamberToLoad = rand.Next(0, numChambers);
                if (LoadedChambers[chamberToLoad] != 1)
                {
                    LoadedChambers[chamberToLoad] = 1;
                    loadedBullets++;
                }
            }
            while (loadedBullets < NumBulletsToLoad);
        }
    }
}
