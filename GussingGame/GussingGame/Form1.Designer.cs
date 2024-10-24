using System;

namespace GussingGame
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
            this.w_Guess = new System.Windows.Forms.TextBox();
            this.b_Guess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.w_listbox = new System.Windows.Forms.ListBox();
            this.quesser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // w_Guess
            // 
            this.w_Guess.BackColor = System.Drawing.Color.White;
            this.w_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w_Guess.Location = new System.Drawing.Point(77, 117);
            this.w_Guess.Name = "w_Guess";
            this.w_Guess.Size = new System.Drawing.Size(280, 26);
            this.w_Guess.TabIndex = 1;
            this.w_Guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.w_Guess.TextChanged += new System.EventHandler(this.w_Guess_TextChanged);
            // 
            // b_Guess
            // 
            this.b_Guess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.b_Guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guess.Location = new System.Drawing.Point(144, 149);
            this.b_Guess.Name = "b_Guess";
            this.b_Guess.Size = new System.Drawing.Size(142, 36);
            this.b_Guess.TabIndex = 2;
            this.b_Guess.Text = "Guess";
            this.b_Guess.UseVisualStyleBackColor = false;
            this.b_Guess.Click += new System.EventHandler(this.b_Guess_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(398, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Wrong Guess";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // w_listbox
            // 
            this.w_listbox.FormattingEnabled = true;
            this.w_listbox.Location = new System.Drawing.Point(398, 58);
            this.w_listbox.Name = "w_listbox";
            this.w_listbox.Size = new System.Drawing.Size(172, 108);
            this.w_listbox.TabIndex = 5;
            this.w_listbox.SelectedIndexChanged += new System.EventHandler(this.w_listboxasd_SelectedIndexChanged);
            // 
            // quesser
            // 
            this.quesser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.quesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quesser.ForeColor = System.Drawing.Color.White;
            this.quesser.Location = new System.Drawing.Point(23, 25);
            this.quesser.Name = "quesser";
            this.quesser.Size = new System.Drawing.Size(369, 89);
            this.quesser.TabIndex = 6;
            this.quesser.Text = "P _ _ _ _ _ _ _ _ _ g";
            this.quesser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quesser.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 191);
            this.Controls.Add(this.quesser);
            this.Controls.Add(this.w_listbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_Guess);
            this.Controls.Add(this.w_Guess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox w_Guess;
        private System.Windows.Forms.Button b_Guess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox w_listbox;
        private System.Windows.Forms.Label quesser;
    }
}

