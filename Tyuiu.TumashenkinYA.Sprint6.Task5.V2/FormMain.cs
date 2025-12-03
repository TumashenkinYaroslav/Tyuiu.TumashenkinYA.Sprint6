using Tyuiu.TumashenkinYA.Sprint6.Task5.V2.Lib;
namespace Tyuiu.TumashenkinYA.Sprint6.Task5.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\User\Desktop\DataService6\OutPutDataFileTask5V2.txt";

        private void buttonDone_KDY_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KDY.ColumnCount = 2;
            dataGridViewResult_KDY.Columns[0].Width = 20;
            dataGridViewResult_KDY.Columns[1].Width = 50;

            this.chartDiag_KDY.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chartDiag_KDY.ChartAreas[0].AxisY.Title = "Îñü Y";

            this.chartDiag_KDY.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KDY.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                this.chartDiag_KDY.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }


        private void buttonOpenFile_KDY_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 5 âûïîëíèë ñòóäåíò ãðóïïû ÑÌÀÐÒá-24-1 Õðàïîâ Äàíèèë Þðüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
