using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Revolver : Gun
    {
        public Revolver()
        {
            Random rand = new Random();
            LoadedChambers[rand.Next(1, 6) - 1] = 1;
        }

        //loads the gun (implemented in Gun)

        
        public void Load(int numBullets, int numChambers)
        {
            base.Load(numBullets, numChambers);
        }
        

        //spins the cylinder
        public void Spin()
        {
            Random rand = new Random();
            CurrentChamber = rand.Next(1, 6);
        }

        //now you are shooting the gun (at yourself)
        public string Shoot()
        {
            string msg = string.Empty;
            if (LoadedChambers[CurrentChamber - 1] == 1)
            {
                msg = "die";
            }
            else
            {
                msg = "live";
            }
            if (CurrentChamber < 6)
            {
                CurrentChamber++;
            }
            if (CurrentChamber == 6)
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
            CurrentChamber = 1;
            NumChambers = 1;
            NumBulletsToLoad = rand.Next(0, 1);
        }

        public string Shoot()
        {
            string msg = string.Empty;
            if (LoadedChambers[0] == 1)
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
        public int fire { get; set; }
        public ShotGun()
        {
            fire = 1;
        }
        public ShotGun(int Fire)
        {
            this.fire = Fire;
        }
        public string DoubleBarrel()
        {
            Random rand = new Random();
            int bulletChoice = rand.Next(1, 3);
            if (bulletChoice == fire)
            {
                return "die";
            }
            {
                return "live";
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
}
