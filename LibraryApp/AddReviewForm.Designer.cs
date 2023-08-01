namespace LibraryApp
{
    partial class AddReviewForm
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
            label3 = new Label();
            txtBoxDescription = new TextBox();
            comboBoxRate = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnBackFromAddReview = new Button();
            btnAddReview = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 45);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.BurlyWood;
            label3.Location = new Point(84, 12);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 1;
            label3.Text = "Dodawanie recenzji";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(97, 86);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(200, 78);
            txtBoxDescription.TabIndex = 1;
            // 
            // comboBoxRate
            // 
            comboBoxRate.BackColor = SystemColors.ControlLightLight;
            comboBoxRate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRate.FormattingEnabled = true;
            comboBoxRate.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxRate.Location = new Point(97, 185);
            comboBoxRate.Name = "comboBoxRate";
            comboBoxRate.Size = new Size(46, 23);
            comboBoxRate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Treść recenzji:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Ocena:";
            // 
            // btnBackFromAddReview
            // 
            btnBackFromAddReview.Location = new Point(68, 241);
            btnBackFromAddReview.Name = "btnBackFromAddReview";
            btnBackFromAddReview.Size = new Size(75, 23);
            btnBackFromAddReview.TabIndex = 5;
            btnBackFromAddReview.Text = "Wróć";
            btnBackFromAddReview.UseVisualStyleBackColor = true;
            btnBackFromAddReview.Click += btnBackFromAddReview_Click;
            // 
            // btnAddReview
            // 
            btnAddReview.Location = new Point(201, 241);
            btnAddReview.Name = "btnAddReview";
            btnAddReview.Size = new Size(75, 23);
            btnAddReview.TabIndex = 6;
            btnAddReview.Text = "Dodaj";
            btnAddReview.UseVisualStyleBackColor = true;
            btnAddReview.Click += btnAddReview_Click;
            // 
            // AddReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(323, 283);
            Controls.Add(btnAddReview);
            Controls.Add(btnBackFromAddReview);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRate);
            Controls.Add(txtBoxDescription);
            Controls.Add(panel1);
            Name = "AddReviewForm";
            Text = "AddReviewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox txtBoxDescription;
        private ComboBox comboBoxRate;
        private Label label1;
        private Label label2;
        private Button btnBackFromAddReview;
        private Button btnAddReview;
    }
}