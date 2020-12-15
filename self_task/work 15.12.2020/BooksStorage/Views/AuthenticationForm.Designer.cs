namespace BooksStorage.Views
{
    partial class AuthenticationForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(13, 15);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(67, 53);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(172, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(12, 91);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(13, 56);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(67, 12);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(172, 20);
            this.loginBox.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(160, 91);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(79, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Выйти";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 126);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginLabel);
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аутентификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Button closeButton;
    }
}