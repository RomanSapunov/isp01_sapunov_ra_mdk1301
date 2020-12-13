namespace Project.Views
{
    partial class MainForm
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
            this.authorButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(12, 12);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(200, 223);
            this.authorButton.TabIndex = 0;
            this.authorButton.Text = "Авторы";
            this.authorButton.UseVisualStyleBackColor = true;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(224, 12);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(200, 223);
            this.booksButton.TabIndex = 1;
            this.booksButton.Text = "Книги";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 247);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.authorButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Button booksButton;
    }
}