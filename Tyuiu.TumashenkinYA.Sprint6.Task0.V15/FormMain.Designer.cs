namespace Tyuiu.TumashenkinYA.Sprint6.Task0.V15
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_KKA = new GroupBox();
            pictureBoxTask_KKA = new PictureBox();
            textBoxTask_KKA = new TextBox();
            groupBoxInputData_KKA = new GroupBox();
            labelVarX_KKA = new Label();
            textBoxInputVarX_KKA = new TextBox();
            groupBoxOutData_KKA = new GroupBox();
            textBoxOutputResult_KKA = new TextBox();
            labelResult_KKA = new Label();
            buttonDone_KKA = new Button();
            buttonHelp_KKA = new Button();
            groupBoxTask_KKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_KKA).BeginInit();
            groupBoxInputData_KKA.SuspendLayout();
            groupBoxOutData_KKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KKA
            // 
            groupBoxTask_KKA.Controls.Add(pictureBoxTask_KKA);
            groupBoxTask_KKA.Controls.Add(textBoxTask_KKA);
            groupBoxTask_KKA.Location = new Point(16, 45);
            groupBoxTask_KKA.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask_KKA.Name = "groupBoxTask_KKA";
            groupBoxTask_KKA.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask_KKA.Size = new Size(535, 282);
            groupBoxTask_KKA.TabIndex = 0;
            groupBoxTask_KKA.TabStop = false;
            groupBoxTask_KKA.Text = "Условие";
            groupBoxTask_KKA.Enter += groupBoxTask_KKA_Enter;
            // 
            // pictureBoxTask_KKA
            // 
            pictureBoxTask_KKA.Location = new Point(9, 62);
            pictureBoxTask_KKA.Margin = new Padding(4, 5, 4, 5);
            pictureBoxTask_KKA.Name = "pictureBoxTask_KKA";
            pictureBoxTask_KKA.Size = new Size(325, 60);
            pictureBoxTask_KKA.TabIndex = 1;
            pictureBoxTask_KKA.TabStop = false;
            pictureBoxTask_KKA.Click += pictureBoxTask_KKA_Click;
            // 
            // textBoxTask_KKA
            // 
            textBoxTask_KKA.BorderStyle = BorderStyle.None;
            textBoxTask_KKA.Location = new Point(9, 31);
            textBoxTask_KKA.Margin = new Padding(4, 5, 4, 5);
            textBoxTask_KKA.Name = "textBoxTask_KKA";
            textBoxTask_KKA.ReadOnly = true;
            textBoxTask_KKA.Size = new Size(244, 20);
            textBoxTask_KKA.TabIndex = 0;
            textBoxTask_KKA.TabStop = false;
            textBoxTask_KKA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInputData_KKA
            // 
            groupBoxInputData_KKA.Controls.Add(labelVarX_KKA);
            groupBoxInputData_KKA.Controls.Add(textBoxInputVarX_KKA);
            groupBoxInputData_KKA.Location = new Point(16, 335);
            groupBoxInputData_KKA.Margin = new Padding(4, 5, 4, 5);
            groupBoxInputData_KKA.Name = "groupBoxInputData_KKA";
            groupBoxInputData_KKA.Padding = new Padding(4, 5, 4, 5);
            groupBoxInputData_KKA.Size = new Size(253, 125);
            groupBoxInputData_KKA.TabIndex = 1;
            groupBoxInputData_KKA.TabStop = false;
            groupBoxInputData_KKA.Text = "Ввод данных";
            // 
            // labelVarX_KKA
            // 
            labelVarX_KKA.AutoSize = true;
            labelVarX_KKA.Location = new Point(5, 43);
            labelVarX_KKA.Margin = new Padding(4, 0, 4, 0);
            labelVarX_KKA.Name = "labelVarX_KKA";
            labelVarX_KKA.Size = new Size(114, 20);
            labelVarX_KKA.TabIndex = 1;
            labelVarX_KKA.Text = "Переменная X:";
            // 
            // textBoxInputVarX_KKA
            // 
            textBoxInputVarX_KKA.Location = new Point(9, 68);
            textBoxInputVarX_KKA.Margin = new Padding(4, 5, 4, 5);
            textBoxInputVarX_KKA.Name = "textBoxInputVarX_KKA";
            textBoxInputVarX_KKA.Size = new Size(148, 27);
            textBoxInputVarX_KKA.TabIndex = 0;
            textBoxInputVarX_KKA.TabStop = false;
            textBoxInputVarX_KKA.KeyPress += textBoxInputVarX_KKA_KeyPress;
            // 
            // groupBoxOutData_KKA
            // 
            groupBoxOutData_KKA.Controls.Add(textBoxOutputResult_KKA);
            groupBoxOutData_KKA.Controls.Add(labelResult_KKA);
            groupBoxOutData_KKA.Location = new Point(292, 335);
            groupBoxOutData_KKA.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutData_KKA.Name = "groupBoxOutData_KKA";
            groupBoxOutData_KKA.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutData_KKA.Size = new Size(259, 125);
            groupBoxOutData_KKA.TabIndex = 2;
            groupBoxOutData_KKA.TabStop = false;
            groupBoxOutData_KKA.Text = "Вывод данных";
            // 
            // textBoxOutputResult_KKA
            // 
            textBoxOutputResult_KKA.Location = new Point(9, 69);
            textBoxOutputResult_KKA.Margin = new Padding(4, 5, 4, 5);
            textBoxOutputResult_KKA.Name = "textBoxOutputResult_KKA";
            textBoxOutputResult_KKA.ReadOnly = true;
            textBoxOutputResult_KKA.Size = new Size(155, 27);
            textBoxOutputResult_KKA.TabIndex = 1;
            textBoxOutputResult_KKA.TabStop = false;
            // 
            // labelResult_KKA
            // 
            labelResult_KKA.AutoSize = true;
            labelResult_KKA.Location = new Point(9, 43);
            labelResult_KKA.Margin = new Padding(4, 0, 4, 0);
            labelResult_KKA.Name = "labelResult_KKA";
            labelResult_KKA.Size = new Size(78, 20);
            labelResult_KKA.TabIndex = 0;
            labelResult_KKA.Text = "Результат:";
            // 
            // buttonDone_KKA
            // 
            buttonDone_KKA.Location = new Point(435, 471);
            buttonDone_KKA.Margin = new Padding(4, 5, 4, 5);
            buttonDone_KKA.Name = "buttonDone_KKA";
            buttonDone_KKA.Size = new Size(116, 58);
            buttonDone_KKA.TabIndex = 3;
            buttonDone_KKA.TabStop = false;
            buttonDone_KKA.Text = "Выполнить";
            buttonDone_KKA.UseVisualStyleBackColor = true;
            buttonDone_KKA.Click += buttonDone_KKA_Click;
            // 
            // buttonHelp_KKA
            // 
            buttonHelp_KKA.BackColor = SystemColors.Window;
            buttonHelp_KKA.FlatStyle = FlatStyle.Flat;
            buttonHelp_KKA.Location = new Point(377, 469);
            buttonHelp_KKA.Margin = new Padding(4, 5, 4, 5);
            buttonHelp_KKA.Name = "buttonHelp_KKA";
            buttonHelp_KKA.Size = new Size(49, 57);
            buttonHelp_KKA.TabIndex = 4;
            buttonHelp_KKA.TabStop = false;
            buttonHelp_KKA.Text = "?";
            buttonHelp_KKA.UseVisualStyleBackColor = false;
            buttonHelp_KKA.Click += buttonHelp_KKA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 543);
            Controls.Add(buttonHelp_KKA);
            Controls.Add(buttonDone_KKA);
            Controls.Add(groupBoxOutData_KKA);
            Controls.Add(groupBoxInputData_KKA);
            Controls.Add(groupBoxTask_KKA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 15 | Тумашенкин Я.А";
            Load += FormMain_Load;
            groupBoxTask_KKA.ResumeLayout(false);
            groupBoxTask_KKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_KKA).EndInit();
            groupBoxInputData_KKA.ResumeLayout(false);
            groupBoxInputData_KKA.PerformLayout();
            groupBoxOutData_KKA.ResumeLayout(false);
            groupBoxOutData_KKA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KKA;
        private System.Windows.Forms.PictureBox pictureBoxTask_KKA;
        private System.Windows.Forms.TextBox textBoxTask_KKA;
        private System.Windows.Forms.GroupBox groupBoxInputData_KKA;
        private System.Windows.Forms.Label labelVarX_KKA;
        private System.Windows.Forms.TextBox textBoxInputVarX_KKA;
        private System.Windows.Forms.GroupBox groupBoxOutData_KKA;
        private System.Windows.Forms.TextBox textBoxOutputResult_KKA;
        private System.Windows.Forms.Label labelResult_KKA;
        private System.Windows.Forms.Button buttonDone_KKA;
        private System.Windows.Forms.Button buttonHelp_KKA;
    }
}