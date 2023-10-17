namespace LibraryManagementSystem
{
    partial class AdminForm
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
            dataGridView1 = new DataGridView();
            BookIdColumn = new DataGridViewTextBoxColumn();
            TitleColumn = new DataGridViewTextBoxColumn();
            AuthorColumn = new DataGridViewTextBoxColumn();
            ISBNColumn = new DataGridViewTextBoxColumn();
            isAvailableColumn = new DataGridViewCheckBoxColumn();
            bookBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookIdColumn, TitleColumn, AuthorColumn, ISBNColumn, isAvailableColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(610, 348);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookIdColumn
            // 
            BookIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BookIdColumn.DataPropertyName = "BookId";
            BookIdColumn.HeaderText = "BookId";
            BookIdColumn.MinimumWidth = 8;
            BookIdColumn.Name = "BookIdColumn";
            BookIdColumn.ReadOnly = true;
            BookIdColumn.Width = 76;
            // 
            // TitleColumn
            // 
            TitleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TitleColumn.DataPropertyName = "Title";
            TitleColumn.HeaderText = "Title";
            TitleColumn.MinimumWidth = 8;
            TitleColumn.Name = "TitleColumn";
            TitleColumn.Width = 57;
            // 
            // AuthorColumn
            // 
            AuthorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AuthorColumn.DataPropertyName = "Author";
            AuthorColumn.HeaderText = "Author";
            AuthorColumn.MinimumWidth = 8;
            AuthorColumn.Name = "AuthorColumn";
            AuthorColumn.Width = 72;
            // 
            // ISBNColumn
            // 
            ISBNColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ISBNColumn.DataPropertyName = "ISBN";
            ISBNColumn.HeaderText = "ISBN";
            ISBNColumn.MinimumWidth = 8;
            ISBNColumn.Name = "ISBNColumn";
            ISBNColumn.Width = 62;
            // 
            // isAvailableColumn
            // 
            isAvailableColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            isAvailableColumn.DataPropertyName = "IsAvailable";
            isAvailableColumn.HeaderText = "IsAvailable";
            isAvailableColumn.MinimumWidth = 8;
            isAvailableColumn.Name = "isAvailableColumn";
            isAvailableColumn.Width = 76;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // button1
            // 
            button1.Location = new Point(645, 26);
            button1.Name = "button1";
            button1.Size = new Size(105, 25);
            button1.TabIndex = 1;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(645, 69);
            button2.Name = "button2";
            button2.Size = new Size(105, 25);
            button2.TabIndex = 2;
            button2.Text = "Modify Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(645, 117);
            button3.Name = "button3";
            button3.Size = new Size(105, 25);
            button3.TabIndex = 3;
            button3.Text = "Delete Book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(645, 165);
            button4.Name = "button4";
            button4.Size = new Size(105, 25);
            button4.TabIndex = 4;
            button4.Text = "Add Reception";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(645, 209);
            button5.Name = "button5";
            button5.Size = new Size(105, 24);
            button5.TabIndex = 5;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 372);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminForm";
            Text = "Admin Page";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn TitleColumn;
        private DataGridViewTextBoxColumn AuthorColumn;
        private DataGridViewTextBoxColumn ISBNColumn;
        private DataGridViewCheckBoxColumn isAvailableColumn;
        private Button button5;
    }
}