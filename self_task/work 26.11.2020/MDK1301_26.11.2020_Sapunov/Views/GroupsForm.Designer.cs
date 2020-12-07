namespace MDK1301_26._11._2020_Sapunov.Views
{
    partial class GroupsForm
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
            this.groupsView = new System.Windows.Forms.DataGridView();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupsView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsView
            // 
            this.groupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.yearColumn,
            this.specColumn});
            this.groupsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupsView.Location = new System.Drawing.Point(0, 0);
            this.groupsView.MultiSelect = false;
            this.groupsView.Name = "groupsView";
            this.groupsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsView.Size = new System.Drawing.Size(776, 321);
            this.groupsView.TabIndex = 0;
            this.groupsView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.groupsView_CellFormatting);
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Location = new System.Drawing.Point(687, 340);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(77, 40);
            this.refreshDataButton.TabIndex = 6;
            this.refreshDataButton.Text = "Обновить";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(374, 335);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(175, 50);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 335);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 50);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(555, 335);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(114, 50);
            this.showStudentsButton.TabIndex = 7;
            this.showStudentsButton.Text = "Студенты";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            this.showStudentsButton.Click += new System.EventHandler(this.showStudentsButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(193, 335);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(175, 50);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Название";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // yearColumn
            // 
            this.yearColumn.DataPropertyName = "Year";
            this.yearColumn.HeaderText = "Год формирования";
            this.yearColumn.Name = "yearColumn";
            this.yearColumn.ReadOnly = true;
            // 
            // specColumn
            // 
            this.specColumn.HeaderText = "Специальность";
            this.specColumn.Name = "specColumn";
            this.specColumn.ReadOnly = true;
            this.specColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.specColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 397);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.showStudentsButton);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupsView);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы";
            ((System.ComponentModel.ISupportInitialize)(this.groupsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupsView;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showStudentsButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specColumn;
    }
}