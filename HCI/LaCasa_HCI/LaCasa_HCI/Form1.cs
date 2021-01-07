using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCasa_HCI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            homeControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            homeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            restaurantsContorl1.BringToFront();
        }
    }
}
