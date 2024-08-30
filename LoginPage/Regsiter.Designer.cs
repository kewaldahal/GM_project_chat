namespace LoginPage
{
    partial class Regsiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regsiter));
            welcome = new Label();
            fpassbox = new TextBox();
            reguserbox = new TextBox();
            cornfirmpassbox = new TextBox();
            Regbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = SystemColors.ButtonHighlight;
            welcome.Font = new Font("Bernard MT Condensed", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.BlueViolet;
            welcome.Location = new Point(21, 35);
            welcome.Name = "welcome";
            welcome.Size = new Size(391, 55);
            welcome.TabIndex = 1;
            welcome.Text = "Get Started on ChatX";
            // 
            // fpassbox
            // 
            fpassbox.Location = new Point(48, 184);
            fpassbox.Multiline = true;
            fpassbox.Name = "fpassbox";
            fpassbox.PlaceholderText = "Password";
            fpassbox.Size = new Size(307, 34);
            fpassbox.TabIndex = 5;
            // 
            // reguserbox
            // 
            reguserbox.Location = new Point(48, 121);
            reguserbox.Multiline = true;
            reguserbox.Name = "reguserbox";
            reguserbox.PlaceholderText = "Username";
            reguserbox.Size = new Size(307, 34);
            reguserbox.TabIndex = 4;
            // 
            // cornfirmpassbox
            // 
            cornfirmpassbox.Location = new Point(48, 251);
            cornfirmpassbox.Multiline = true;
            cornfirmpassbox.Name = "cornfirmpassbox";
            cornfirmpassbox.PlaceholderText = "Cornfirm Password";
            cornfirmpassbox.Size = new Size(307, 34);
            cornfirmpassbox.TabIndex = 6;
            // 
            // Regbtn
            // 
            Regbtn.BackColor = Color.BlueViolet;
            Regbtn.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Regbtn.ForeColor = Color.White;
            Regbtn.Location = new Point(104, 318);
            Regbtn.Name = "Regbtn";
            Regbtn.Size = new Size(154, 41);
            Regbtn.TabIndex = 8;
            Regbtn.Text = "Register";
            Regbtn.UseVisualStyleBackColor = false;
            Regbtn.Click += Regbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Regsiter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 418);
            Controls.Add(pictureBox1);
            Controls.Add(Regbtn);
            Controls.Add(cornfirmpassbox);
            Controls.Add(fpassbox);
            Controls.Add(reguserbox);
            Controls.Add(welcome);
            Name = "Regsiter";
            Text = "Regsiter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private TextBox fpassbox;
        private TextBox reguserbox;
        private TextBox cornfirmpassbox;
        private Button Regbtn;
        private PictureBox pictureBox1;
    }
}