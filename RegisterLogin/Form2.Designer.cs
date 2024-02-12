
namespace RegisterLogin
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AsterTextBox1 = new System.Windows.Forms.TextBox();
            this.AsterTextBox2 = new System.Windows.Forms.TextBox();
            this.AsterTextBox3 = new System.Windows.Forms.TextBox();
            this.AsterTextBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1088, 657);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AsterTextBox1
            // 
            this.AsterTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AsterTextBox1.Location = new System.Drawing.Point(234, 116);
            this.AsterTextBox1.Multiline = true;
            this.AsterTextBox1.Name = "AsterTextBox1";
            this.AsterTextBox1.Size = new System.Drawing.Size(612, 57);
            this.AsterTextBox1.TabIndex = 1;
            this.AsterTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AsterTextBox2
            // 
            this.AsterTextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AsterTextBox2.Location = new System.Drawing.Point(234, 204);
            this.AsterTextBox2.Multiline = true;
            this.AsterTextBox2.Name = "AsterTextBox2";
            this.AsterTextBox2.Size = new System.Drawing.Size(612, 57);
            this.AsterTextBox2.TabIndex = 2;
            this.AsterTextBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AsterTextBox3
            // 
            this.AsterTextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AsterTextBox3.Location = new System.Drawing.Point(234, 293);
            this.AsterTextBox3.Multiline = true;
            this.AsterTextBox3.Name = "AsterTextBox3";
            this.AsterTextBox3.Size = new System.Drawing.Size(612, 57);
            this.AsterTextBox3.TabIndex = 3;
            // 
            // AsterTextBox4
            // 
            this.AsterTextBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AsterTextBox4.Location = new System.Drawing.Point(234, 383);
            this.AsterTextBox4.Multiline = true;
            this.AsterTextBox4.Name = "AsterTextBox4";
            this.AsterTextBox4.Size = new System.Drawing.Size(612, 57);
            this.AsterTextBox4.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 643);
            this.Controls.Add(this.AsterTextBox4);
            this.Controls.Add(this.AsterTextBox3);
            this.Controls.Add(this.AsterTextBox2);
            this.Controls.Add(this.AsterTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox AsterTextBox1;
        private System.Windows.Forms.TextBox AsterTextBox2;
        private System.Windows.Forms.TextBox AsterTextBox3;
        private System.Windows.Forms.TextBox AsterTextBox4;
    }
}