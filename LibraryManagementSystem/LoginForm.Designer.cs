namespace LibraryManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            radioUser = new RadioButton();
            radioAdmin = new RadioButton();
            radioReception = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 18.181818F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(129, 68);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(791, 50);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Library Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(344, 186);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuBar;
            label3.Location = new Point(348, 241);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(473, 182);
            txtUsername.Margin = new Padding(5, 4, 5, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(215, 30);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += textBox1_TextChanged_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(473, 237);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(215, 30);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(304, 395);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 34);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(663, 395);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 7;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioUser
            // 
            radioUser.AutoSize = true;
            radioUser.BackColor = Color.Transparent;
            radioUser.ForeColor = SystemColors.MenuBar;
            radioUser.Location = new Point(319, 312);
            radioUser.Margin = new Padding(5, 4, 5, 4);
            radioUser.Name = "radioUser";
            radioUser.Size = new Size(73, 28);
            radioUser.TabIndex = 8;
            radioUser.TabStop = true;
            radioUser.Text = "User";
            radioUser.UseVisualStyleBackColor = false;
            // 
            // radioAdmin
            // 
            radioAdmin.AutoSize = true;
            radioAdmin.BackColor = Color.Transparent;
            radioAdmin.ForeColor = SystemColors.MenuBar;
            radioAdmin.Location = new Point(493, 312);
            radioAdmin.Margin = new Padding(5, 4, 5, 4);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(93, 28);
            radioAdmin.TabIndex = 9;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Admin";
            radioAdmin.UseVisualStyleBackColor = false;
            radioAdmin.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioReception
            // 
            radioReception.AutoSize = true;
            radioReception.BackColor = Color.Transparent;
            radioReception.ForeColor = SystemColors.MenuBar;
            radioReception.Location = new Point(682, 312);
            radioReception.Margin = new Padding(5, 4, 5, 4);
            radioReception.Name = "radioReception";
            radioReception.Size = new Size(122, 28);
            radioReception.TabIndex = 10;
            radioReception.TabStop = true;
            radioReception.Text = "Reception";
            radioReception.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 525);
            Controls.Add(radioReception);
            Controls.Add(radioAdmin);
            Controls.Add(radioUser);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            Text = "Library Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private RadioButton radioUser;
        private RadioButton radioAdmin;
        private RadioButton radioReception;
    }
}