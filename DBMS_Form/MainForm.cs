namespace DBMS_Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadDBFromFileButton_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            // Set default path
            string combinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(),
                                                         "../../databases");
            FD.InitialDirectory = System.IO.Path.GetFullPath(combinedPath); ;
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                DataBaseForm dbForm = new DataBaseForm(null, fileToOpen);
                this.Visible = false;
                dbForm.ShowDialog();
                this.Close();
            }
        }

        private void createDBButton_Click(object sender, EventArgs e)
        {
            string newDBName = Microsoft.VisualBasic.Interaction.InputBox("How do you want to call the new database?",
                                                                          "Name your database", "Nice-DB");
            if (!String.IsNullOrWhiteSpace(newDBName))
            {
                DataBaseForm dbForm = new DataBaseForm(newDBName, null);
                this.Visible = false;
                dbForm.ShowDialog();
                this.Close();
            }
        }

    }
}