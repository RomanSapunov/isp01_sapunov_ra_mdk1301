namespace MDK1301_26._11._2020_Sapunov.Views
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
            this.showSpecialtyButton = new System.Windows.Forms.Button();
            this.showGroupsButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showSpecialtyButton
            // 
            this.showSpecialtyButton.Location = new System.Drawing.Point(12, 30);
            this.showSpecialtyButton.Name = "showSpecialtyButton";
            this.showSpecialtyButton.Size = new System.Drawing.Size(114, 35);
            this.showSpecialtyButton.TabIndex = 0;
            this.showSpecialtyButton.Text = "Специальность";
            this.showSpecialtyButton.UseVisualStyleBackColor = true;
            // 
            // showGroupsButton
            // 
            this.showGroupsButton.Location = new System.Drawing.Point(219, 30);
            this.showGroupsButton.Name = "showGroupsButton";
            this.showGroupsButton.Size = new System.Drawing.Size(114, 35);
            this.showGroupsButton.TabIndex = 1;
            this.showGroupsButton.Text = "Группы";
            this.showGroupsButton.UseVisualStyleBackColor = true;
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(440, 30);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(114, 35);
            this.showStudentsButton.TabIndex = 2;
            this.showStudentsButton.Text = "Студенты";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 102);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.showGroupsButton);
            this.Controls.Add(this.showSpecialtyButton);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showSpecialtyButton;
        private System.Windows.Forms.Button showGroupsButton;
        private System.Windows.Forms.Button showStudentsButton;
    }
}

