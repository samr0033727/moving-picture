namespace WindowsFormsApp2
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "right";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.right_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._103105608_sita_akauola_swpix;
            this.pictureBox1.Location = new System.Drawing.Point(210, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 89);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.up_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "down";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.down_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.left_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(591, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "square";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.square_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(592, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 67);
            this.button6.TabIndex = 7;
            this.button6.Text = "triangle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.triangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "form 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

