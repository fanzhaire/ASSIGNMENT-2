namespace LibraryManagementSystem
{
    partial class AddBookForm
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
            label3 = new Label();
            label4 = new Label();
            btnOK = new Button();
            chkIsAvailable = new CheckBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 79);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 142);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 1;
            label2.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 204);
            label3.Name = "label3";
            label3.Size = new Size(55, 24);
            label3.TabIndex = 2;
            label3.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 266);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 3;
            label4.Text = "IsAvailable:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(225, 316);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Location = new Point(168, 269);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(22, 21);
            chkIsAvailable.TabIndex = 5;
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(122, 80);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(361, 30);
            txtTitle.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(122, 142);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(361, 30);
            txtAuthor.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(122, 204);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(361, 30);
            txtISBN.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(215, 23);
            label5.Name = "label5";
            label5.Size = new Size(133, 31);
            label5.TabIndex = 9;
            label5.Text = "Add Book";
            label5.Click += label5_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 394);
            Controls.Add(label5);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(chkIsAvailable);
            Controls.Add(btnOK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnOK;
        private CheckBox chkIsAvailable;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private Label label5;
    }
}