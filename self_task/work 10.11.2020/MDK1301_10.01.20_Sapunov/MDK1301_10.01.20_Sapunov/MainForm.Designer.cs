namespace MDK1301_10._01._20_Sapunov
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.coolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coolButton
            // 
            this.coolButton.Location = new System.Drawing.Point(153, 107);
            this.coolButton.Name = "coolButton";
            this.coolButton.Size = new System.Drawing.Size(114, 40);
            this.coolButton.TabIndex = 0;
            this.coolButton.Text = "Нажми на меня!";
            this.coolButton.UseVisualStyleBackColor = true;
            this.coolButton.Click += new System.EventHandler(this.coolButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 248);
            this.Controls.Add(this.coolButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button coolButton;
    }
}

