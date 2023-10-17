namespace LibraryManagementSystem
{
    partial class PersonalInfo
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            bookBindingSource = new BindingSource(components);
            button1 = new Button();
            dataGridView1 = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            bookBindingSource3 = new BindingSource(components);
            bookBindingSource2 = new BindingSource(components);
            userbooksBindingSource = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userbooksBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.818182F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 0;
            label1.Text = "Personal Information";
            label1.Click += label1_Click;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            bookBindingSource.CurrentChanged += bookBindingSource_CurrentChanged;
            // 
            // button1
            // 
            button1.Location = new Point(534, 58);
            button1.Name = "button1";
            button1.Size = new Size(113, 45);
            button1.TabIndex = 2;
            button1.Text = "Return a book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookId, Title, Author, ISBN });
            dataGridView1.DataSource = bookBindingSource3;
            dataGridView1.Location = new Point(2, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 42;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(513, 265);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookId
            // 
            BookId.DataPropertyName = "BookId";
            BookId.HeaderText = "BookId";
            BookId.Name = "BookId";
            BookId.Width = 103;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 103;
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 103;
            // 
            // ISBN
            // 
            ISBN.DataPropertyName = "ISBN";
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            ISBN.ReadOnly = true;
            ISBN.Width = 103;
            // 
            // bookBindingSource3
            // 
            bookBindingSource3.DataSource = typeof(Book);
            // 
            // bookBindingSource2
            // 
            bookBindingSource2.DataSource = typeof(Book);
            // 
            // userbooksBindingSource
            // 
            userbooksBindingSource.DataSource = typeof(userbooks);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(userbooks);
            bookBindingSource1.CurrentChanged += bookBindingSource1_CurrentChanged;
            // 
            // button3
            // 
            button3.Location = new Point(534, 224);
            button3.Name = "button3";
            button3.Size = new Size(113, 45);
            button3.TabIndex = 5;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PersonalInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 314);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PersonalInfo";
            Text = "PersonalInfo";
            Load += PersonalInfo_Load;
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userbooksBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bookBindingSource;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource bookBindingSource1;
        private BindingSource userbooksBindingSource;
        private BindingSource bookBindingSource2;
        private BindingSource bookBindingSource3;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn ISBN;
        private Button button3;
    }
}