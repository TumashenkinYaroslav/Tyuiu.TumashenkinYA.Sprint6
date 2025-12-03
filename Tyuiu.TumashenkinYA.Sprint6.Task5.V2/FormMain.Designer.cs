namespace Tyuiu.TumashenkinYA.Sprint6.Task5.V2
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonDone_KDY = new Button();
            buttonOpenFile_KDY = new Button();
            buttonHelp_KDY = new Button();
            groupBoxTask_KDY = new GroupBox();
            textBoxTask_KDY = new TextBox();
            panel2 = new Panel();
            groupBoxResult_KDY = new GroupBox();
            dataGridViewResult_KDY = new DataGridView();
            splitter1 = new Splitter();
            panel3 = new Panel();
            chartDiag_KDY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBoxTask_KDY.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxResult_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KDY).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KDY).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDone_KDY);
            panel1.Controls.Add(buttonOpenFile_KDY);
            panel1.Controls.Add(buttonHelp_KDY);
            panel1.Controls.Add(groupBoxTask_KDY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2063, 200);
            panel1.TabIndex = 0;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.BackColor = Color.Green;
            buttonDone_KDY.Location = new Point(679, 35);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(150, 131);
            buttonDone_KDY.TabIndex = 2;
            buttonDone_KDY.Text = "Выполнить";
            buttonDone_KDY.UseVisualStyleBackColor = false;
            buttonDone_KDY.Click += buttonDone_KDY_Click;
            // 
            // buttonOpenFile_KDY
            // 
            buttonOpenFile_KDY.BackColor = SystemColors.HotTrack;
            buttonOpenFile_KDY.Location = new Point(846, 36);
            buttonOpenFile_KDY.Name = "buttonOpenFile_KDY";
            buttonOpenFile_KDY.Size = new Size(150, 131);
            buttonOpenFile_KDY.TabIndex = 1;
            buttonOpenFile_KDY.Text = "Открыть файл";
            buttonOpenFile_KDY.UseVisualStyleBackColor = false;
            buttonOpenFile_KDY.Click += buttonOpenFile_KDY_Click;
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDY.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KDY.Location = new Point(1901, 36);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(150, 131);
            buttonHelp_KDY.TabIndex = 0;
            buttonHelp_KDY.Text = "Справка";
            buttonHelp_KDY.UseVisualStyleBackColor = false;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(textBoxTask_KDY);
            groupBoxTask_KDY.Location = new Point(12, 3);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Padding = new Padding(5);
            groupBoxTask_KDY.Size = new Size(641, 191);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие:";
            // 
            // textBoxTask_KDY
            // 
            textBoxTask_KDY.Location = new Point(0, 40);
            textBoxTask_KDY.Multiline = true;
            textBoxTask_KDY.Name = "textBoxTask_KDY";
            textBoxTask_KDY.ReadOnly = true;
            textBoxTask_KDY.Size = new Size(616, 147);
            textBoxTask_KDY.TabIndex = 0;
            textBoxTask_KDY.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в DataGridView. Вывести все отрицательные числа. Построить диаграмму по этим значениям. ";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxResult_KDY);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 709);
            panel2.TabIndex = 1;
            // 
            // groupBoxResult_KDY
            // 
            groupBoxResult_KDY.Controls.Add(dataGridViewResult_KDY);
            groupBoxResult_KDY.Dock = DockStyle.Fill;
            groupBoxResult_KDY.Location = new Point(0, 0);
            groupBoxResult_KDY.Name = "groupBoxResult_KDY";
            groupBoxResult_KDY.Padding = new Padding(5);
            groupBoxResult_KDY.Size = new Size(400, 709);
            groupBoxResult_KDY.TabIndex = 0;
            groupBoxResult_KDY.TabStop = false;
            groupBoxResult_KDY.Text = "Вывод данных:";
            // 
            // dataGridViewResult_KDY
            // 
            dataGridViewResult_KDY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KDY.ColumnHeadersVisible = false;
            dataGridViewResult_KDY.Dock = DockStyle.Fill;
            dataGridViewResult_KDY.Location = new Point(5, 37);
            dataGridViewResult_KDY.Name = "dataGridViewResult_KDY";
            dataGridViewResult_KDY.RowHeadersVisible = false;
            dataGridViewResult_KDY.RowHeadersWidth = 82;
            dataGridViewResult_KDY.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_KDY.Size = new Size(390, 667);
            dataGridViewResult_KDY.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(400, 200);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(6, 709);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartDiag_KDY);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(406, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(1657, 709);
            panel3.TabIndex = 0;
            // 
            // chartDiag_KDY
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_KDY.ChartAreas.Add(chartArea1);
            chartDiag_KDY.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag_KDY.Legends.Add(legend1);
            chartDiag_KDY.Location = new Point(0, 0);
            chartDiag_KDY.Name = "chartDiag_KDY";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_KDY.Series.Add(series1);
            chartDiag_KDY.Size = new Size(1657, 709);
            chartDiag_KDY.TabIndex = 3;
            chartDiag_KDY.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2063, 909);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск5 | Вариант 2 | Храпов Д.Ю.";
            panel1.ResumeLayout(false);
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxResult_KDY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KDY).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Button buttonDone_KDY;
        private Button buttonOpenFile_KDY;
        private Button buttonHelp_KDY;
        private GroupBox groupBoxTask_KDY;
        private TextBox textBoxTask_KDY;
        private GroupBox groupBoxResult_KDY;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KDY;
        private DataGridView dataGridViewResult_KDY;
    }
}
