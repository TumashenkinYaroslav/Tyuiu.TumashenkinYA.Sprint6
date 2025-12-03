namespace Tyuiu.TumashenkinYA.Sprint6.Task7.V28
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp_NVA = new Button();
            buttonGet_NVA = new Button();
            buttonOpenFile_NVA = new Button();
            groupBoxIn_NVA = new GroupBox();
            dataGridViewIn_NVA = new DataGridView();
            groupBoxOut_NVA = new GroupBox();
            dataGridViewOut_NVA = new DataGridView();
            groupBoxTask_NVA = new GroupBox();
            textBoxUslovie_NVA = new TextBox();
            buttonSaveFile_NVA = new Button();
            openFileDialogTask_NVA = new OpenFileDialog();
            toolTip_NVA = new ToolTip(components);
            saveFileDialogMatrix_NVA = new SaveFileDialog();
            groupBoxIn_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NVA).BeginInit();
            groupBoxOut_NVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NVA).BeginInit();
            groupBoxTask_NVA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_NVA
            // 
            buttonHelp_NVA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_NVA.Location = new Point(900, 41);
            buttonHelp_NVA.Name = "buttonHelp_NVA";
            buttonHelp_NVA.Size = new Size(95, 83);
            buttonHelp_NVA.TabIndex = 21;
            buttonHelp_NVA.Text = "Инфо";
            buttonHelp_NVA.UseVisualStyleBackColor = false;
            buttonHelp_NVA.Click += buttonHelp_NVA_Click;
            // 
            // buttonGet_NVA
            // 
            buttonGet_NVA.BackColor = Color.RosyBrown;
            buttonGet_NVA.Enabled = false;
            buttonGet_NVA.FlatStyle = FlatStyle.Flat;
            buttonGet_NVA.Location = new Point(153, 41);
            buttonGet_NVA.Name = "buttonGet_NVA";
            buttonGet_NVA.Size = new Size(93, 79);
            buttonGet_NVA.TabIndex = 22;
            buttonGet_NVA.Text = "Выполнить";
            buttonGet_NVA.UseVisualStyleBackColor = false;
            buttonGet_NVA.Click += buttonDone_NVA_Click;
            // 
            // buttonOpenFile_NVA
            // 
            buttonOpenFile_NVA.BackColor = SystemColors.HotTrack;
            buttonOpenFile_NVA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_NVA.Location = new Point(25, 37);
            buttonOpenFile_NVA.Name = "buttonOpenFile_NVA";
            buttonOpenFile_NVA.Size = new Size(101, 87);
            buttonOpenFile_NVA.TabIndex = 23;
            buttonOpenFile_NVA.Text = "Открыть файл";
            toolTip_NVA.SetToolTip(buttonOpenFile_NVA, "открыть файл\r\nвыберите нужный файл для обработки\r\n");
            buttonOpenFile_NVA.UseVisualStyleBackColor = false;
            buttonOpenFile_NVA.Click += buttonOpenFile_NVA_Click;
            // 
            // groupBoxIn_NVA
            // 
            groupBoxIn_NVA.Controls.Add(dataGridViewIn_NVA);
            groupBoxIn_NVA.Location = new Point(12, 256);
            groupBoxIn_NVA.Name = "groupBoxIn_NVA";
            groupBoxIn_NVA.Size = new Size(475, 350);
            groupBoxIn_NVA.TabIndex = 24;
            groupBoxIn_NVA.TabStop = false;
            groupBoxIn_NVA.Text = "Ввод :";
            // 
            // dataGridViewIn_NVA
            // 
            dataGridViewIn_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_NVA.Location = new Point(13, 22);
            dataGridViewIn_NVA.Name = "dataGridViewIn_NVA";
            dataGridViewIn_NVA.Size = new Size(443, 310);
            dataGridViewIn_NVA.TabIndex = 0;
            // 
            // groupBoxOut_NVA
            // 
            groupBoxOut_NVA.Controls.Add(dataGridViewOut_NVA);
            groupBoxOut_NVA.Location = new Point(493, 256);
            groupBoxOut_NVA.Name = "groupBoxOut_NVA";
            groupBoxOut_NVA.Size = new Size(514, 350);
            groupBoxOut_NVA.TabIndex = 25;
            groupBoxOut_NVA.TabStop = false;
            groupBoxOut_NVA.Text = "Вывод :";
            // 
            // dataGridViewOut_NVA
            // 
            dataGridViewOut_NVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_NVA.Location = new Point(23, 20);
            dataGridViewOut_NVA.Name = "dataGridViewOut_NVA";
            dataGridViewOut_NVA.Size = new Size(443, 310);
            dataGridViewOut_NVA.TabIndex = 1;
            // 
            // groupBoxTask_NVA
            // 
            groupBoxTask_NVA.Controls.Add(textBoxUslovie_NVA);
            groupBoxTask_NVA.Location = new Point(12, 150);
            groupBoxTask_NVA.Name = "groupBoxTask_NVA";
            groupBoxTask_NVA.Size = new Size(1004, 109);
            groupBoxTask_NVA.TabIndex = 26;
            groupBoxTask_NVA.TabStop = false;
            groupBoxTask_NVA.Text = "Условие";
            // 
            // textBoxUslovie_NVA
            // 
            textBoxUslovie_NVA.BackColor = SystemColors.Menu;
            textBoxUslovie_NVA.Dock = DockStyle.Fill;
            textBoxUslovie_NVA.Location = new Point(3, 19);
            textBoxUslovie_NVA.Multiline = true;
            textBoxUslovie_NVA.Name = "textBoxUslovie_NVA";
            textBoxUslovie_NVA.ReadOnly = true;
            textBoxUslovie_NVA.Size = new Size(998, 87);
            textBoxUslovie_NVA.TabIndex = 0;
            textBoxUslovie_NVA.Text = resources.GetString("textBoxUslovie_NVA.Text");
            // 
            // buttonSaveFile_NVA
            // 
            buttonSaveFile_NVA.BackColor = Color.DarkOrange;
            buttonSaveFile_NVA.Enabled = false;
            buttonSaveFile_NVA.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_NVA.Location = new Point(279, 41);
            buttonSaveFile_NVA.Name = "buttonSaveFile_NVA";
            buttonSaveFile_NVA.Size = new Size(112, 79);
            buttonSaveFile_NVA.TabIndex = 27;
            buttonSaveFile_NVA.Text = "Сохранить";
            buttonSaveFile_NVA.UseVisualStyleBackColor = false;
            buttonSaveFile_NVA.Click += buttonSaveFile_SIA_Click;
            // 
            // openFileDialogTask_NVA
            // 
            openFileDialogTask_NVA.FileName = "openFileDialogTask_NVA";
            // 
            // toolTip_NVA
            // 
            toolTip_NVA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_NVA.ToolTipTitle = "Подсказка";
            // 
            // saveFileDialogMatrix_NVA
            // 
            saveFileDialogMatrix_NVA.FileName = "saveFileDialogMatrix_NVA";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 628);
            Controls.Add(buttonSaveFile_NVA);
            Controls.Add(groupBoxTask_NVA);
            Controls.Add(groupBoxOut_NVA);
            Controls.Add(groupBoxIn_NVA);
            Controls.Add(buttonOpenFile_NVA);
            Controls.Add(buttonGet_NVA);
            Controls.Add(buttonHelp_NVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Новикова В. А.";
            groupBoxIn_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_NVA).EndInit();
            groupBoxOut_NVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_NVA).EndInit();
            groupBoxTask_NVA.ResumeLayout(false);
            groupBoxTask_NVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_NVA;
        private Button buttonGet_NVA;
        private Button buttonOpenFile_NVA;
        private GroupBox groupBoxIn_NVA;
        private GroupBox groupBoxOut_NVA;
        private GroupBox groupBoxTask_NVA;
        private TextBox textBoxUslovie_NVA;
        private DataGridView dataGridViewIn_NVA;
        private DataGridView dataGridViewOut_NVA;
        private Button buttonSaveFile_NVA;
        private OpenFileDialog openFileDialogTask_NVA;
        private ToolTip toolTip_NVA;
        private SaveFileDialog saveFileDialogMatrix_NVA;
    }
}
