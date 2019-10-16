using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Laberint2D
{
    static class sound
    {
        static SoundPlayer sound_menu = new SoundPlayer(Properties.Resources.fault);
        static SoundPlayer sound_win = new SoundPlayer(Properties.Resources.Fanfare);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.Start_Sounds);

        static bool sound_enabled = true;
       
        public static void sound_on()
        {
            sound_enabled = true;
        }
        public static void sound_off()
        {
            sound_enabled = false;
        }
        public static void Play_fault()
        {
            if (sound_enabled)
                sound_menu.Play();
        }
        public static void Play_fanfare()
        {
            if (sound_enabled)
                sound_win.Play();
        }
        public static void Play_Start()
        {
            if (sound_enabled)
                sound_start.Play();
        }
       
    }
}
