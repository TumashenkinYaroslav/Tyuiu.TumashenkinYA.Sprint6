namespace Tyuiu.TumashenkinYA.Sprint6.Task6.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonCloseDialog_KES = new Button();
            labelInfoName = new Label();
            pictureBoxAvatar_KES = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KES).BeginInit();
            SuspendLayout();
            // 
            // buttonCloseDialog_KES
            // 
            buttonCloseDialog_KES.Location = new Point(354, 194);
            buttonCloseDialog_KES.Name = "buttonCloseDialog_KES";
            buttonCloseDialog_KES.Size = new Size(75, 23);
            buttonCloseDialog_KES.TabIndex = 0;
            buttonCloseDialog_KES.Text = "Ok";
            buttonCloseDialog_KES.UseVisualStyleBackColor = true;
            buttonCloseDialog_KES.Click += buttonCloseDialog_KES_Click;
            // 
            // labelInfoName
            // 
            labelInfoName.AutoSize = true;
            labelInfoName.Location = new Point(126, 27);
            labelInfoName.Name = "labelInfoName";
            labelInfoName.Size = new Size(303, 135);
            labelInfoName.TabIndex = 1;
            labelInfoName.Text = resources.GetString("labelInfoName.Text");
            // 
            // pictureBoxAvatar_KES
            // 
            pictureBoxAvatar_KES.BackgroundImage = Properties.Resources.kandinsky_download_1707307517246;
            pictureBoxAvatar_KES.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAvatar_KES.Location = new Point(12, 27);
            pictureBoxAvatar_KES.Name = "pictureBoxAvatar_KES";
            pictureBoxAvatar_KES.Size = new Size(100, 135);
            pictureBoxAvatar_KES.TabIndex = 2;
            pictureBoxAvatar_KES.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 229);
            Controls.Add(pictureBoxAvatar_KES);
            Controls.Add(labelInfoName);
            Controls.Add(buttonCloseDialog_KES);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KES).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCloseDialog_KES;
        private Label labelInfoName;
        private PictureBox pictureBoxAvatar_KES;
    }
}