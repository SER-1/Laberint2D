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
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
            start_game();
        }
        private void start_game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            sound.Play_Start();
        }
        private void finish_game()
        {
            DialogResult dr = MessageBox.Show("Попробуем ещё разок", "Вы проиграли", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
        private void label_finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;}
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            start_game();
        }
    }
}
