namespace LibraryManagementSystem
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnRegister = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 86);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "UserAccount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 140);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(112, 221);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(97, 30);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(162, 163);
            button1.Name = "button1";
            button1.Size = new Size(109, 22);
            button1.TabIndex = 5;
            button1.Text = "Show Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 343);
            Controls.Add(button1);
            Controls.Add(btnRegister);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnRegister;
        private Button button1;
    }
}