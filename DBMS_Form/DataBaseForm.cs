using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Form
{
    public partial class DataBaseForm : Form
    {
        DataBase db;

        public DataBaseForm()
        {
            InitForm();
        }
        public DataBaseForm(string dbName, string dbPath)
        {
            InitForm();
            if (!String.IsNullOrEmpty(dbPath))
            { // Load DB from file
                db = new DataBase();
                db.LoadFromJSON(dbPath);
            }
            else // Create new db
                db = new DataBase(dbName);
            RefreshDBTablesListBox();
        }

        private void InitForm()
        {
            InitializeComponent();
            viewTableButton.Enabled = false;
            deleteTableButton.Enabled = false;
            saveDBButton.Enabled = false;
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            this.Text = db.GetName();
        }

        private void viewTableButton_Click(object sender, EventArgs e)
        {
            ViewSelectedTable();
        }

        private void dbTablesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dbTablesListBox.SelectedIndex != -1)
                ViewSelectedTable();
        }

        private void ViewSelectedTable()
        {
            DBTable selectedTable = db.GetTable(dbTablesListBox.SelectedIndex);
            TableForm tableForm = new TableForm(selectedTable);
            tableForm.ShowDialog();
        }

        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            db.DeleteTable(dbTablesListBox.SelectedIndex);
            RefreshDBTablesListBox();
            deleteTableButton.Enabled = false;
        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            string newTableName = Microsoft.VisualBasic.Interaction.InputBox("Enter name for a new table:",
                                                                             "New table", "Nice-Table");
            if (!String.IsNullOrWhiteSpace(newTableName))
            {
                DBTable newTable = new DBTable(newTableName);
                TableFieldForm dbForm = new TableFieldForm(newTableName, newTable);
                dbForm.ShowDialog();
                if (dbForm.DialogResult == DialogResult.OK)
                {
                    db.AddTable(newTable);
                    RefreshDBTablesListBox();
                }
            }
        }

        private void saveDBButton_Click(object sender, EventArgs e)
        {
            string fileName = db.GetSaveFilename();
            if (!String.IsNullOrEmpty(fileName)) // Save DB to the last known file
            {
                db.SaveToJSON(fileName);
                MessageBox.Show("Database saved successfully!");
            }
            else
            { // Save DB to a new file
                fileName = Microsoft.VisualBasic.Interaction.InputBox("Enter name to save your database:",
                                                                      "Save database",
                                                                      db.GetName() + ".txt");
                if (!String.IsNullOrWhiteSpace(fileName))
                    db.SaveToJSON("../../../databases/" + fileName);
            }
        }

        private void RefreshDBTablesListBox()
        {
            dbTablesListBox.Items.Clear();
            List<string> tableDescList = db.GetTableDescList();
            foreach (string tableDesc in tableDescList)
            {
                dbTablesListBox.Items.Add(tableDesc);
            }
            // Only enable "Save Database" button if there is at least one table
            saveDBButton.Enabled = (tableDescList.Count > 0);
        }

        private void dbTablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Activate "Delete table" and "View table" buttons only if a table is selected
            deleteTableButton.Enabled = (dbTablesListBox.SelectedIndex != -1);
            viewTableButton.Enabled = (dbTablesListBox.SelectedIndex != -1);
        }

    }
}
