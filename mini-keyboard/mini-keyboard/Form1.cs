using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //used for stream writer and reader
using MyDialogs; //add file which contains class for inputbox

namespace mini_keyboard
{
    public partial class Form1 : Form
    {
        bool boolRequiresSaving = false; //detects when changes have been made and requires saving
        bool boolFirstVisit = true; //timing functionality
        bool state = false; //initiate variable for mode
        bool[] boolButtonPressed = new bool[19]; //identifies button selected by user

        string strCurrent_File_Name = ""; //declare empty variable for current path
        string strTemp = ""; //create temp string for wordbuilder text
        string strKeyStrokes = ""; //prediction

        int intIntervalRequired = 500; //timing functionality
        int intMyListIndex = -1; //sequence functionality
        int intPredictedIndex; //prediction variable
        int intNumberOfCharacters; //prediction variable
        int intPredictedWordLength; //prediction variable

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Interval = intIntervalRequired; //initial delay between character presses

            for (var intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
            {
                boolButtonPressed[intWhichButton] = false;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Enabled = false; //disable timer
            boolFirstVisit = true; //reset firstVisit value
            intMyListIndex = -1; //reset position in index

            //set button states false on timer tick
            for (var intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
            {
                boolButtonPressed[intWhichButton] = false;
            }
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
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            strKeyStrokes = txt_WordBuilder.Text;
            txt_Notepad.AppendText(strKeyStrokes + " ");
            strKeyStrokes = "";
            txt_WordBuilder.Clear();
        }
        
    }
}
