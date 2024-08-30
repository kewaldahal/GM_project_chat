namespace LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            welcome = new Label();
            userbox = new TextBox();
            passbox = new TextBox();
            loginmsg = new Label();
            nothavinaccount = new Label();
            linkLabel1 = new LinkLabel();
            loginbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = SystemColors.ButtonHighlight;
            welcome.Font = new Font("Bernard MT Condensed", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome.ForeColor = Color.Fuchsia;
            welcome.Location = new Point(51, 51);
            welcome.Name = "welcome";
            welcome.Size = new Size(354, 55);
            welcome.TabIndex = 0;
            welcome.Text = "Welcome To ChatX";
            // 
            // userbox
            // 
            userbox.Location = new Point(71, 237);
            userbox.Multiline = true;
            userbox.Name = "userbox";
            userbox.PlaceholderText = "Username";
            userbox.Size = new Size(307, 34);
            userbox.TabIndex = 2;
            userbox.TextChanged += textBox1_TextChanged;
            // 
            // passbox
            // 
            passbox.Location = new Point(71, 300);
            passbox.Multiline = true;
            passbox.Name = "passbox";
            passbox.PlaceholderText = "Password";
            passbox.Size = new Size(307, 34);
            passbox.TabIndex = 3;
            // 
            // loginmsg
            // 
            loginmsg.AutoSize = true;
            loginmsg.BackColor = SystemColors.ButtonHighlight;
            loginmsg.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            loginmsg.ForeColor = Color.DarkViolet;
            loginmsg.Location = new Point(58, 182);
            loginmsg.Name = "loginmsg";
            loginmsg.Size = new Size(347, 33);
            loginmsg.TabIndex = 4;
            loginmsg.Text = "Login to your account";
            loginmsg.Click += label1_Click_2;
            // 
            // nothavinaccount
            // 
            nothavinaccount.AutoSize = true;
            nothavinaccount.BackColor = SystemColors.ButtonHighlight;
            nothavinaccount.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nothavinaccount.ForeColor = Color.DarkViolet;
            nothavinaccount.Location = new Point(96, 399);
            nothavinaccount.Name = "nothavinaccount";
            nothavinaccount.Size = new Size(239, 21);
            nothavinaccount.TabIndex = 5;
            nothavinaccount.Text = "Don't have an account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(143, 445);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Now";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.Gray;
            loginbtn.Location = new Point(167, 340);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(94, 29);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(411, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(768, 585);
            Controls.Add(pictureBox1);
            Controls.Add(loginbtn);
            Controls.Add(linkLabel1);
            Controls.Add(nothavinaccount);
            Controls.Add(loginmsg);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(welcome);
            Name = "Form1";
            Text = "loginPage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private TextBox userbox;
        private TextBox passbox;
        private Label loginmsg;
        private Label nothavinaccount;
        private LinkLabel linkLabel1;
        private Button loginbtn;
        private PictureBox pictureBox1;
    }
}
