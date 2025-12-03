using Tyuiu.TumashenkinYA.Sprint6.Task0.V15.Lib;

namespace Tyuiu.TumashenkinYA.Sprint6.Task0.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KKA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputResult_KKA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputVarX_KKA.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-25-1 Тумашенкин Ярослав Анатольевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxInputVarX_KKA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxTask_KKA_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_KKA_Enter(object sender, EventArgs e)
        {

        }
    }
}
