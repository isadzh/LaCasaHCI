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
    public partial class RestaurantsContorl : UserControl
    {
        public MrkvaControl mrk { get; set; }
        public MontanaControl montana { get; set; }
        public PasaControl pasa { get; set; }
        public RestaurantsContorl()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mrk?.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            montana?.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pasa?.BringToFront();
        }
    }
}
