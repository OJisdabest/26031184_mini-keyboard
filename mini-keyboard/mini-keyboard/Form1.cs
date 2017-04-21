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

            //set button states false when form loads
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
            strKeyStrokes = txt_WordBuilder.Text; //set keystrokes variable to current wordbuilder text
            txt_Notepad.AppendText(strKeyStrokes + " "); //insert text in variable strKeyStrokes + a space into notepad textbox
            strKeyStrokes = ""; // clear strKeyStrokes variable
            txt_WordBuilder.Clear(); //clear wordbuilder textbox
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            txt_Notepad.AppendText(Environment.NewLine); //insert new line in notepad textbox
        }
        private void btn_One_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[1] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false; 
            Timer.Enabled = true; 
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[1] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_One.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_One.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_One.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("1".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Two_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[2] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[2] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Two.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Two.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Two.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("2".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Three_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[3] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[3] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Three.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Three.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Three.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("3".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Four_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[4] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[4] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Four.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Four.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Four.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("4".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Five_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[5] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[5] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Five.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Five.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Five.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("5".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Six_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[6] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[6] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Six.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Six.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Six.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("6".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Seven_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[7] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[7] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Seven.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Seven.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Seven.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("7".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Eight_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[8] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[8] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Eight.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Eight.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Eight.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("8".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Nine_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[9] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[9] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Nine.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Nine.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Nine.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("9".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Ten_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[10] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[10] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Ten.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Ten.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Ten.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("*".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void btn_Eleven_Click(object sender, EventArgs e)
        {
            //when current button state is false
            if (boolButtonPressed[11] == false)
            {
                Timer_Tick(sender, e); //call timer functionality as this resets button states
            }

            //reset timer + timer interval
            Timer.Enabled = false;
            Timer.Enabled = true;
            Timer.Interval = intIntervalRequired;

            //set current button state true
            boolButtonPressed[11] = true;

            //implement functionality when timer is running
            if (Timer.Enabled == true)
            {
                if (intMyListIndex < lstb_Eleven.Items.Count) //if index is less than total items in listbox item collection 
                {
                    intMyListIndex = intMyListIndex + 1; //increment index
                    if (intMyListIndex == lstb_Eleven.Items.Count) //if index is equal to total items in listbox item collection associated with this button
                    {
                        intMyListIndex = 0; //reset index
                    }
                    strTemp = lstb_Eleven.Items[intMyListIndex].ToString(); //set temp string to item selected in listbox item collection associated with this button
                }


                if (boolFirstVisit == true)
                {
                    boolFirstVisit = false; //set firstvisit false
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                    txt_KeySequence.AppendText("#".ToString()); //append button key number to key sequence textbox
                    strKeyStrokes = txt_KeySequence.Text.ToString(); //set variable str_KeyStrokes to keysequence text contents
                }
                else //when first visit is false
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_WordBuilder.AppendText(strTemp); //append strTemp variable text to wordbuilder textbox
                }
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_Notepad.Text != "")
            {
                boolRequiresSaving = true;
            }

            if (boolRequiresSaving == true)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            txt_Notepad.Text = "";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strCurrent_File_Name == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                StreamWriter OutputStream = File.CreateText(saveFileDialog1.FileName);
                OutputStream.Write(txt_Notepad.Text);
                OutputStream.Close();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strCurrent_File_Name == "")
            {
                saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter OutputStream = File.CreateText(saveFileDialog1.FileName);
                    OutputStream.Write(txt_Notepad.Text);
                    strCurrent_File_Name = saveFileDialog1.FileName;
                    OutputStream.Close();
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
