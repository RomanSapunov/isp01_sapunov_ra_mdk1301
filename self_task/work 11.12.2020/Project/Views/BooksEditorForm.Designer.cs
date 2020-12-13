namespace Project.Views
{
    partial class BooksEditorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countOfPagesUpDown = new System.Windows.Forms.NumericUpDown();
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countOfPagesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(106, 6);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(193, 20);
            this.titleBox.TabIndex = 2;
            // 
            // authorBox
            // 
            this.authorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorBox.FormattingEnabled = true;
            this.authorBox.Location = new System.Drawing.Point(106, 83);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(194, 21);
            this.authorBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во страниц:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автор:";
            // 
            // countOfPagesUpDown
            // 
            this.countOfPagesUpDown.Location = new System.Drawing.Point(106, 47);
            this.countOfPagesUpDown.Name = "countOfPagesUpDown";
            this.countOfPagesUpDown.Size = new System.Drawing.Size(193, 20);
            this.countOfPagesUpDown.TabIndex = 6;
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(201, 110);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(99, 33);
            this.rejectButton.TabIndex = 8;
            this.rejectButton.Text = "Отменить";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 110);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 33);
            this.acceptButton.TabIndex = 7;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // BooksEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 155);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.countOfPagesUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Name = "BooksEditorForm";
            this.Text = "Редактор книги";
            ((System.ComponentModel.ISupportInitialize)(this.countOfPagesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.ComboBox authorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countOfPagesUpDown;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
    }
}