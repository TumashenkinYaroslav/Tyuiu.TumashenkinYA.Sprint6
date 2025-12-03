namespace Tyuiu.TumashenkinYA.Sprint6.Task6.V7
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
            panelUp_KES = new Panel();
            buttonInfo_KES = new Button();
            buttonDone_KES = new Button();
            buttonOpenFile_KES = new Button();
            groupBoxTask_KES = new GroupBox();
            textBoxTask_KES = new TextBox();
            panelLeft_KES = new Panel();
            groupBoxIn_KES = new GroupBox();
            textBoxIn_KES = new TextBox();
            panelFill_KES = new Panel();
            groupBoxResult_KES = new GroupBox();
            textBoxResult_KES = new TextBox();
            splitterLeftAndFill_KES = new Splitter();
            toolTipButton = new ToolTip(components);
            openFileDialogTask = new OpenFileDialog();
            panelUp_KES.SuspendLayout();
            groupBoxTask_KES.SuspendLayout();
            panelLeft_KES.SuspendLayout();
            groupBoxIn_KES.SuspendLayout();
            panelFill_KES.SuspendLayout();
            groupBoxResult_KES.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp_KES
            // 
            panelUp_KES.Controls.Add(buttonInfo_KES);
            panelUp_KES.Controls.Add(buttonDone_KES);
            panelUp_KES.Controls.Add(buttonOpenFile_KES);
            panelUp_KES.Controls.Add(groupBoxTask_KES);
            panelUp_KES.Dock = DockStyle.Top;
            panelUp_KES.Location = new Point(0, 0);
            panelUp_KES.Name = "panelUp_KES";
            panelUp_KES.Size = new Size(800, 156);
            panelUp_KES.TabIndex = 0;
            // 
            // buttonInfo_KES
            // 
            buttonInfo_KES.BackgroundImage = Properties.Resources.Info_Simple_svg;
            buttonInfo_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo_KES.Dock = DockStyle.Right;
            buttonInfo_KES.FlatStyle = FlatStyle.Flat;
            buttonInfo_KES.Location = new Point(707, 0);
            buttonInfo_KES.Name = "buttonInfo_KES";
            buttonInfo_KES.Size = new Size(93, 91);
            buttonInfo_KES.TabIndex = 5;
            toolTipButton.SetToolTip(buttonInfo_KES, "Справка");
            buttonInfo_KES.UseVisualStyleBackColor = true;
            buttonInfo_KES.Click += buttonInfo_KES_Click;
            // 
            // buttonDone_KES
            // 
            buttonDone_KES.BackgroundImage = Properties.Resources._222_2225387_download_icon_png_export_transparent_file_export_icon;
            buttonDone_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_KES.Enabled = false;
            buttonDone_KES.FlatStyle = FlatStyle.Flat;
            buttonDone_KES.Location = new Point(112, 12);
            buttonDone_KES.Name = "buttonDone_KES";
            buttonDone_KES.Size = new Size(81, 73);
            buttonDone_KES.TabIndex = 4;
            toolTipButton.SetToolTip(buttonDone_KES, "Выполнить");
            buttonDone_KES.UseVisualStyleBackColor = true;
            buttonDone_KES.Click += buttonDone_KES_Click;
            // 
            // buttonOpenFile_KES
            // 
            buttonOpenFile_KES.BackgroundImage = Properties.Resources.folder;
            buttonOpenFile_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_KES.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KES.Location = new Point(12, 12);
            buttonOpenFile_KES.Name = "buttonOpenFile_KES";
            buttonOpenFile_KES.Size = new Size(81, 73);
            buttonOpenFile_KES.TabIndex = 3;
            toolTipButton.SetToolTip(buttonOpenFile_KES, "Открыть файл");
            buttonOpenFile_KES.UseVisualStyleBackColor = true;
            buttonOpenFile_KES.Click += buttonOpenFile_Click;
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Dock = DockStyle.Bottom;
            groupBoxTask_KES.Location = new Point(0, 91);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(800, 65);
            groupBoxTask_KES.TabIndex = 2;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие";
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Dock = DockStyle.Fill;
            textBoxTask_KES.Location = new Point(3, 19);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(794, 43);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = resources.GetString("textBoxTask_KES.Text");
            // 
            // panelLeft_KES
            // 
            panelLeft_KES.Controls.Add(groupBoxIn_KES);
            panelLeft_KES.Dock = DockStyle.Left;
            panelLeft_KES.Location = new Point(0, 156);
            panelLeft_KES.Name = "panelLeft_KES";
            panelLeft_KES.Size = new Size(399, 294);
            panelLeft_KES.TabIndex = 1;
            // 
            // groupBoxIn_KES
            // 
            groupBoxIn_KES.BackColor = SystemColors.Control;
            groupBoxIn_KES.Controls.Add(textBoxIn_KES);
            groupBoxIn_KES.Dock = DockStyle.Fill;
            groupBoxIn_KES.Location = new Point(0, 0);
            groupBoxIn_KES.Name = "groupBoxIn_KES";
            groupBoxIn_KES.Size = new Size(399, 294);
            groupBoxIn_KES.TabIndex = 12;
            groupBoxIn_KES.TabStop = false;
            groupBoxIn_KES.Text = "Ввод";
            // 
            // textBoxIn_KES
            // 
            textBoxIn_KES.Dock = DockStyle.Fill;
            textBoxIn_KES.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_KES.Location = new Point(3, 19);
            textBoxIn_KES.Multiline = true;
            textBoxIn_KES.Name = "textBoxIn_KES";
            textBoxIn_KES.ReadOnly = true;
            textBoxIn_KES.ScrollBars = ScrollBars.Vertical;
            textBoxIn_KES.Size = new Size(393, 272);
            textBoxIn_KES.TabIndex = 1;
            textBoxIn_KES.TabStop = false;
            // 
            // panelFill_KES
            // 
            panelFill_KES.Controls.Add(groupBoxResult_KES);
            panelFill_KES.Dock = DockStyle.Fill;
            panelFill_KES.Location = new Point(399, 156);
            panelFill_KES.Name = "panelFill_KES";
            panelFill_KES.Size = new Size(401, 294);
            panelFill_KES.TabIndex = 2;
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.BackColor = SystemColors.Control;
            groupBoxResult_KES.Controls.Add(textBoxResult_KES);
            groupBoxResult_KES.Dock = DockStyle.Fill;
            groupBoxResult_KES.Location = new Point(0, 0);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Size = new Size(401, 294);
            groupBoxResult_KES.TabIndex = 12;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод:";
            // 
            // textBoxResult_KES
            // 
            textBoxResult_KES.Dock = DockStyle.Fill;
            textBoxResult_KES.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KES.Location = new Point(3, 19);
            textBoxResult_KES.Multiline = true;
            textBoxResult_KES.Name = "textBoxResult_KES";
            textBoxResult_KES.ReadOnly = true;
            textBoxResult_KES.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KES.Size = new Size(395, 272);
            textBoxResult_KES.TabIndex = 1;
            textBoxResult_KES.TabStop = false;
            // 
            // splitterLeftAndFill_KES
            // 
            splitterLeftAndFill_KES.Location = new Point(399, 156);
            splitterLeftAndFill_KES.Name = "splitterLeftAndFill_KES";
            splitterLeftAndFill_KES.Size = new Size(3, 294);
            splitterLeftAndFill_KES.TabIndex = 3;
            splitterLeftAndFill_KES.TabStop = false;
            // 
            // toolTipButton
            // 
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitterLeftAndFill_KES);
            Controls.Add(panelFill_KES);
            Controls.Add(panelLeft_KES);
            Controls.Add(panelUp_KES);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 7 | Тумашенкин Я.А.";
            panelUp_KES.ResumeLayout(false);
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            panelLeft_KES.ResumeLayout(false);
            groupBoxIn_KES.ResumeLayout(false);
            groupBoxIn_KES.PerformLayout();
            panelFill_KES.ResumeLayout(false);
            groupBoxResult_KES.ResumeLayout(false);
            groupBoxResult_KES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_KES;
        private Panel panelLeft_KES;
        private Panel panelFill_KES;
        private Splitter splitterLeftAndFill_KES;
        private GroupBox groupBoxTask_KES;
        private TextBox textBoxTask_KES;
        private Button buttonOpenFile_KES;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask;
        private Button buttonDone_KES;
        private Button buttonInfo_KES;
        private GroupBox groupBoxIn_KES;
        private TextBox textBoxIn_KES;
        private GroupBox groupBoxResult_KES;
        private TextBox textBoxResult_KES;
    }
}
