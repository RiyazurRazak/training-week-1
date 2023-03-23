using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace week_1
{
    internal class Game
    {
        const int bulletsCount = 20;
        public int heroFires = 0;
        public int villanFires = 0;
        bool isVillanBulletsOver = false;

        public void Shoot()
        {
            if(heroFires <= bulletsCount)
            {
                heroFires++;
            }
            if (villanFires + 3 < bulletsCount && !isVillanBulletsOver)
            {
                villanFires += 3;

            }
            else
            {
                isVillanBulletsOver = true;
                villanFires = 0;
            }
            Console.WriteLine("Hero Fires : " + heroFires + " Villan Fires :" + villanFires);
        }
        // renamed the Main to main to run other files in the projects!
        static void main(string[] args)
        {
            Game game = new Game();
            int itr = 0;
            while (itr != 20)
            {
                game.Shoot();
                itr++;
            }
           

        }
    }
}
