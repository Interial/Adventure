using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Adventure1
{
    class Dzwiek
    {

        public static void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }

        public static void startsound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\start.wav");
            simpleSound.Play();
        }

        public static void PlayGrat()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\Graty.wav");
            simpleSound.Play();
        }
        public static void playLekSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\Lek.wav");
            simpleSound.Play();
        }
        public static void playImieSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\imie.wav");
            simpleSound.Play();
        }


        public static void playDrzewoSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\drzewo.wav");
            simpleSound.Play();
        }

        public static void PlayMojDom()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\dom.wav");
            simpleSound.Play();
        }

        public static void PlayMama()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\Mama.wav");
            simpleSound.Play();
        }

        public static void PlayTata()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\Tata.wav");
            simpleSound.Play();
        }

        public static void PlayPamiec()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ja\Desktop\szkice\Pamiec.wav");
            simpleSound.Play();
        }
    }
}
