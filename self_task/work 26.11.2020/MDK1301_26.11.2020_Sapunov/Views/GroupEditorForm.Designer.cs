namespace MDK1301_26._11._2020_Sapunov.Views
{
    partial class GroupEditorForm
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
            this.rejectButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.specBox = new System.Windows.Forms.ComboBox();
            this.specLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(154, 131);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(103, 33);
            this.rejectButton.TabIndex = 7;
            this.rejectButton.Text = "Отменить";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 131);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 33);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Название:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 51);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(107, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Год формирования:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(125, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 20);
            this.nameBox.TabIndex = 10;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(125, 48);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(132, 20);
            this.yearBox.TabIndex = 11;
            // 
            // specBox
            // 
            this.specBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specBox.FormattingEnabled = true;
            this.specBox.Location = new System.Drawing.Point(125, 86);
            this.specBox.Name = "specBox";
            this.specBox.Size = new System.Drawing.Size(132, 21);
            this.specBox.TabIndex = 12;
            // 
            // specLabel
            // 
            this.specLabel.AutoSize = true;
            this.specLabel.Location = new System.Drawing.Point(12, 89);
            this.specLabel.Name = "specLabel";
            this.specLabel.Size = new System.Drawing.Size(88, 13);
            this.specLabel.TabIndex = 13;
            this.specLabel.Text = "Специальность:";
            // 
            // GroupEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 176);
            this.Controls.Add(this.specLabel);
            this.Controls.Add(this.specBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "GroupEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ComboBox specBox;
        private System.Windows.Forms.Label specLabel;
    }
}