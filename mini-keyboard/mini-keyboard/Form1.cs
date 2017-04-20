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
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            txt_Notepad.AppendText(Environment.NewLine);
        }
        private void btn_One_Click(object sender, EventArgs e)
        {
            if (boolButtonPressed[1] == false)
            {
                Timer_Tick(sender, e);
            }
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;
            boolButtonPressed[1] = true;

            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_One.Items.Count)
                {
                    intMyListIndex = intMyListIndex + 1;
                    if (intMyListIndex == lstb_One.Items.Count)
                    {
                        intMyListIndex = 0;
                    }
                    strTemp = lstb_One.Items[intMyListIndex].ToString();
                }
                else
                {
                    intMyListIndex = -1;
                }

                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false;
                    txt_WordBuilder.AppendText(strTemp);
                    txt_KeySequence.AppendText("1".ToString());
                    strKeyStrokes = txt_KeySequence.Text.ToString();
                }
                else
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1);
                    txt_WordBuilder.AppendText(strTemp);
                }
            }
        }
        private void btn_Two_Click(object sender, EventArgs e)
        {
            if (boolButtonPressed[2] == false)
            {
                Timer_Tick(sender, e);
            }
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;
            boolButtonPressed[2] = true;

            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Two.Items.Count)
                {
                    intMyListIndex = intMyListIndex + 1;
                    if (intMyListIndex == lstb_Two.Items.Count)
                    {
                        intMyListIndex = 0;
                    }
                    strTemp = lstb_Two.Items[intMyListIndex].ToString();
                }
                else
                {
                    intMyListIndex = -1;
                }

                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false;
                    txt_WordBuilder.AppendText(strTemp);
                    txt_KeySequence.AppendText("2".ToString());
                    strKeyStrokes = txt_KeySequence.Text.ToString();
                }
                else
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1);
                    txt_WordBuilder.AppendText(strTemp);
                }
            }
        }
        private void btn_Three_Click(object sender, EventArgs e)
        {
            if (boolButtonPressed[3] == false)
            {
                Timer_Tick(sender, e);
            }
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;
            boolButtonPressed[3] = true;

            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Three.Items.Count)
                {
                    intMyListIndex = intMyListIndex + 1;
                    if (intMyListIndex == lstb_Three.Items.Count)
                    {
                        intMyListIndex = 0;
                    }
                    strTemp = lstb_Three.Items[intMyListIndex].ToString();
                }
                else
                {
                    intMyListIndex = -1;
                }

                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false;
                    txt_WordBuilder.AppendText(strTemp);
                    txt_KeySequence.AppendText("3".ToString());
                    strKeyStrokes = txt_KeySequence.Text.ToString();
                }
                else
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1);
                    txt_WordBuilder.AppendText(strTemp);
                }
            }
        }
        private void btn_Four_Click(object sender, EventArgs e)
        {
            if (boolButtonPressed[4] == false)
            {
                Timer_Tick(sender, e);
            }
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;
            boolButtonPressed[4] = true;

            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Four.Items.Count)
                {
                    intMyListIndex = intMyListIndex + 1;
                    if (intMyListIndex == lstb_Four.Items.Count)
                    {
                        intMyListIndex = 0;
                    }
                    strTemp = lstb_Four.Items[intMyListIndex].ToString();
                }
                else
                {
                    intMyListIndex = -1;
                }

                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false;
                    txt_WordBuilder.AppendText(strTemp);
                    txt_KeySequence.AppendText("4".ToString());
                    strKeyStrokes = txt_KeySequence.Text.ToString();
                }
                else
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1);
                    txt_WordBuilder.AppendText(strTemp);
                }
            }
        }
    }
}
