namespace DBMS_Form
{
    partial class SearchForm
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
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchValueTextBox = new System.Windows.Forms.TextBox();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(12, 12);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 29;
            this.searchDataGridView.Size = new System.Drawing.Size(848, 450);
            this.searchDataGridView.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.dataTypeLabel);
            this.searchPanel.Controls.Add(this.valueLabel);
            this.searchPanel.Controls.Add(this.searchTypeComboBox);
            this.searchPanel.Controls.Add(this.searchValueTextBox);
            this.searchPanel.Location = new System.Drawing.Point(899, 12);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(310, 164);
            this.searchPanel.TabIndex = 1;
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Location = new System.Drawing.Point(100, 18);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(194, 27);
            this.searchValueTextBox.TabIndex = 0;
            this.searchValueTextBox.TextChanged += new System.EventHandler(this.FieldNameTextBox_TextChanged);
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(100, 51);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(194, 28);
            this.searchTypeComboBox.TabIndex = 1;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(25, 21);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 20);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Value:";
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.AutoSize = true;
            this.dataTypeLabel.Location = new System.Drawing.Point(17, 59);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(77, 20);
            this.dataTypeLabel.TabIndex = 3;
            this.dataTypeLabel.Text = "Data type:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Pink;
            this.searchButton.Location = new System.Drawing.Point(25, 103);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(258, 46);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 487);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.searchDataGridView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView searchDataGridView;
        private Panel searchPanel;
        private Label valueLabel;
        private ComboBox searchTypeComboBox;
        private TextBox searchValueTextBox;
        private Button searchButton;
        private Label dataTypeLabel;
    }
}