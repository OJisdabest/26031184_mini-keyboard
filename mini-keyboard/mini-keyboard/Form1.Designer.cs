namespace mini_keyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_notepad = new System.Windows.Forms.Panel();
            this.txt_Notepad = new System.Windows.Forms.TextBox();
            this.panel_wordbuilder = new System.Windows.Forms.Panel();
            this.txt_Mode_Status = new System.Windows.Forms.TextBox();
            this.txt_WordBuilder = new System.Windows.Forms.RichTextBox();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_Eleven = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Ten = new System.Windows.Forms.Button();
            this.btn_Three = new System.Windows.Forms.Button();
            this.btn_Two = new System.Windows.Forms.Button();
            this.btn_One = new System.Windows.Forms.Button();
            this.btn_Six = new System.Windows.Forms.Button();
            this.btn_Five = new System.Windows.Forms.Button();
            this.btn_Four = new System.Windows.Forms.Button();
            this.btn_Nine = new System.Windows.Forms.Button();
            this.btn_Eight = new System.Windows.Forms.Button();
            this.btn_Seven = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_NotUsed2 = new System.Windows.Forms.Button();
            this.btn_NotUsed1 = new System.Windows.Forms.Button();
            this.btn_Send_Predicted = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Mode = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lstb_One = new System.Windows.Forms.ListBox();
            this.lstb_Two = new System.Windows.Forms.ListBox();
            this.lstb_Three = new System.Windows.Forms.ListBox();
            this.lstb_Six = new System.Windows.Forms.ListBox();
            this.lstb_Five = new System.Windows.Forms.ListBox();
            this.lstb_Four = new System.Windows.Forms.ListBox();
            this.lstb_Eleven = new System.Windows.Forms.ListBox();
            this.lstb_Ten = new System.Windows.Forms.ListBox();
            this.lstb_Nine = new System.Windows.Forms.ListBox();
            this.lstb_Eight = new System.Windows.Forms.ListBox();
            this.lstb_Seven = new System.Windows.Forms.ListBox();
            this.txt_KeySequence = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel_wordbuilder.SuspendLayout();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // panel_notepad
            // 
            this.panel_notepad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_notepad.Location = new System.Drawing.Point(12, 42);
            this.panel_notepad.Name = "panel_notepad";
            this.panel_notepad.Size = new System.Drawing.Size(812, 304);
            this.panel_notepad.TabIndex = 3;
            // 
            // txt_Notepad
            // 
            this.txt_Notepad.Location = new System.Drawing.Point(15, 45);
            this.txt_Notepad.Multiline = true;
            this.txt_Notepad.Name = "txt_Notepad";
            this.txt_Notepad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Notepad.Size = new System.Drawing.Size(806, 298);
            this.txt_Notepad.TabIndex = 4;
            // 
            // panel_wordbuilder
            // 
            this.panel_wordbuilder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_wordbuilder.Controls.Add(this.txt_Mode_Status);
            this.panel_wordbuilder.Controls.Add(this.txt_WordBuilder);
            this.panel_wordbuilder.Location = new System.Drawing.Point(278, 352);
            this.panel_wordbuilder.Name = "panel_wordbuilder";
            this.panel_wordbuilder.Size = new System.Drawing.Size(265, 41);
            this.panel_wordbuilder.TabIndex = 6;
            // 
            // txt_Mode_Status
            // 
            this.txt_Mode_Status.BackColor = System.Drawing.Color.White;
            this.txt_Mode_Status.Location = new System.Drawing.Point(197, 10);
            this.txt_Mode_Status.Name = "txt_Mode_Status";
            this.txt_Mode_Status.ReadOnly = true;
            this.txt_Mode_Status.Size = new System.Drawing.Size(61, 20);
            this.txt_Mode_Status.TabIndex = 4;
            this.txt_Mode_Status.Text = "Multi-Press";
            // 
            // txt_WordBuilder
            // 
            this.txt_WordBuilder.Location = new System.Drawing.Point(3, 6);
            this.txt_WordBuilder.Name = "txt_WordBuilder";
            this.txt_WordBuilder.Size = new System.Drawing.Size(192, 28);
            this.txt_WordBuilder.TabIndex = 3;
            this.txt_WordBuilder.Text = "";
            // 
            // panel_buttons
            // 
            this.panel_buttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_buttons.Controls.Add(this.btn_Eleven);
            this.panel_buttons.Controls.Add(this.btn_Submit);
            this.panel_buttons.Controls.Add(this.btn_Ten);
            this.panel_buttons.Controls.Add(this.btn_Three);
            this.panel_buttons.Controls.Add(this.btn_Two);
            this.panel_buttons.Controls.Add(this.btn_One);
            this.panel_buttons.Controls.Add(this.btn_Six);
            this.panel_buttons.Controls.Add(this.btn_Five);
            this.panel_buttons.Controls.Add(this.btn_Four);
            this.panel_buttons.Controls.Add(this.btn_Nine);
            this.panel_buttons.Controls.Add(this.btn_Eight);
            this.panel_buttons.Controls.Add(this.btn_Seven);
            this.panel_buttons.Controls.Add(this.btn_Enter);
            this.panel_buttons.Controls.Add(this.btn_NotUsed2);
            this.panel_buttons.Controls.Add(this.btn_NotUsed1);
            this.panel_buttons.Controls.Add(this.btn_Send_Predicted);
            this.panel_buttons.Controls.Add(this.btn_Previous);
            this.panel_buttons.Controls.Add(this.btn_Next);
            this.panel_buttons.Controls.Add(this.btn_Mode);
            this.panel_buttons.Location = new System.Drawing.Point(278, 394);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(265, 269);
            this.panel_buttons.TabIndex = 7;
            // 
            // btn_Eleven
            // 
            this.btn_Eleven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Eleven.Location = new System.Drawing.Point(137, 207);
            this.btn_Eleven.Name = "btn_Eleven";
            this.btn_Eleven.Size = new System.Drawing.Size(58, 50);
            this.btn_Eleven.TabIndex = 36;
            this.btn_Eleven.Text = "#\r\n000";
            this.btn_Eleven.UseVisualStyleBackColor = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Submit.Location = new System.Drawing.Point(73, 207);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(58, 50);
            this.btn_Submit.TabIndex = 35;
            this.btn_Submit.Text = "000\r\n[ _ }";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Ten
            // 
            this.btn_Ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Ten.Location = new System.Drawing.Point(9, 207);
            this.btn_Ten.Name = "btn_Ten";
            this.btn_Ten.Size = new System.Drawing.Size(58, 50);
            this.btn_Ten.TabIndex = 34;
            this.btn_Ten.Text = "* - _";
            this.btn_Ten.UseVisualStyleBackColor = false;
            // 
            // btn_Three
            // 
            this.btn_Three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Three.Location = new System.Drawing.Point(137, 156);
            this.btn_Three.Name = "btn_Three";
            this.btn_Three.Size = new System.Drawing.Size(58, 50);
            this.btn_Three.TabIndex = 33;
            this.btn_Three.Text = "3\r\nW X Y Z";
            this.btn_Three.UseVisualStyleBackColor = false;
            this.btn_Three.Click += new System.EventHandler(this.btn_Three_Click);
            // 
            // btn_Two
            // 
            this.btn_Two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Two.Location = new System.Drawing.Point(73, 156);
            this.btn_Two.Name = "btn_Two";
            this.btn_Two.Size = new System.Drawing.Size(58, 50);
            this.btn_Two.TabIndex = 32;
            this.btn_Two.Text = "2\r\nT U V";
            this.btn_Two.UseVisualStyleBackColor = false;
            this.btn_Two.Click += new System.EventHandler(this.btn_Two_Click);
            // 
            // btn_One
            // 
            this.btn_One.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_One.Location = new System.Drawing.Point(9, 156);
            this.btn_One.Name = "btn_One";
            this.btn_One.Size = new System.Drawing.Size(58, 50);
            this.btn_One.TabIndex = 31;
            this.btn_One.Text = "1\r\nP Q R S";
            this.btn_One.UseVisualStyleBackColor = false;
            this.btn_One.Click += new System.EventHandler(this.btn_One_Click);
            // 
            // btn_Six
            // 
            this.btn_Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Six.Location = new System.Drawing.Point(137, 105);
            this.btn_Six.Name = "btn_Six";
            this.btn_Six.Size = new System.Drawing.Size(58, 50);
            this.btn_Six.TabIndex = 30;
            this.btn_Six.Text = "6\r\nM N O";
            this.btn_Six.UseVisualStyleBackColor = false;
            // 
            // btn_Five
            // 
            this.btn_Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Five.Location = new System.Drawing.Point(73, 105);
            this.btn_Five.Name = "btn_Five";
            this.btn_Five.Size = new System.Drawing.Size(58, 50);
            this.btn_Five.TabIndex = 29;
            this.btn_Five.Text = "5\r\nJ K L";
            this.btn_Five.UseVisualStyleBackColor = false;
            // 
            // btn_Four
            // 
            this.btn_Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Four.Location = new System.Drawing.Point(9, 105);
            this.btn_Four.Name = "btn_Four";
            this.btn_Four.Size = new System.Drawing.Size(58, 50);
            this.btn_Four.TabIndex = 28;
            this.btn_Four.Text = "4\r\nG H I";
            this.btn_Four.UseVisualStyleBackColor = false;
            this.btn_Four.Click += new System.EventHandler(this.btn_Four_Click);
            // 
            // btn_Nine
            // 
            this.btn_Nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Nine.Location = new System.Drawing.Point(137, 54);
            this.btn_Nine.Name = "btn_Nine";
            this.btn_Nine.Size = new System.Drawing.Size(58, 50);
            this.btn_Nine.TabIndex = 27;
            this.btn_Nine.Text = "9\r\nD E F";
            this.btn_Nine.UseVisualStyleBackColor = false;
            // 
            // btn_Eight
            // 
            this.btn_Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Eight.Location = new System.Drawing.Point(73, 54);
            this.btn_Eight.Name = "btn_Eight";
            this.btn_Eight.Size = new System.Drawing.Size(58, 50);
            this.btn_Eight.TabIndex = 26;
            this.btn_Eight.Text = "8\r\nA B C";
            this.btn_Eight.UseVisualStyleBackColor = false;
            // 
            // btn_Seven
            // 
            this.btn_Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Seven.Location = new System.Drawing.Point(9, 54);
            this.btn_Seven.Name = "btn_Seven";
            this.btn_Seven.Size = new System.Drawing.Size(58, 50);
            this.btn_Seven.TabIndex = 25;
            this.btn_Seven.Text = "7\r\n. , \"\r\n";
            this.btn_Seven.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Enter.Location = new System.Drawing.Point(201, 156);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(58, 101);
            this.btn_Enter.TabIndex = 24;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_NotUsed2
            // 
            this.btn_NotUsed2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_NotUsed2.Location = new System.Drawing.Point(201, 105);
            this.btn_NotUsed2.Name = "btn_NotUsed2";
            this.btn_NotUsed2.Size = new System.Drawing.Size(58, 50);
            this.btn_NotUsed2.TabIndex = 23;
            this.btn_NotUsed2.UseVisualStyleBackColor = false;
            // 
            // btn_NotUsed1
            // 
            this.btn_NotUsed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_NotUsed1.Location = new System.Drawing.Point(201, 54);
            this.btn_NotUsed1.Name = "btn_NotUsed1";
            this.btn_NotUsed1.Size = new System.Drawing.Size(58, 50);
            this.btn_NotUsed1.TabIndex = 22;
            this.btn_NotUsed1.UseVisualStyleBackColor = false;
            // 
            // btn_Send_Predicted
            // 
            this.btn_Send_Predicted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Send_Predicted.Location = new System.Drawing.Point(201, 3);
            this.btn_Send_Predicted.Name = "btn_Send_Predicted";
            this.btn_Send_Predicted.Size = new System.Drawing.Size(58, 50);
            this.btn_Send_Predicted.TabIndex = 21;
            this.btn_Send_Predicted.Text = "Show\r\nPred-\r\niction";
            this.btn_Send_Predicted.UseVisualStyleBackColor = false;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Previous.Location = new System.Drawing.Point(137, 3);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(58, 50);
            this.btn_Previous.TabIndex = 7;
            this.btn_Previous.Text = "Prev-\r\nious";
            this.btn_Previous.UseVisualStyleBackColor = false;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Next.Location = new System.Drawing.Point(73, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(58, 50);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // btn_Mode
            // 
            this.btn_Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Mode.Location = new System.Drawing.Point(9, 3);
            this.btn_Mode.Name = "btn_Mode";
            this.btn_Mode.Size = new System.Drawing.Size(58, 50);
            this.btn_Mode.TabIndex = 5;
            this.btn_Mode.Text = "Mode";
            this.btn_Mode.UseVisualStyleBackColor = false;
            this.btn_Mode.Click += new System.EventHandler(this.btn_Mode_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lstb_One
            // 
            this.lstb_One.FormattingEnabled = true;
            this.lstb_One.Items.AddRange(new object[] {
            "p",
            "q",
            "r",
            "s",
            "1",
            "P",
            "Q",
            "R",
            "S"});
            this.lstb_One.Location = new System.Drawing.Point(546, 354);
            this.lstb_One.Name = "lstb_One";
            this.lstb_One.Size = new System.Drawing.Size(19, 121);
            this.lstb_One.TabIndex = 8;
            this.lstb_One.Visible = false;
            // 
            // lstb_Two
            // 
            this.lstb_Two.FormattingEnabled = true;
            this.lstb_Two.Items.AddRange(new object[] {
            "t",
            "u",
            "v",
            "2",
            "T",
            "U",
            "V"});
            this.lstb_Two.Location = new System.Drawing.Point(571, 354);
            this.lstb_Two.Name = "lstb_Two";
            this.lstb_Two.Size = new System.Drawing.Size(19, 121);
            this.lstb_Two.TabIndex = 9;
            this.lstb_Two.Visible = false;
            // 
            // lstb_Three
            // 
            this.lstb_Three.FormattingEnabled = true;
            this.lstb_Three.Items.AddRange(new object[] {
            "w",
            "x",
            "y",
            "z",
            "3",
            "W",
            "X",
            "Y",
            "Z"});
            this.lstb_Three.Location = new System.Drawing.Point(596, 354);
            this.lstb_Three.Name = "lstb_Three";
            this.lstb_Three.Size = new System.Drawing.Size(19, 121);
            this.lstb_Three.TabIndex = 10;
            this.lstb_Three.Visible = false;
            // 
            // lstb_Six
            // 
            this.lstb_Six.FormattingEnabled = true;
            this.lstb_Six.Items.AddRange(new object[] {
            "m",
            "n",
            "o",
            "6",
            "M",
            "N",
            "O"});
            this.lstb_Six.Location = new System.Drawing.Point(671, 354);
            this.lstb_Six.Name = "lstb_Six";
            this.lstb_Six.Size = new System.Drawing.Size(19, 121);
            this.lstb_Six.TabIndex = 13;
            this.lstb_Six.Visible = false;
            // 
            // lstb_Five
            // 
            this.lstb_Five.FormattingEnabled = true;
            this.lstb_Five.Items.AddRange(new object[] {
            "j",
            "k",
            "l",
            "5",
            "J",
            "K",
            "L"});
            this.lstb_Five.Location = new System.Drawing.Point(646, 354);
            this.lstb_Five.Name = "lstb_Five";
            this.lstb_Five.Size = new System.Drawing.Size(19, 121);
            this.lstb_Five.TabIndex = 12;
            this.lstb_Five.Visible = false;
            // 
            // lstb_Four
            // 
            this.lstb_Four.FormattingEnabled = true;
            this.lstb_Four.Items.AddRange(new object[] {
            "g",
            "h",
            "i",
            "4",
            "G",
            "H",
            "I"});
            this.lstb_Four.Location = new System.Drawing.Point(621, 354);
            this.lstb_Four.Name = "lstb_Four";
            this.lstb_Four.Size = new System.Drawing.Size(19, 121);
            this.lstb_Four.TabIndex = 11;
            this.lstb_Four.Visible = false;
            // 
            // lstb_Eleven
            // 
            this.lstb_Eleven.FormattingEnabled = true;
            this.lstb_Eleven.Items.AddRange(new object[] {
            "#",
            "-",
            "_"});
            this.lstb_Eleven.Location = new System.Drawing.Point(796, 354);
            this.lstb_Eleven.Name = "lstb_Eleven";
            this.lstb_Eleven.Size = new System.Drawing.Size(19, 121);
            this.lstb_Eleven.TabIndex = 18;
            this.lstb_Eleven.Visible = false;
            // 
            // lstb_Ten
            // 
            this.lstb_Ten.FormattingEnabled = true;
            this.lstb_Ten.Items.AddRange(new object[] {
            "*",
            "-",
            "_"});
            this.lstb_Ten.Location = new System.Drawing.Point(771, 354);
            this.lstb_Ten.Name = "lstb_Ten";
            this.lstb_Ten.Size = new System.Drawing.Size(19, 121);
            this.lstb_Ten.TabIndex = 17;
            this.lstb_Ten.Visible = false;
            // 
            // lstb_Nine
            // 
            this.lstb_Nine.FormattingEnabled = true;
            this.lstb_Nine.Items.AddRange(new object[] {
            "d",
            "e",
            "f",
            "9",
            "D",
            "E",
            "F"});
            this.lstb_Nine.Location = new System.Drawing.Point(746, 354);
            this.lstb_Nine.Name = "lstb_Nine";
            this.lstb_Nine.Size = new System.Drawing.Size(19, 121);
            this.lstb_Nine.TabIndex = 16;
            this.lstb_Nine.Visible = false;
            // 
            // lstb_Eight
            // 
            this.lstb_Eight.FormattingEnabled = true;
            this.lstb_Eight.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "8",
            "A",
            "B",
            "C"});
            this.lstb_Eight.Location = new System.Drawing.Point(721, 354);
            this.lstb_Eight.Name = "lstb_Eight";
            this.lstb_Eight.Size = new System.Drawing.Size(19, 121);
            this.lstb_Eight.TabIndex = 15;
            this.lstb_Eight.Visible = false;
            // 
            // lstb_Seven
            // 
            this.lstb_Seven.FormattingEnabled = true;
            this.lstb_Seven.Items.AddRange(new object[] {
            ".",
            "~",
            "\"",
            "7",
            "\'",
            ":",
            ";"});
            this.lstb_Seven.Location = new System.Drawing.Point(696, 354);
            this.lstb_Seven.Name = "lstb_Seven";
            this.lstb_Seven.Size = new System.Drawing.Size(19, 121);
            this.lstb_Seven.TabIndex = 14;
            this.lstb_Seven.Visible = false;
            // 
            // txt_KeySequence
            // 
            this.txt_KeySequence.Location = new System.Drawing.Point(547, 482);
            this.txt_KeySequence.Multiline = true;
            this.txt_KeySequence.Name = "txt_KeySequence";
            this.txt_KeySequence.Size = new System.Drawing.Size(267, 68);
            this.txt_KeySequence.TabIndex = 19;
            this.txt_KeySequence.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(836, 675);
            this.Controls.Add(this.txt_KeySequence);
            this.Controls.Add(this.lstb_Eleven);
            this.Controls.Add(this.lstb_Ten);
            this.Controls.Add(this.lstb_Nine);
            this.Controls.Add(this.lstb_Eight);
            this.Controls.Add(this.lstb_Seven);
            this.Controls.Add(this.lstb_Six);
            this.Controls.Add(this.lstb_Five);
            this.Controls.Add(this.lstb_Four);
            this.Controls.Add(this.lstb_Three);
            this.Controls.Add(this.lstb_Two);
            this.Controls.Add(this.lstb_One);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_wordbuilder);
            this.Controls.Add(this.txt_Notepad);
            this.Controls.Add(this.panel_notepad);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Keyboard v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_wordbuilder.ResumeLayout(false);
            this.panel_wordbuilder.PerformLayout();
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel_notepad;
        private System.Windows.Forms.TextBox txt_Notepad;
        private System.Windows.Forms.Panel panel_wordbuilder;
        private System.Windows.Forms.TextBox txt_Mode_Status;
        private System.Windows.Forms.RichTextBox txt_WordBuilder;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Mode;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_NotUsed2;
        private System.Windows.Forms.Button btn_NotUsed1;
        private System.Windows.Forms.Button btn_Send_Predicted;
        private System.Windows.Forms.Button btn_Eleven;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Ten;
        private System.Windows.Forms.Button btn_Three;
        private System.Windows.Forms.Button btn_Two;
        private System.Windows.Forms.Button btn_One;
        private System.Windows.Forms.Button btn_Six;
        private System.Windows.Forms.Button btn_Five;
        private System.Windows.Forms.Button btn_Four;
        private System.Windows.Forms.Button btn_Nine;
        private System.Windows.Forms.Button btn_Eight;
        private System.Windows.Forms.Button btn_Seven;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ListBox lstb_One;
        private System.Windows.Forms.ListBox lstb_Two;
        private System.Windows.Forms.ListBox lstb_Three;
        private System.Windows.Forms.ListBox lstb_Six;
        private System.Windows.Forms.ListBox lstb_Five;
        private System.Windows.Forms.ListBox lstb_Four;
        private System.Windows.Forms.ListBox lstb_Eleven;
        private System.Windows.Forms.ListBox lstb_Ten;
        private System.Windows.Forms.ListBox lstb_Nine;
        private System.Windows.Forms.ListBox lstb_Eight;
        private System.Windows.Forms.ListBox lstb_Seven;
        private System.Windows.Forms.TextBox txt_KeySequence;
    }
}

