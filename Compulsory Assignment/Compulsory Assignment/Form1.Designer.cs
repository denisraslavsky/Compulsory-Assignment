
namespace Compulsory_Assignment
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
            this.button_Sequential = new System.Windows.Forms.Button();
            this.button_Parallel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_Start = new System.Windows.Forms.TextBox();
            this.textBox_Last = new System.Windows.Forms.TextBox();
            this.textBox_Console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Sequential
            // 
            this.button_Sequential.Location = new System.Drawing.Point(139, 295);
            this.button_Sequential.Name = "button_Sequential";
            this.button_Sequential.Size = new System.Drawing.Size(75, 23);
            this.button_Sequential.TabIndex = 0;
            this.button_Sequential.Text = "Sequential";
            this.button_Sequential.UseVisualStyleBackColor = true;
            this.button_Sequential.Click += new System.EventHandler(this.button_Sequential_Click);
            // 
            // button_Parallel
            // 
            this.button_Parallel.Location = new System.Drawing.Point(139, 324);
            this.button_Parallel.Name = "button_Parallel";
            this.button_Parallel.Size = new System.Drawing.Size(75, 23);
            this.button_Parallel.TabIndex = 1;
            this.button_Parallel.Text = "Parallel";
            this.button_Parallel.UseVisualStyleBackColor = true;
            this.button_Parallel.Click += new System.EventHandler(this.button_Parallel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(802, 289);
            this.listBox1.TabIndex = 2;
            // 
            // textBox_Start
            // 
            this.textBox_Start.Location = new System.Drawing.Point(12, 296);
            this.textBox_Start.Name = "textBox_Start";
            this.textBox_Start.Size = new System.Drawing.Size(121, 23);
            this.textBox_Start.TabIndex = 3;
            // 
            // textBox_Last
            // 
            this.textBox_Last.Location = new System.Drawing.Point(12, 324);
            this.textBox_Last.Name = "textBox_Last";
            this.textBox_Last.Size = new System.Drawing.Size(121, 23);
            this.textBox_Last.TabIndex = 4;
            // 
            // textBox_Console
            // 
            this.textBox_Console.Location = new System.Drawing.Point(446, 296);
            this.textBox_Console.Multiline = true;
            this.textBox_Console.Name = "textBox_Console";
            this.textBox_Console.Size = new System.Drawing.Size(342, 142);
            this.textBox_Console.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Console);
            this.Controls.Add(this.textBox_Last);
            this.Controls.Add(this.textBox_Start);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Parallel);
            this.Controls.Add(this.button_Sequential);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Sequential;
        private System.Windows.Forms.Button button_Parallel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_Start;
        private System.Windows.Forms.TextBox textBox_Last;
        private System.Windows.Forms.TextBox textBox_Console;
    }
}

