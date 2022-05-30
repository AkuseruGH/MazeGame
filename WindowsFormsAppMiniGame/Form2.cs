using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMiniGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width / 2,
                   Screen.PrimaryScreen.Bounds.Height / 2);
        }

        private void pictureBox173_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Perdiste :(");
            Close();
        }

        private void pictureBox184_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ganaste :D");
            Close();
        }
    }
}
