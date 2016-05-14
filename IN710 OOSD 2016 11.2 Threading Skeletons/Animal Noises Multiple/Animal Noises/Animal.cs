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
            //Pass in reference to the shared object.
            lockString = LockString;
        }

        public void speak()
        {

            
                while (true)
                    {
                        //Lock the code below on the shared object, so that the current thread with the lock is the only one that can run the code. 
                        lock (lockString)
                        {
                            soundPlayer.Play();
                            Thread.Sleep(2000);
                        }
                    }
                       
            
        }

    }
}
