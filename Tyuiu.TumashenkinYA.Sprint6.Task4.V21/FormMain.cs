using Tyuiu.TumashenkinYA.Sprint6.Task4.V21.Lib;
namespace Tyuiu.TumashenkinYA.Sprint6.Task4.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void bettonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_RKN.Text);
                int stopStep = Convert.ToInt32(textBoxStop_RKN.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                double[] xData = new double[len];
                double[] yData = new double[len];

                textBoxResult_RKN.Text = "";

                for (int i = 0; i < len; i++)
                {
                    xData[i] = startStep + i;
                    yData[i] = valueArray[i];
                    textBoxResult_RKN.AppendText(valueArray[i] + Environment.NewLine);
                }

                formsPlotChartResult_RKN.Plot.Clear();

                var scatter = formsPlotChartResult_RKN.Plot.Add.Scatter(xData, yData);

                formsPlotChartResult_RKN.Plot.Title("Ãðàôèê ôóíêöèè");
                formsPlotChartResult_RKN.Plot.XLabel("Îñü X");
                formsPlotChartResult_RKN.Plot.YLabel("Îñü Y");

                formsPlotChartResult_RKN.Refresh();
            }

            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V21.txt";
                File.WriteAllText(path, textBoxResult_RKN.Text);

                DialogResult dialogResult = MessageBox.Show("Ôàéë" + path + "Ñîõðàíåí óñïåøíî!\nÎòêðûòü åãî â áëîêíîòå?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 âûïîëíèë ñòóäåíò ãðóïïû ПКТб-25-1 Тумашенкин Ярослав Анатольевич", "Ñïðàâêà");
        }
        private void buttonResult_RKN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_RKN.BackColor = Color.Blue;
        }

        private void buttonResult_RKN_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_RKN.BackColor = Color.Red;
        }

        private void buttonResult_RKN_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_RKN.BackColor = Color.Green;
        }
    }
}
