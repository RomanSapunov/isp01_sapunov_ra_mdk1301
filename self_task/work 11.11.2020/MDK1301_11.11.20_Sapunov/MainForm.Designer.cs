namespace MDK1301_11._11._20_Sapunov
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
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.taskLabel = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toDoListBox
            // 
            this.toDoListBox.BackColor = System.Drawing.Color.White;
            this.toDoListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.ItemHeight = 19;
            this.toDoListBox.Location = new System.Drawing.Point(12, 12);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(351, 327);
            this.toDoListBox.TabIndex = 0;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.White;
            this.addTaskButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTaskButton.Location = new System.Drawing.Point(13, 392);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(167, 42);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.Text = "Добавить задачу";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.BackColor = System.Drawing.Color.White;
            this.deleteTaskButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTaskButton.Location = new System.Drawing.Point(196, 392);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(167, 42);
            this.deleteTaskButton.TabIndex = 2;
            this.deleteTaskButton.Text = "Удалить задачу";
            this.deleteTaskButton.UseVisualStyleBackColor = false;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // taskLabel
            // 
            this.taskLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.taskLabel.Location = new System.Drawing.Point(12, 358);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(68, 23);
            this.taskLabel.TabIndex = 3;
            this.taskLabel.Text = "Задача:";
            // 
            // taskTextBox
            // 
            this.taskTextBox.BackColor = System.Drawing.Color.White;
            this.taskTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskTextBox.Location = new System.Drawing.Point(86, 355);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(277, 26);
            this.taskTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(375, 446);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.toDoListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.TextBox taskTextBox;
    }
}

