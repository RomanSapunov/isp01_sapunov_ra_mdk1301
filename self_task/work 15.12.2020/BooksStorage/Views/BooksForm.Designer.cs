namespace BooksStorage.Views
{
    partial class BooksForm
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
            this.booksView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfPagesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).BeginInit();
            this.SuspendLayout();
            // 
            // booksView
            // 
            this.booksView.AllowUserToAddRows = false;
            this.booksView.AllowUserToDeleteRows = false;
            this.booksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.titleColumn,
            this.countOfPagesColumn,
            this.authorColumn});
            this.booksView.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksView.Location = new System.Drawing.Point(0, 0);
            this.booksView.MultiSelect = false;
            this.booksView.Name = "booksView";
            this.booksView.ReadOnly = true;
            this.booksView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksView.Size = new System.Drawing.Size(818, 380);
            this.booksView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Ид";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // titleColumn
            // 
            this.titleColumn.DataPropertyName = "Title";
            this.titleColumn.HeaderText = "Название";
            this.titleColumn.Name = "titleColumn";
            this.titleColumn.ReadOnly = true;
            // 
            // countOfPagesColumn
            // 
            this.countOfPagesColumn.DataPropertyName = "CountOfPages";
            this.countOfPagesColumn.HeaderText = "Кол-во страниц";
            this.countOfPagesColumn.Name = "countOfPagesColumn";
            this.countOfPagesColumn.ReadOnly = true;
            // 
            // authorColumn
            // 
            this.authorColumn.DataPropertyName = "Author";
            this.authorColumn.HeaderText = "Автор";
            this.authorColumn.Name = "authorColumn";
            this.authorColumn.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 386);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(233, 52);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(729, 386);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 52);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(251, 386);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(233, 52);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(490, 386);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(233, 52);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.booksView);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            ((System.ComponentModel.ISupportInitialize)(this.booksView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfPagesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorColumn;
    }
}