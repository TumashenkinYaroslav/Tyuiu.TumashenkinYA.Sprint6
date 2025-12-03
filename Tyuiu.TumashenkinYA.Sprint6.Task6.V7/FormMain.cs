using Tyuiu.TumashenkinYA.Sprint6.Task6.V7.Lib;
namespace Tyuiu.TumashenkinYA.Sprint6.Task6.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath = "";
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            groupBoxIn_KES.Text = "Ââîä:" + openFilePath;
            string str = "";
            using (StreamReader sr = new StreamReader(openFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null) str += line + Environment.NewLine;
                textBoxIn_KES.Text = str;
            }
            buttonDone_KES.Enabled = true;
        }

        private void buttonDone_KES_Click(object sender, EventArgs e)
        {
            textBoxResult_KES.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_KES_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
    }
}
