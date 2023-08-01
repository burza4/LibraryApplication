namespace LibraryApp
{
    partial class BookDetailsForm
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
            panel1 = new Panel();
            label1 = new Label();
            labelTitle = new Label();
            labelAuthor = new Label();
            dataGridViewReviews = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            label5 = new Label();
            labelAverageRate = new Label();
            btnAddReview = new Button();
            panel2 = new Panel();
            labelRatingsCount = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.BurlyWood;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(146, 19);
            label1.TabIndex = 4;
            label1.Text = "Szczegóły książki";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 59);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(42, 23);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthor.Location = new Point(12, 82);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(53, 18);
            labelAuthor.TabIndex = 2;
            labelAuthor.Text = "Author";
            // 
            // dataGridViewReviews
            // 
            dataGridViewReviews.AllowUserToAddRows = false;
            dataGridViewReviews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReviews.BackgroundColor = Color.Linen;
            dataGridViewReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReviews.Columns.AddRange(new DataGridViewColumn[] { Id, Description, Rate });
            dataGridViewReviews.Dock = DockStyle.Bottom;
            dataGridViewReviews.Location = new Point(0, 188);
            dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewReviews.RowHeadersVisible = false;
            dataGridViewReviews.RowTemplate.Height = 25;
            dataGridViewReviews.Size = new Size(711, 217);
            dataGridViewReviews.TabIndex = 4;
            dataGridViewReviews.SelectionChanged += dataGridViewReviews_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Description
            // 
            Description.HeaderText = "Recenzja";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Rate
            // 
            Rate.HeaderText = "Ocena";
            Rate.Name = "Rate";
            Rate.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 8);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 5;
            label5.Text = "Średnia ocena:";
            // 
            // labelAverageRate
            // 
            labelAverageRate.AutoSize = true;
            labelAverageRate.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAverageRate.Location = new Point(93, 2);
            labelAverageRate.Name = "labelAverageRate";
            labelAverageRate.Size = new Size(72, 25);
            labelAverageRate.TabIndex = 6;
            labelAverageRate.Text = "AvRate";
            // 
            // btnAddReview
            // 
            btnAddReview.Location = new Point(595, 59);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(104, 32);
            btnAddReview.TabIndex = 8;
            btnAddReview.Text = "Dodaj recenzję";
            btnAddReview.UseVisualStyleBackColor = true;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(labelRatingsCount);
            panel2.Controls.Add(labelAverageRate);
            panel2.Location = new Point(12, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 36);
            panel2.TabIndex = 10;
            // 
            // labelRatingsCount
            // 
            labelRatingsCount.AutoSize = true;
            labelRatingsCount.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelRatingsCount.ForeColor = SystemColors.GrayText;
            labelRatingsCount.Location = new Point(165, 9);
            labelRatingsCount.Name = "labelRatingsCount";
            labelRatingsCount.Size = new Size(57, 16);
            labelRatingsCount.TabIndex = 9;
            labelRatingsCount.Text = "RateCount";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(595, 142);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 12;
            button1.Text = "Wróć";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(711, 405);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(btnAddReview);
            Controls.Add(dataGridViewReviews);
            Controls.Add(labelAuthor);
            Controls.Add(labelTitle);
            Controls.Add(panel1);
            Name = "BookDetailsForm";
            Text = "BookDetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelTitle;
        private Label labelAuthor;
        private DataGridView dataGridViewReviews;
        private Label label5;
        private Label labelAverageRate;
        private Button btnAddReview;
        private Panel panel2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Rate;
        private Button button1;
        private Label labelRatingsCount;
    }
}