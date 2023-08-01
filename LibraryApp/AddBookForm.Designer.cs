namespace LibraryApp
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
            txtBoxBookTitle = new TextBox();
            txtBoxBookAuthor = new TextBox();
            btnAddBook = new Button();
            btnBackFromAddBook = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(17, 65);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Tytuł:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(17, 97);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // txtBoxBookTitle
            // 
            txtBoxBookTitle.Anchor = AnchorStyles.Top;
            txtBoxBookTitle.BackColor = SystemColors.ControlLightLight;
            txtBoxBookTitle.Location = new Point(61, 62);
            txtBoxBookTitle.Name = "txtBoxBookTitle";
            txtBoxBookTitle.Size = new Size(176, 23);
            txtBoxBookTitle.TabIndex = 2;
            // 
            // txtBoxBookAuthor
            // 
            txtBoxBookAuthor.Anchor = AnchorStyles.Top;
            txtBoxBookAuthor.Location = new Point(61, 91);
            txtBoxBookAuthor.Name = "txtBoxBookAuthor";
            txtBoxBookAuthor.Size = new Size(176, 23);
            txtBoxBookAuthor.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Bottom;
            btnAddBook.Location = new Point(159, 151);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 24);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Dodaj";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnBackFromAddBook
            // 
            btnBackFromAddBook.Anchor = AnchorStyles.Bottom;
            btnBackFromAddBook.Location = new Point(43, 151);
            btnBackFromAddBook.Name = "btnBackFromAddBook";
            btnBackFromAddBook.Size = new Size(75, 24);
            btnBackFromAddBook.TabIndex = 5;
            btnBackFromAddBook.Text = "Wróć";
            btnBackFromAddBook.UseVisualStyleBackColor = true;
            btnBackFromAddBook.Click += btnBackFromAddBook_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 45);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.BurlyWood;
            label3.Location = new Point(70, 12);
            label3.Name = "label3";
            label3.Size = new Size(152, 19);
            label3.TabIndex = 0;
            label3.Text = "Dodawanie książki";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(281, 187);
            Controls.Add(panel1);
            Controls.Add(btnBackFromAddBook);
            Controls.Add(btnAddBook);
            Controls.Add(txtBoxBookAuthor);
            Controls.Add(txtBoxBookTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "AddBookForm";
            Text = "AddBookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxBookTitle;
        private TextBox txtBoxBookAuthor;
        private Button btnAddBook;
        private Button btnBackFromAddBook;
        private Panel panel1;
        private Label label3;
    }
}