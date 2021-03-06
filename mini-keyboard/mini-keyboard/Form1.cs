﻿using System;
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
            if (state == false)
            {
                strKeyStrokes = txt_WordBuilder.Text; //set keystrokes variable to current wordbuilder text
                txt_Notepad.AppendText(strKeyStrokes + " "); //insert text in variable strKeyStrokes + a space into notepad textbox
                txt_WordBuilder.Clear(); //clear wordbuilder textbox
                StreamWriter OutputStream = File.AppendText("Dictionary.txt"); //append text to dictionary file
                OutputStream.Write(txt_KeySequence.Text + "&" + strKeyStrokes + "&" + "0" + Environment.NewLine); //save text from notepad to current file
                OutputStream.Close(); //close output stream
                txt_KeySequence.Clear(); //clear key sequence text box
                strKeyStrokes = ""; // clear strKeyStrokes variable
            }
            else
            {
                strKeyStrokes = txt_WordBuilder.Text; //set keystrokes variable to current wordbuilder text
                txt_Notepad.AppendText(strKeyStrokes + " "); //insert text in variable strKeyStrokes + a space into notepad textbox
                txt_KeySequence.Clear(); //clear key sequence text box
                strKeyStrokes = ""; // clear strKeyStrokes variable
                txt_WordBuilder.Clear(); //clear wordbuilder textbox
            }
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
            //if notepad text is not empty
            if (txt_Notepad.Text != "")
            {
                boolRequiresSaving = true; //set requires saving variable to true, needs saving
            }
            else
            {
                boolRequiresSaving = false; //set requires saving variable to false, doesn't need saving
            }

            //if requires saving variable is true
            if (boolRequiresSaving == true)
            {
                saveAsToolStripMenuItem_Click(sender, e); //call save function
            }
            txt_Notepad.Text = ""; //clear notepad text after save
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\"; //fetch current directory

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader InputStream = File.OpenText(openFileDialog1.FileName); //open existing file
                txt_Notepad.Text = InputStream.ReadToEnd(); //insert text into notepad
                strCurrent_File_Name = openFileDialog1.FileName; //set current filename to file that was opened
                InputStream.Close(); //close input stream
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if current file name is empty - open save dialog
            if (strCurrent_File_Name == "")
            {
                saveAsToolStripMenuItem_Click(sender, e); //call save function
            }
            else
            {
                StreamWriter OutputStream = File.CreateText(saveFileDialog1.FileName); //save over current file
                OutputStream.Write(txt_Notepad.Text); //save text from notepad to current file
                OutputStream.Close(); //close output stream
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if current file name is empty
            if (strCurrent_File_Name == "")
            {
                saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory() + "\\"; //get current directory

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter OutputStream = File.CreateText(saveFileDialog1.FileName); //save over current file
                    OutputStream.Write(txt_Notepad.Text); //save text from notepad to current file
                    strCurrent_File_Name = saveFileDialog1.FileName; //set file name to name of file saved
                    OutputStream.Close(); //close output stream
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if notepad text isn't empty
            if (txt_Notepad.Text != "")
            {
                saveToolStripMenuItem_Click(sender, e); //call save function
            }
            Close(); //close application
        }
        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intIntervalRequired = Convert.ToInt32(My_Dialogs.InputBox("Please enter the 'Delay Value' you require between character presses. 1000 is equivalent to 1 second." + Environment.NewLine +  "The current delay is: " + intIntervalRequired + "."));
        }
        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (state == false)
            {
                if (txt_WordBuilder.TextLength >= 1)
                {
                    txt_WordBuilder.Text = txt_WordBuilder.Text.Remove(txt_WordBuilder.TextLength - 1, 1); //remove last character of wordbuilder textbox
                    txt_KeySequence.Text = txt_KeySequence.Text.Remove(txt_KeySequence.TextLength - 1, 1); //remove last character of keysequence textbox as character has been removed
                }
            }
        }
    }
}
