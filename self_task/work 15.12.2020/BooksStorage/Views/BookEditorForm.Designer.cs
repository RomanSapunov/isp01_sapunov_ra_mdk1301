namespace BooksStorage.Views
{
    partial class BookEditorForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.countOfPagesUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.countOfPagesLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countOfPagesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(60, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Название:";
            // 
            // countOfPagesUpDown
            // 
            this.countOfPagesUpDown.Location = new System.Drawing.Point(106, 50);
            this.countOfPagesUpDown.Name = "countOfPagesUpDown";
            this.countOfPagesUpDown.Size = new System.Drawing.Size(240, 20);
            this.countOfPagesUpDown.TabIndex = 1;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(106, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(240, 20);
            this.titleBox.TabIndex = 2;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 126);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(272, 126);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(74, 23);
            this.rejectButton.TabIndex = 4;
            this.rejectButton.Text = "Отменить";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // countOfPagesLabel
            // 
            this.countOfPagesLabel.AutoSize = true;
            this.countOfPagesLabel.Location = new System.Drawing.Point(12, 52);
            this.countOfPagesLabel.Name = "countOfPagesLabel";
            this.countOfPagesLabel.Size = new System.Drawing.Size(88, 13);
            this.countOfPagesLabel.TabIndex = 5;
            this.countOfPagesLabel.Text = "Кол-во страниц:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 88);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(40, 13);
            this.authorLabel.TabIndex = 6;
            this.authorLabel.Text = "Автор:";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(106, 85);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(240, 20);
            this.authorBox.TabIndex = 7;
            // 
            // BookEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 158);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.countOfPagesLabel);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.countOfPagesUpDown);
            this.Controls.Add(this.titleLabel);
            this.Name = "BookEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор книги";
            ((System.ComponentModel.ISupportInitialize)(this.countOfPagesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.NumericUpDown countOfPagesUpDown;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Label countOfPagesLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorBox;
    }
}