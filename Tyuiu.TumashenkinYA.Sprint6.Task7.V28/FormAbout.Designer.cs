using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.TumashenkinYA.Sprint6.Task7.V28
{
    partial class FormAbout_NVA
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
            labelInfo_NVA = new Label();
            pictureBoxAva_NVA = new PictureBox();
            buttonOK_NVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_NVA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_NVA
            // 
            labelInfo_NVA.AutoSize = true;
            labelInfo_NVA.Location = new Point(440, 47);
            labelInfo_NVA.Name = "labelInfo_NVA";
            labelInfo_NVA.Size = new Size(253, 30);
            labelInfo_NVA.TabIndex = 3;
            labelInfo_NVA.Text = "Таск 6 выполнил студент Новикова Валерия \r\nИСТНб-24-1\r\n";
            // 
            // pictureBoxAva_NVA
            // 
            pictureBoxAva_NVA.Location = new Point(60, 47);
            pictureBoxAva_NVA.Name = "pictureBoxAva_NVA";
            pictureBoxAva_NVA.Size = new Size(175, 241);
            pictureBoxAva_NVA.TabIndex = 4;
            pictureBoxAva_NVA.TabStop = false;
            // 
            // buttonOK_NVA
            // 
            buttonOK_NVA.Location = new Point(559, 297);
            buttonOK_NVA.Name = "buttonOK_NVA";
            buttonOK_NVA.Size = new Size(75, 23);
            buttonOK_NVA.TabIndex = 5;
            buttonOK_NVA.Text = "Ok";
            buttonOK_NVA.UseVisualStyleBackColor = true;
            buttonOK_NVA.Click += buttonOk_NVA_Click;
            // 
            // FormAbout_NVA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 341);
            Controls.Add(buttonOK_NVA);
            Controls.Add(pictureBoxAva_NVA);
            Controls.Add(labelInfo_NVA);
            Name = "FormAbout_NVA";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_NVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_NVA;
        private PictureBox pictureBoxAva_NVA;
        private Button buttonOK_NVA;
    }
}