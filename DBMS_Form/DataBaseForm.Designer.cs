namespace DBMS_Form
{
    partial class DataBaseForm
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
            this.dbTablesListBox = new System.Windows.Forms.ListBox();
            this.viewTableButton = new System.Windows.Forms.Button();
            this.deleteTableButton = new System.Windows.Forms.Button();
            this.addTableButton = new System.Windows.Forms.Button();
            this.saveDBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbTablesListBox
            // 
            this.dbTablesListBox.FormattingEnabled = true;
            this.dbTablesListBox.ItemHeight = 20;
            this.dbTablesListBox.Location = new System.Drawing.Point(12, 12);
            this.dbTablesListBox.Name = "dbTablesListBox";
            this.dbTablesListBox.Size = new System.Drawing.Size(937, 524);
            this.dbTablesListBox.TabIndex = 0;
            this.dbTablesListBox.SelectedIndexChanged += new System.EventHandler(this.dbTablesListBox_SelectedIndexChanged);
            this.dbTablesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbTablesListBox_MouseDoubleClick);
            // 
            // viewTableButton
            // 
            this.viewTableButton.BackColor = System.Drawing.Color.Pink;
            this.viewTableButton.Location = new System.Drawing.Point(969, 12);
            this.viewTableButton.Name = "viewTableButton";
            this.viewTableButton.Size = new System.Drawing.Size(209, 54);
            this.viewTableButton.TabIndex = 1;
            this.viewTableButton.Text = "View Table...";
            this.viewTableButton.UseVisualStyleBackColor = true;
            this.viewTableButton.Click += new System.EventHandler(this.viewTableButton_Click);
            // 
            // deleteTableButton
            // 
            this.deleteTableButton.BackColor = System.Drawing.Color.Pink;
            this.deleteTableButton.Location = new System.Drawing.Point(969, 72);
            this.deleteTableButton.Name = "deleteTableButton";
            this.deleteTableButton.Size = new System.Drawing.Size(209, 54);
            this.deleteTableButton.TabIndex = 2;
            this.deleteTableButton.Text = "Delete Table...";
            this.deleteTableButton.UseVisualStyleBackColor = true;
            this.deleteTableButton.Click += new System.EventHandler(this.deleteTableButton_Click);
            // 
            // addTableButton
            // 
            this.addTableButton.BackColor = System.Drawing.Color.Pink;
            this.addTableButton.Location = new System.Drawing.Point(969, 132);
            this.addTableButton.Name = "addTableButton";
            this.addTableButton.Size = new System.Drawing.Size(209, 54);
            this.addTableButton.TabIndex = 3;
            this.addTableButton.Text = "Add Table...";
            this.addTableButton.UseVisualStyleBackColor = true;
            this.addTableButton.Click += new System.EventHandler(this.addTableButton_Click);
            // 
            // saveDBButton
            // 
            this.saveDBButton.BackColor = System.Drawing.Color.Pink;
            this.saveDBButton.Location = new System.Drawing.Point(969, 482);
            this.saveDBButton.Name = "saveDBButton";
            this.saveDBButton.Size = new System.Drawing.Size(209, 54);
            this.saveDBButton.TabIndex = 4;
            this.saveDBButton.Text = "Save Database";
            this.saveDBButton.UseVisualStyleBackColor = true;
            this.saveDBButton.Click += new System.EventHandler(this.saveDBButton_Click);
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 563);
            this.Controls.Add(this.saveDBButton);
            this.Controls.Add(this.addTableButton);
            this.Controls.Add(this.deleteTableButton);
            this.Controls.Add(this.viewTableButton);
            this.Controls.Add(this.dbTablesListBox);
            this.Name = "DataBaseForm";
            this.Text = "DataBaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox dbTablesListBox;
        private Button viewTableButton;
        private Button deleteTableButton;
        private Button addTableButton;
        private Button saveDBButton;
    }
}