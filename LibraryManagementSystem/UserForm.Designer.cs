namespace LibraryManagementSystem
{
    partial class UserForm
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
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            bookBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookIdColumn, titleDataGridViewTextBoxColumn, authorDataGridViewTextBoxColumn, iSBNDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 42;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(587, 305);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookIdColumn
            // 
            BookIdColumn.DataPropertyName = "BookId";
            BookIdColumn.HeaderText = "BookId";
            BookIdColumn.Name = "BookIdColumn";
            BookIdColumn.ReadOnly = true;
            BookIdColumn.Width = 103;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 103;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            authorDataGridViewTextBoxColumn.HeaderText = "Author";
            authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            authorDataGridViewTextBoxColumn.ReadOnly = true;
            authorDataGridViewTextBoxColumn.Width = 103;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            iSBNDataGridViewTextBoxColumn.Width = 103;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.ReadOnly = true;
            isAvailableDataGridViewCheckBoxColumn.Width = 103;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // button1
            // 
            button1.Location = new Point(625, 35);
            button1.Name = "button1";
            button1.Size = new Size(122, 43);
            button1.TabIndex = 1;
            button1.Text = "Borrow a book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(625, 100);
            button2.Name = "button2";
            button2.Size = new Size(122, 42);
            button2.TabIndex = 2;
            button2.Text = "Personal Information";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(625, 169);
            button3.Name = "button3";
            button3.Size = new Size(122, 42);
            button3.TabIndex = 3;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 363);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "UserForm";
            Text = "User Page";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bookBindingSource;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn BookIdColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private Button button3;
    }
}