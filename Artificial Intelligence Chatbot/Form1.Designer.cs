namespace Artificial_Intelligence_Chatbot
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.SendBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Black;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InputBox.Location = new System.Drawing.Point(12, 385);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(226, 20);
            this.InputBox.TabIndex = 1;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.Color.Black;
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OutputBox.Location = new System.Drawing.Point(13, 180);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(259, 194);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "Hi There!\r\nHow Can I Help You?";
            this.OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainLogo
            // 
            this.MainLogo.Image = global::Artificial_Intelligence_Chatbot.Properties.Resources._1;
            this.MainLogo.Location = new System.Drawing.Point(12, 12);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(260, 162);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLogo.TabIndex = 0;
            this.MainLogo.TabStop = false;
            // 
            // SendBtn
            // 
            this.SendBtn.Image = global::Artificial_Intelligence_Chatbot.Properties.Resources.icons8_Sent_512px;
            this.SendBtn.Location = new System.Drawing.Point(244, 380);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(29, 30);
            this.SendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SendBtn.TabIndex = 3;
            this.SendBtn.TabStop = false;
            this.SendBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.MainLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artificial Intelligence Bot AIML";
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.PictureBox SendBtn;
    }
}

