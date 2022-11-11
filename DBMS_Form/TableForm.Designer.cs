namespace DBMS_Form
{
    partial class TableForm
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
            this.rowsDataGridView = new System.Windows.Forms.DataGridView();
            this.editRowButton = new System.Windows.Forms.Button();
            this.deleteRowButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rowsDataGridView
            // 
            this.rowsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.rowsDataGridView.Name = "rowsDataGridView";
            this.rowsDataGridView.RowHeadersWidth = 51;
            this.rowsDataGridView.RowTemplate.Height = 29;
            this.rowsDataGridView.Size = new System.Drawing.Size(944, 516);
            this.rowsDataGridView.TabIndex = 0;
            this.rowsDataGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.rowsDataGridView_ColumnAdded);
            this.rowsDataGridView.SelectionChanged += new System.EventHandler(this.rowsDataGridView_SelectionChanged);
            // 
            // editRowButton
            // 
            this.editRowButton.BackColor = System.Drawing.Color.Pink;
            this.editRowButton.Location = new System.Drawing.Point(977, 12);
            this.editRowButton.Name = "editRowButton";
            this.editRowButton.Size = new System.Drawing.Size(209, 54);
            this.editRowButton.TabIndex = 2;
            this.editRowButton.Text = "Edit Row...";
            this.editRowButton.UseVisualStyleBackColor = true;
            this.editRowButton.Click += new System.EventHandler(this.editRowButton_Click);
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.BackColor = System.Drawing.Color.Pink;
            this.deleteRowButton.Location = new System.Drawing.Point(977, 72);
            this.deleteRowButton.Name = "deleteRowButton";
            this.deleteRowButton.Size = new System.Drawing.Size(209, 54);
            this.deleteRowButton.TabIndex = 3;
            this.deleteRowButton.Text = "Delete Row";
            this.deleteRowButton.UseVisualStyleBackColor = true;
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.BackColor = System.Drawing.Color.Pink;
            this.addRowButton.Location = new System.Drawing.Point(977, 132);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(209, 54);
            this.addRowButton.TabIndex = 4;
            this.addRowButton.Text = "Add Row...";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Pink;
            this.searchButton.Location = new System.Drawing.Point(977, 474);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(209, 54);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 551);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.deleteRowButton);
            this.Controls.Add(this.editRowButton);
            this.Controls.Add(this.rowsDataGridView);
            this.Name = "TableForm";
            this.Text = "TableForm";
            ((System.ComponentModel.ISupportInitialize)(this.rowsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView rowsDataGridView;
        private Button editRowButton;
        private Button deleteRowButton;
        private Button addRowButton;
        private Button searchButton;
    }
}