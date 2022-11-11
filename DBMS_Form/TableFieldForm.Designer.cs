namespace DBMS_Form
{
    partial class TableFieldForm
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
            this.tableFieldsLabel = new System.Windows.Forms.Label();
            this.tableFieldsListBox = new System.Windows.Forms.ListBox();
            this.addFieldPanel = new System.Windows.Forms.Panel();
            this.addFieldButton = new System.Windows.Forms.Button();
            this.fieldTypeLabel = new System.Windows.Forms.Label();
            this.fieldNameLabel = new System.Windows.Forms.Label();
            this.fieldTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fieldNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteFieldButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.addFieldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableFieldsLabel
            // 
            this.tableFieldsLabel.AutoSize = true;
            this.tableFieldsLabel.Location = new System.Drawing.Point(21, 18);
            this.tableFieldsLabel.Name = "tableFieldsLabel";
            this.tableFieldsLabel.Size = new System.Drawing.Size(87, 20);
            this.tableFieldsLabel.TabIndex = 0;
            this.tableFieldsLabel.Text = "Table fields:";
            // 
            // tableFieldsListBox
            // 
            this.tableFieldsListBox.FormattingEnabled = true;
            this.tableFieldsListBox.ItemHeight = 20;
            this.tableFieldsListBox.Location = new System.Drawing.Point(21, 41);
            this.tableFieldsListBox.Name = "tableFieldsListBox";
            this.tableFieldsListBox.Size = new System.Drawing.Size(855, 424);
            this.tableFieldsListBox.TabIndex = 1;
            this.tableFieldsListBox.SelectedIndexChanged += new System.EventHandler(this.tableFieldsListBox_SelectedIndexChanged);
            // 
            // addFieldPanel
            // 
            this.addFieldPanel.Controls.Add(this.addFieldButton);
            this.addFieldPanel.Controls.Add(this.fieldTypeLabel);
            this.addFieldPanel.Controls.Add(this.fieldNameLabel);
            this.addFieldPanel.Controls.Add(this.fieldTypeComboBox);
            this.addFieldPanel.Controls.Add(this.fieldNameTextBox);
            this.addFieldPanel.Location = new System.Drawing.Point(912, 41);
            this.addFieldPanel.Name = "addFieldPanel";
            this.addFieldPanel.Size = new System.Drawing.Size(277, 151);
            this.addFieldPanel.TabIndex = 2;
            // 
            // addFieldButton
            // 
            this.addFieldButton.BackColor = System.Drawing.Color.Pink;
            this.addFieldButton.Location = new System.Drawing.Point(45, 89);
            this.addFieldButton.Name = "addFieldButton";
            this.addFieldButton.Size = new System.Drawing.Size(192, 49);
            this.addFieldButton.TabIndex = 4;
            this.addFieldButton.Text = "Add Field";
            this.addFieldButton.UseVisualStyleBackColor = true;
            this.addFieldButton.Click += new System.EventHandler(this.addFieldButton_Click);
            // 
            // fieldTypeLabel
            // 
            this.fieldTypeLabel.AutoSize = true;
            this.fieldTypeLabel.Location = new System.Drawing.Point(25, 54);
            this.fieldTypeLabel.Name = "fieldTypeLabel";
            this.fieldTypeLabel.Size = new System.Drawing.Size(79, 20);
            this.fieldTypeLabel.TabIndex = 3;
            this.fieldTypeLabel.Text = "Field Type:";
            // 
            // fieldNameLabel
            // 
            this.fieldNameLabel.AutoSize = true;
            this.fieldNameLabel.Location = new System.Drawing.Point(16, 16);
            this.fieldNameLabel.Name = "fieldNameLabel";
            this.fieldNameLabel.Size = new System.Drawing.Size(88, 20);
            this.fieldNameLabel.TabIndex = 2;
            this.fieldNameLabel.Text = "Field Name:";
            // 
            // fieldTypeComboBox
            // 
            this.fieldTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldTypeComboBox.FormattingEnabled = true;
            this.fieldTypeComboBox.Location = new System.Drawing.Point(110, 46);
            this.fieldTypeComboBox.Name = "fieldTypeComboBox";
            this.fieldTypeComboBox.Size = new System.Drawing.Size(155, 28);
            this.fieldTypeComboBox.TabIndex = 1;
            // 
            // fieldNameTextBox
            // 
            this.fieldNameTextBox.Location = new System.Drawing.Point(110, 13);
            this.fieldNameTextBox.Name = "fieldNameTextBox";
            this.fieldNameTextBox.Size = new System.Drawing.Size(155, 27);
            this.fieldNameTextBox.TabIndex = 0;
            this.fieldNameTextBox.TextChanged += new System.EventHandler(this.fieldNameTextBox_TextChanged);
            // 
            // deleteFieldButton
            // 
            this.deleteFieldButton.BackColor = System.Drawing.Color.Pink;
            this.deleteFieldButton.Location = new System.Drawing.Point(957, 234);
            this.deleteFieldButton.Name = "deleteFieldButton";
            this.deleteFieldButton.Size = new System.Drawing.Size(192, 49);
            this.deleteFieldButton.TabIndex = 5;
            this.deleteFieldButton.Text = "Delete Field";
            this.deleteFieldButton.UseVisualStyleBackColor = true;
            this.deleteFieldButton.Click += new System.EventHandler(this.deleteFieldButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.BackColor = System.Drawing.Color.Pink;
            this.createTableButton.Location = new System.Drawing.Point(957, 289);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(192, 49);
            this.createTableButton.TabIndex = 6;
            this.createTableButton.Text = "Create Table";
            this.createTableButton.UseVisualStyleBackColor = true;
            // 
            // TableFieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 498);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.deleteFieldButton);
            this.Controls.Add(this.addFieldPanel);
            this.Controls.Add(this.tableFieldsListBox);
            this.Controls.Add(this.tableFieldsLabel);
            this.Name = "TableFieldForm";
            this.Text = "TableFieldForm";
            this.addFieldPanel.ResumeLayout(false);
            this.addFieldPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tableFieldsLabel;
        private ListBox tableFieldsListBox;
        private Panel addFieldPanel;
        private Label fieldNameLabel;
        private ComboBox fieldTypeComboBox;
        private TextBox fieldNameTextBox;
        private Button addFieldButton;
        private Label fieldTypeLabel;
        private Button deleteFieldButton;
        private Button createTableButton;
    }
}