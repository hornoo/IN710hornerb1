using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        String lockString;


        public Animal(String soundFileName,String LockString)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            lockString = LockString;
        }

        public void speak()
        {

            
                while (true)
                    {
                        lock (lockString)
                        {
                            soundPlayer.Play();

                            Thread.Sleep(500);
                        }
                    }
                       
            
        }

    }
}
