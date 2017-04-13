using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_keyboard
{
    public partial class Form1 : Form
    {
        bool state = false; //initiate variable for mode
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_Mode_Click(object sender, EventArgs e)
        {
            state = !state; //toggle state

            if (state == true)
            {
                txt_Mode_Status.Text = "Prediction"; //set mode status text to "Prediction" if state is true
            }
            else
            {
                txt_Mode_Status.Text = "Multi-Press"; //set mode status text to "Multi-Press" if state is false
            }            
        }
    }
}
