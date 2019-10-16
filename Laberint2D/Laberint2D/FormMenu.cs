using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberint2D
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            sound.Play_Start();
            MessageBox.Show("Проведите мышкой от Старта до Финиша не задивая стенок уровня.","Правила");
            start_level1();
        }

        private void Box_sound_CheckedChanged(object sender, EventArgs e)
        {
            
           if(Box_sound.Checked)
         {
          sound.sound_on();      
          Box_sound.Text = "Звук:Вкл";
         }
                else
                {
                    sound.sound_off();
                    Box_sound.Text = "Звук:Выкл";
                }
                }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void start_level1 ()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr =level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                start_level2(); 
                }
        private void start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                start_you_Win();
            }
        }
            private void start_you_Win()
        {
            sound.Play_fanfare();
            MessageBox.Show("Вы прошли все лаберинты!", "Поздравляем");
        }


       
        private void FormMenu_Load(object sender, EventArgs e)
        {
            sound.Play_fault();
        }

        private void buttonlevel2_Click(object sender, EventArgs e)
        {
            start_level2();
        }

        private void AVTOR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создал Игру: Кріхан Владислав");
        }
    }
}
