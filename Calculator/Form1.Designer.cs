namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firsttextBox = new System.Windows.Forms.TextBox();
            this.secondtextBox = new System.Windows.Forms.TextBox();
            this.rusultshow = new System.Windows.Forms.TextBox();
            this.sumbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // firsttextBox
            // 
            this.firsttextBox.Location = new System.Drawing.Point(82, 69);
            this.firsttextBox.Name = "firsttextBox";
            this.firsttextBox.Size = new System.Drawing.Size(135, 23);
            this.firsttextBox.TabIndex = 1;
            // 
            // secondtextBox
            // 
            this.secondtextBox.Location = new System.Drawing.Point(264, 69);
            this.secondtextBox.Name = "secondtextBox";
            this.secondtextBox.Size = new System.Drawing.Size(135, 23);
            this.secondtextBox.TabIndex = 1;
            // 
            // rusultshow
            // 
            this.rusultshow.Location = new System.Drawing.Point(171, 139);
            this.rusultshow.Name = "rusultshow";
            this.rusultshow.Size = new System.Drawing.Size(135, 23);
            this.rusultshow.TabIndex = 1;
            // 
            // sumbutton
            // 
            this.sumbutton.Location = new System.Drawing.Point(478, 68);
            this.sumbutton.Name = "sumbutton";
            this.sumbutton.Size = new System.Drawing.Size(83, 23);
            this.sumbutton.TabIndex = 2;
            this.sumbutton.Text = "+";
            this.sumbutton.UseVisualStyleBackColor = true;
            this.sumbutton.Click += new System.EventHandler(this.sumbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(586, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sumbutton);
            this.Controls.Add(this.rusultshow);
            this.Controls.Add(this.secondtextBox);
            this.Controls.Add(this.firsttextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private TextBox firsttextBox;
        private TextBox secondtextBox;
        private TextBox rusultshow;
        private Button sumbutton;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}