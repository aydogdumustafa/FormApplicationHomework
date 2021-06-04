using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace id04p02
{
    public partial class MyMain : Form
    {
        public MyMain()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(190, 200, 220);
            Size = new Size(400,400);
            buttonColour.ForeColor = BackColor;
            
        }

        private void MyMain_MouseClick(object sender, MouseEventArgs e)
        {

            /*
            if (cnt % 2 == 0)
            {
                
                BackColor = Color.FromArgb(190, 200, 220);
            }
            else
            {
                BackColor = Color.FromArgb(255, 255, 180);
            }
          */

            if (BackColor == Color.FromArgb(255, 255, 180))
                BackColor = Color.FromArgb(190, 200, 220);
            else
                BackColor = Color.FromArgb(255, 255, 180);

                ++cnt;
            Text = "Moje Okienko   " + cnt;
        }
        int cnt = 0;

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            //Close();
            Application.Exit();
        }

        private void buttonColour_Click(object sender, EventArgs e)
        {
            if (buttonColour.BackColor == BackColor)
                BackColor = buttonColour.ForeColor;

            Color Temp = BackColor;
            BackColor = buttonColour.BackColor;
            buttonColour.BackColor = Temp;
            buttonColour.ForeColor = BackColor;
        }
    }
}
