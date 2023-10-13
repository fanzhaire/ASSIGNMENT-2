namespace LibraryManagementSystem
{
    partial class AddReceptionForm
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnAddReception = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 107);
            label1.Name = "label1";
            label1.Size = new Size(104, 24);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 188);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(163, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(294, 30);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(163, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(294, 30);
            txtPassword.TabIndex = 3;
            // 
            // btnAddReception
            // 
            btnAddReception.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddReception.Location = new Point(219, 293);
            btnAddReception.Name = "btnAddReception";
            btnAddReception.Size = new Size(112, 34);
            btnAddReception.TabIndex = 4;
            btnAddReception.Text = "Confirm";
            btnAddReception.UseVisualStyleBackColor = true;
            btnAddReception.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(108, 28);
            label3.Name = "label3";
            label3.Size = new Size(331, 37);
            label3.TabIndex = 5;
            label3.Text = "Add New Receptionist";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddReceptionForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 394);
            Controls.Add(label3);
            Controls.Add(btnAddReception);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddReceptionForm";
            Text = "AddReceptionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnAddReception;
        private Label label3;
    }
}