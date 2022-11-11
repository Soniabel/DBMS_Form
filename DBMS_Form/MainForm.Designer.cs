namespace DBMS_Form
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createDBButton = new System.Windows.Forms.Button();
            this.loadDBFromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDBButton
            // 
            this.createDBButton.BackColor = System.Drawing.Color.Pink;
            this.createDBButton.Location = new System.Drawing.Point(227, 72);
            this.createDBButton.Name = "createDBButton";
            this.createDBButton.Size = new System.Drawing.Size(341, 93);
            this.createDBButton.TabIndex = 0;
            this.createDBButton.Text = "Create Database...";
            this.createDBButton.UseVisualStyleBackColor = true;
            this.createDBButton.Click += new System.EventHandler(this.createDBButton_Click);
            // 
            // loadDBFromFileButton
            // 
            this.loadDBFromFileButton.BackColor = System.Drawing.Color.Pink;
            this.loadDBFromFileButton.Location = new System.Drawing.Point(227, 212);
            this.loadDBFromFileButton.Name = "loadDBFromFileButton";
            this.loadDBFromFileButton.Size = new System.Drawing.Size(341, 93);
            this.loadDBFromFileButton.TabIndex = 1;
            this.loadDBFromFileButton.Text = "Load DB from file...";
            this.loadDBFromFileButton.UseVisualStyleBackColor = true;
            this.loadDBFromFileButton.Click += new System.EventHandler(this.loadDBFromFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadDBFromFileButton);
            this.Controls.Add(this.createDBButton);
            this.Name = "MainForm";
            this.Text = "Open Database";
            this.ResumeLayout(false);

        }

        #endregion

        private Button createDBButton;
        private Button loadDBFromFileButton;
    }
}