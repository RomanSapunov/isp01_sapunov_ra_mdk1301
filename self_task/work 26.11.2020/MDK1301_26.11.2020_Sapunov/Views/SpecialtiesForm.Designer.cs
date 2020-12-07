namespace MDK1301_26._11._2020_Sapunov.Views
{
    partial class SpecialtiesForm
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
            this.specialtiesView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.showGroupsButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesView)).BeginInit();
            this.SuspendLayout();
            // 
            // specialtiesView
            // 
            this.specialtiesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialtiesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.codeColumn,
            this.nameColumn});
            this.specialtiesView.Dock = System.Windows.Forms.DockStyle.Top;
            this.specialtiesView.Location = new System.Drawing.Point(0, 0);
            this.specialtiesView.MultiSelect = false;
            this.specialtiesView.Name = "specialtiesView";
            this.specialtiesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.specialtiesView.Size = new System.Drawing.Size(775, 313);
            this.specialtiesView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // codeColumn
            // 
            this.codeColumn.DataPropertyName = "Code";
            this.codeColumn.HeaderText = "Шифр";
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 324);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 50);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(374, 324);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(175, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Location = new System.Drawing.Point(686, 329);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(77, 40);
            this.refreshDataButton.TabIndex = 3;
            this.refreshDataButton.Text = "Обновить";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // showGroupsButton
            // 
            this.showGroupsButton.Location = new System.Drawing.Point(555, 324);
            this.showGroupsButton.Name = "showGroupsButton";
            this.showGroupsButton.Size = new System.Drawing.Size(113, 50);
            this.showGroupsButton.TabIndex = 4;
            this.showGroupsButton.Text = "Группы";
            this.showGroupsButton.UseVisualStyleBackColor = true;
            this.showGroupsButton.Click += new System.EventHandler(this.showGroupsButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(193, 324);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(175, 50);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 386);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.showGroupsButton);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.specialtiesView);
            this.Name = "SpecialtiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специальности";
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView specialtiesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Button showGroupsButton;
        private System.Windows.Forms.Button changeButton;
    }
}