namespace LibraryApp
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
            btnOpenAddBookForm = new Button();
            panel1 = new Panel();
            txtBoxFilterBooks = new TextBox();
            label1 = new Label();
            dataGridViewBooks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            AverageRate = new DataGridViewTextBoxColumn();
            RatesCount = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            comboBoxSortBooks = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // btnOpenAddBookForm
            // 
            btnOpenAddBookForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenAddBookForm.Location = new Point(602, 55);
            btnOpenAddBookForm.Name = "btnOpenAddBookForm";
            btnOpenAddBookForm.Size = new Size(97, 33);
            btnOpenAddBookForm.TabIndex = 0;
            btnOpenAddBookForm.Text = "Dodaj książkę";
            btnOpenAddBookForm.UseVisualStyleBackColor = true;
            btnOpenAddBookForm.Click += btnOpenAddBookForm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(txtBoxFilterBooks);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 45);
            panel1.TabIndex = 3;
            // 
            // txtBoxFilterBooks
            // 
            txtBoxFilterBooks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBoxFilterBooks.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFilterBooks.Location = new Point(468, 12);
            txtBoxFilterBooks.Name = "txtBoxFilterBooks";
            txtBoxFilterBooks.PlaceholderText = "Szukaj tytułu, autora...";
            txtBoxFilterBooks.Size = new Size(231, 22);
            txtBoxFilterBooks.TabIndex = 4;
            txtBoxFilterBooks.TextChanged += txtBoxFilterBooks_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.BurlyWood;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 3;
            label1.Text = "Lista książek";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.BackgroundColor = Color.Linen;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { Id, Title, Author, AverageRate, RatesCount, delete });
            dataGridViewBooks.Dock = DockStyle.Bottom;
            dataGridViewBooks.EnableHeadersVisualStyles = false;
            dataGridViewBooks.Location = new Point(0, 101);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewBooks.RowTemplate.Height = 25;
            dataGridViewBooks.Size = new Size(711, 304);
            dataGridViewBooks.TabIndex = 4;
            dataGridViewBooks.CellMouseClick += dataGridViewBooks_CellMouseClick;
            dataGridViewBooks.CellMouseDoubleClick += dataGridViewBooks_CellMouseDoubleClick;
            dataGridViewBooks.CellMouseEnter += dataGridViewBooks_CellMouseEnter;
            dataGridViewBooks.CellMouseLeave += dataGridViewBooks_CellMouseLeave;
            dataGridViewBooks.SelectionChanged += dataGridViewBooks_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Title
            // 
            Title.HeaderText = "Tytuł";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Autor";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // AverageRate
            // 
            AverageRate.HeaderText = "Średnia ocena";
            AverageRate.Name = "AverageRate";
            AverageRate.ReadOnly = true;
            // 
            // RatesCount
            // 
            RatesCount.HeaderText = "Liczba ocen";
            RatesCount.Name = "RatesCount";
            RatesCount.ReadOnly = true;
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "Usuń";
            delete.UseColumnTextForButtonValue = true;
            // 
            // comboBoxSortBooks
            // 
            comboBoxSortBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortBooks.FormattingEnabled = true;
            comboBoxSortBooks.Items.AddRange(new object[] { "Największa liczba ocen", "Najmniejsza liczba ocen", "Najwyższa średnia ocena", "Najniższa średnia ocena" });
            comboBoxSortBooks.Location = new Point(49, 61);
            comboBoxSortBooks.Name = "comboBoxSortBooks";
            comboBoxSortBooks.Size = new Size(160, 23);
            comboBoxSortBooks.TabIndex = 5;
            comboBoxSortBooks.SelectedIndexChanged += comboBoxSortBooks_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 64);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Sortuj:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(711, 405);
            Controls.Add(label2);
            Controls.Add(comboBoxSortBooks);
            Controls.Add(dataGridViewBooks);
            Controls.Add(panel1);
            Controls.Add(btnOpenAddBookForm);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenAddBookForm;
        private Panel panel1;
        private Label label1;
        private TextBox txtBoxFilterBooks;
        private DataGridView dataGridViewBooks;
        private ComboBox comboBoxSortBooks;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn AverageRate;
        private DataGridViewTextBoxColumn RatesCount;
        private DataGridViewButtonColumn delete;
    }
}