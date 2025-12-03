using Tyuiu.TumashenkinYA.Sprint6.Task7.V28.Lib;
namespace Tyuiu.TumashenkinYA.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_NVA.Filter = "Çíà÷åíèÿ, ðàçäåë¸ííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            saveFileDialogMatrix_NVA.Filter = "Çíà÷åíèÿ, ðàçäåëåííûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*"; ;
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_NVA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_NVA.ShowDialog();
            openFilePath = openFileDialogTask_NVA.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_NVA.ColumnCount = colums;
            dataGridViewIn_NVA.RowCount = rows;
            dataGridViewOut_NVA.ColumnCount = colums;
            dataGridViewOut_NVA.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewOut_NVA.Columns[i].Width = 25;
                dataGridViewIn_NVA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewIn_NVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonGet_NVA.Enabled = true;


        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            FormAbout_NVA formAbout = new FormAbout_NVA();
            formAbout.ShowDialog();
        }
        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOut_NVA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_NVA.Enabled = true;
        }
        private void buttonSaveFile_SIA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_NVA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_NVA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_NVA.ShowDialog();

            string path = saveFileDialogMatrix_NVA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_NVA.RowCount;
            int columns = dataGridViewOut_NVA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_NVA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_NVA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }

        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewOut_NVA.ColumnCount = 50;
            dataGridViewIn_NVA.ColumnCount = 50;

            dataGridViewOut_NVA.RowCount = 50;
            dataGridViewIn_NVA.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewOut_NVA.Columns[i].Width = 25;
                dataGridViewIn_NVA.Columns[i].Width = 25;
            }



        }
    }
}
