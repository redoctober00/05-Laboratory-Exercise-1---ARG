namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmLab1 : Form
    {
        FrmFileName _FileName;
        public FrmLab1()
        {
            InitializeComponent();
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            _FileName.ShowDialog();
            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName))) { 
                outputFile.WriteLine(getInput); 
                Console.WriteLine(getInput); }
        }
    }
}
