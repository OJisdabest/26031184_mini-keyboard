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
            this.txt_WordBuilder = new System.Windows.Forms.RichTextBox();
            this.txt_Mode_Status = new System.Windows.Forms.TextBox();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Mode = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_NotUsed2 = new System.Windows.Forms.Button();
            this.btn_NotUsed1 = new System.Windows.Forms.Button();
            this.btn_Send_Predicted = new System.Windows.Forms.Button();
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // txt_WordBuilder
            // 
            this.txt_WordBuilder.Location = new System.Drawing.Point(3, 6);
            this.txt_WordBuilder.Name = "txt_WordBuilder";
            this.txt_WordBuilder.Size = new System.Drawing.Size(192, 28);
            this.txt_WordBuilder.TabIndex = 3;
            this.txt_WordBuilder.Text = "";
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
            // panel_buttons
            // 
            this.panel_buttons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(836, 675);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.panel_wordbuilder);
            this.Controls.Add(this.txt_Notepad);
            this.Controls.Add(this.panel_notepad);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Keyboard v1.0";
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
    }
}

