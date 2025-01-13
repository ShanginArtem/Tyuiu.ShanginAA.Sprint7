namespace Tyuiu.ShanginAA.Sprint7.Project.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_SAA = new Panel();
            buttonSaveFile_SAA = new Button();
            buttonOpenFile_SAA = new Button();
            toolStripSettings_SAA = new ToolStrip();
            toolStripLabelSearch_SAA = new ToolStripLabel();
            toolStripTextBoxSearch_SAA = new ToolStripTextBox();
            toolStripButtonImage_SAA = new ToolStripButton();
            toolStripButtonClean_SAA = new ToolStripButton();
            buttonReference_SAA = new Button();
            buttonAboutMe_SAA = new Button();
            panelBottom_SAA = new Panel();
            groupBoxResult_SAA = new GroupBox();
            buttonGrade_SAA = new Button();
            buttonDone_SAA = new Button();
            textBoxResult_SAA = new TextBox();
            labelResult_SAA = new Label();
            splitter1 = new Splitter();
            panelLeft_SAA = new Panel();
            dataGridViewTeachers_SAA = new DataGridView();
            Students_SAA = new DataGridViewTextBoxColumn();
            Grade_SAA = new DataGridViewTextBoxColumn();
            Note_SAA = new DataGridViewTextBoxColumn();
            Teacher = new DataGridViewTextBoxColumn();
            panelRight_SAA = new Panel();
            chartPercent_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            backgroundWorker_SAA = new System.ComponentModel.BackgroundWorker();
            toolTip_SAA = new ToolTip(components);
            panelTop_SAA.SuspendLayout();
            toolStripSettings_SAA.SuspendLayout();
            panelBottom_SAA.SuspendLayout();
            groupBoxResult_SAA.SuspendLayout();
            panelLeft_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_SAA).BeginInit();
            panelRight_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPercent_SAA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_SAA
            // 
            panelTop_SAA.Controls.Add(buttonSaveFile_SAA);
            panelTop_SAA.Controls.Add(buttonOpenFile_SAA);
            panelTop_SAA.Controls.Add(toolStripSettings_SAA);
            panelTop_SAA.Dock = DockStyle.Top;
            panelTop_SAA.Location = new Point(0, 0);
            panelTop_SAA.Margin = new Padding(3, 2, 3, 2);
            panelTop_SAA.Name = "panelTop_SAA";
            panelTop_SAA.Size = new Size(1011, 68);
            panelTop_SAA.TabIndex = 0;
            // 
            // buttonSaveFile_SAA
            // 
            buttonSaveFile_SAA.Image = Properties.Resources.downloadicon;
            buttonSaveFile_SAA.Location = new Point(72, 27);
            buttonSaveFile_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile_SAA.Name = "buttonSaveFile_SAA";
            buttonSaveFile_SAA.Size = new Size(37, 37);
            buttonSaveFile_SAA.TabIndex = 3;
            toolTip_SAA.SetToolTip(buttonSaveFile_SAA, "Сохранить файл");
            buttonSaveFile_SAA.UseVisualStyleBackColor = true;
            buttonSaveFile_SAA.Click += buttonSaveFile_SAA_Click;
            // 
            // buttonOpenFile_SAA
            // 
            buttonOpenFile_SAA.Image = Properties.Resources.uploadiconn;
            buttonOpenFile_SAA.Location = new Point(29, 27);
            buttonOpenFile_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            buttonOpenFile_SAA.Size = new Size(37, 37);
            buttonOpenFile_SAA.TabIndex = 1;
            toolTip_SAA.SetToolTip(buttonOpenFile_SAA, "Открыть файл");
            buttonOpenFile_SAA.UseVisualStyleBackColor = true;
            buttonOpenFile_SAA.Click += buttonOpenFile_SAA_Click;
            // 
            // toolStripSettings_SAA
            // 
            toolStripSettings_SAA.ImageScalingSize = new Size(20, 20);
            toolStripSettings_SAA.Items.AddRange(new ToolStripItem[] { toolStripLabelSearch_SAA, toolStripTextBoxSearch_SAA, toolStripButtonImage_SAA, toolStripButtonClean_SAA });
            toolStripSettings_SAA.Location = new Point(0, 0);
            toolStripSettings_SAA.Name = "toolStripSettings_SAA";
            toolStripSettings_SAA.Size = new Size(1011, 27);
            toolStripSettings_SAA.TabIndex = 0;
            toolStripSettings_SAA.Text = "toolStrip1";
            // 
            // toolStripLabelSearch_SAA
            // 
            toolStripLabelSearch_SAA.BackColor = SystemColors.HotTrack;
            toolStripLabelSearch_SAA.Name = "toolStripLabelSearch_SAA";
            toolStripLabelSearch_SAA.Size = new Size(42, 24);
            toolStripLabelSearch_SAA.Text = "Поиск";
            // 
            // toolStripTextBoxSearch_SAA
            // 
            toolStripTextBoxSearch_SAA.Name = "toolStripTextBoxSearch_SAA";
            toolStripTextBoxSearch_SAA.Size = new Size(88, 27);
            // 
            // toolStripButtonImage_SAA
            // 
            toolStripButtonImage_SAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonImage_SAA.Image = Properties.Resources.searchiconn;
            toolStripButtonImage_SAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonImage_SAA.Name = "toolStripButtonImage_SAA";
            toolStripButtonImage_SAA.Size = new Size(24, 24);
            toolStripButtonImage_SAA.ToolTipText = "Произовести поиск по таблице ";
            toolStripButtonImage_SAA.Click += toolStripButtonImage_SAA_Click;
            // 
            // toolStripButtonClean_SAA
            // 
            toolStripButtonClean_SAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClean_SAA.Image = Properties.Resources.clear1;
            toolStripButtonClean_SAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonClean_SAA.Name = "toolStripButtonClean_SAA";
            toolStripButtonClean_SAA.Size = new Size(24, 24);
            toolStripButtonClean_SAA.ToolTipText = "Очистить таблицу таблицы";
            toolStripButtonClean_SAA.Click += toolStripButtonClean_SAA_Click;
            // 
            // buttonReference_SAA
            // 
            buttonReference_SAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonReference_SAA.Location = new Point(738, 20);
            buttonReference_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonReference_SAA.Name = "buttonReference_SAA";
            buttonReference_SAA.Size = new Size(122, 22);
            buttonReference_SAA.TabIndex = 4;
            buttonReference_SAA.Text = "О программе";
            toolTip_SAA.SetToolTip(buttonReference_SAA, "Руководство пользования программой");
            buttonReference_SAA.UseVisualStyleBackColor = true;
            buttonReference_SAA.Click += buttonReference_SAA_Click;
            // 
            // buttonAboutMe_SAA
            // 
            buttonAboutMe_SAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAboutMe_SAA.Location = new Point(866, 20);
            buttonAboutMe_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonAboutMe_SAA.Name = "buttonAboutMe_SAA";
            buttonAboutMe_SAA.Size = new Size(122, 22);
            buttonAboutMe_SAA.TabIndex = 2;
            buttonAboutMe_SAA.Text = "О разработчике";
            toolTip_SAA.SetToolTip(buttonAboutMe_SAA, "Данные о программе");
            buttonAboutMe_SAA.UseVisualStyleBackColor = true;
            buttonAboutMe_SAA.Click += buttonAboutMe_SAA_Click;
            // 
            // panelBottom_SAA
            // 
            panelBottom_SAA.Controls.Add(groupBoxResult_SAA);
            panelBottom_SAA.Controls.Add(splitter1);
            panelBottom_SAA.Dock = DockStyle.Bottom;
            panelBottom_SAA.Location = new Point(0, 355);
            panelBottom_SAA.Margin = new Padding(3, 2, 3, 2);
            panelBottom_SAA.Name = "panelBottom_SAA";
            panelBottom_SAA.Size = new Size(1011, 65);
            panelBottom_SAA.TabIndex = 0;
            // 
            // groupBoxResult_SAA
            // 
            groupBoxResult_SAA.Controls.Add(buttonGrade_SAA);
            groupBoxResult_SAA.Controls.Add(buttonReference_SAA);
            groupBoxResult_SAA.Controls.Add(buttonDone_SAA);
            groupBoxResult_SAA.Controls.Add(textBoxResult_SAA);
            groupBoxResult_SAA.Controls.Add(buttonAboutMe_SAA);
            groupBoxResult_SAA.Controls.Add(labelResult_SAA);
            groupBoxResult_SAA.Dock = DockStyle.Fill;
            groupBoxResult_SAA.Location = new Point(4, 0);
            groupBoxResult_SAA.Margin = new Padding(3, 2, 3, 2);
            groupBoxResult_SAA.Name = "groupBoxResult_SAA";
            groupBoxResult_SAA.Padding = new Padding(3, 2, 3, 2);
            groupBoxResult_SAA.Size = new Size(1007, 65);
            groupBoxResult_SAA.TabIndex = 1;
            groupBoxResult_SAA.TabStop = false;
            groupBoxResult_SAA.Text = "Результат";
            // 
            // buttonGrade_SAA
            // 
            buttonGrade_SAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGrade_SAA.Location = new Point(633, 12);
            buttonGrade_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonGrade_SAA.Name = "buttonGrade_SAA";
            buttonGrade_SAA.Size = new Size(80, 39);
            buttonGrade_SAA.TabIndex = 2;
            buttonGrade_SAA.Text = "Процент зачетов";
            toolTip_SAA.SetToolTip(buttonGrade_SAA, "Вывод количества оценок учащихся");
            buttonGrade_SAA.UseVisualStyleBackColor = true;
            buttonGrade_SAA.Click += buttonGrade_SAA_Click;
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Location = new Point(304, 20);
            buttonDone_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(89, 22);
            buttonDone_SAA.TabIndex = 2;
            buttonDone_SAA.Text = "Выполнить";
            toolTip_SAA.SetToolTip(buttonDone_SAA, "Подсчитать среднюю оценку учащихся");
            buttonDone_SAA.UseVisualStyleBackColor = true;
            buttonDone_SAA.Click += buttonDone_SAA_Click;
            // 
            // textBoxResult_SAA
            // 
            textBoxResult_SAA.Location = new Point(165, 17);
            textBoxResult_SAA.Margin = new Padding(3, 2, 3, 2);
            textBoxResult_SAA.Name = "textBoxResult_SAA";
            textBoxResult_SAA.ReadOnly = true;
            textBoxResult_SAA.Size = new Size(110, 23);
            textBoxResult_SAA.TabIndex = 1;
            // 
            // labelResult_SAA
            // 
            labelResult_SAA.AutoSize = true;
            labelResult_SAA.Location = new Point(7, 17);
            labelResult_SAA.Name = "labelResult_SAA";
            labelResult_SAA.Size = new Size(152, 15);
            labelResult_SAA.TabIndex = 0;
            labelResult_SAA.Text = "Средний процент зачетов:";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(3, 2, 3, 2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 65);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panelLeft_SAA
            // 
            panelLeft_SAA.Controls.Add(dataGridViewTeachers_SAA);
            panelLeft_SAA.Dock = DockStyle.Left;
            panelLeft_SAA.Location = new Point(0, 68);
            panelLeft_SAA.Margin = new Padding(3, 2, 3, 2);
            panelLeft_SAA.Name = "panelLeft_SAA";
            panelLeft_SAA.Size = new Size(613, 287);
            panelLeft_SAA.TabIndex = 0;
            // 
            // dataGridViewTeachers_SAA
            // 
            dataGridViewTeachers_SAA.BackgroundColor = SystemColors.Highlight;
            dataGridViewTeachers_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers_SAA.Columns.AddRange(new DataGridViewColumn[] { Students_SAA, Grade_SAA, Note_SAA, Teacher });
            dataGridViewTeachers_SAA.Dock = DockStyle.Fill;
            dataGridViewTeachers_SAA.Location = new Point(0, 0);
            dataGridViewTeachers_SAA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTeachers_SAA.Name = "dataGridViewTeachers_SAA";
            dataGridViewTeachers_SAA.RowHeadersVisible = false;
            dataGridViewTeachers_SAA.RowHeadersWidth = 51;
            dataGridViewTeachers_SAA.Size = new Size(613, 287);
            dataGridViewTeachers_SAA.TabIndex = 0;
            // 
            // Students_SAA
            // 
            Students_SAA.HeaderText = "ФИО Преподавателя";
            Students_SAA.MinimumWidth = 6;
            Students_SAA.Name = "Students_SAA";
            Students_SAA.Width = 170;
            // 
            // Grade_SAA
            // 
            Grade_SAA.HeaderText = "Процент зачетов";
            Grade_SAA.MinimumWidth = 6;
            Grade_SAA.Name = "Grade_SAA";
            Grade_SAA.Width = 125;
            // 
            // Note_SAA
            // 
            Note_SAA.HeaderText = "Предмет";
            Note_SAA.MinimumWidth = 6;
            Note_SAA.Name = "Note_SAA";
            Note_SAA.Width = 125;
            // 
            // Teacher
            // 
            Teacher.HeaderText = "Номер аудитории";
            Teacher.MinimumWidth = 6;
            Teacher.Name = "Teacher";
            Teacher.Width = 125;
            // 
            // panelRight_SAA
            // 
            panelRight_SAA.Controls.Add(chartPercent_SAA);
            panelRight_SAA.Controls.Add(splitter2);
            panelRight_SAA.Dock = DockStyle.Fill;
            panelRight_SAA.Location = new Point(613, 68);
            panelRight_SAA.Margin = new Padding(3, 2, 3, 2);
            panelRight_SAA.Name = "panelRight_SAA";
            panelRight_SAA.Size = new Size(398, 287);
            panelRight_SAA.TabIndex = 0;
            // 
            // chartPercent_SAA
            // 
            chartPercent_SAA.BackColor = Color.YellowGreen;
            chartArea1.Name = "ChartArea1";
            chartPercent_SAA.ChartAreas.Add(chartArea1);
            chartPercent_SAA.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartPercent_SAA.Legends.Add(legend1);
            chartPercent_SAA.Location = new Point(4, 0);
            chartPercent_SAA.Margin = new Padding(3, 2, 3, 2);
            chartPercent_SAA.Name = "chartPercent_SAA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPercent_SAA.Series.Add(series1);
            chartPercent_SAA.Size = new Size(394, 287);
            chartPercent_SAA.TabIndex = 1;
            chartPercent_SAA.Text = "chart1";
            chartPercent_SAA.Click += chartGrade_SAA_Click;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Margin = new Padding(3, 2, 3, 2);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 287);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // toolTip_SAA
            // 
            toolTip_SAA.Tag = "";
            toolTip_SAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1011, 420);
            Controls.Add(panelRight_SAA);
            Controls.Add(panelLeft_SAA);
            Controls.Add(panelBottom_SAA);
            Controls.Add(panelTop_SAA);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Журнал успеваемости студентов";
            Load += FormMain_Load;
            panelTop_SAA.ResumeLayout(false);
            panelTop_SAA.PerformLayout();
            toolStripSettings_SAA.ResumeLayout(false);
            toolStripSettings_SAA.PerformLayout();
            panelBottom_SAA.ResumeLayout(false);
            groupBoxResult_SAA.ResumeLayout(false);
            groupBoxResult_SAA.PerformLayout();
            panelLeft_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_SAA).EndInit();
            panelRight_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPercent_SAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_SAA;
        private Panel panelBottom_SAA;
        private Panel panelLeft_SAA;
        private Panel panelRight_SAA;
        private Splitter splitter1;
        private Splitter splitter2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SAA;
        private ToolStrip toolStripSettings_SAA;
        private ToolStripLabel toolStripLabelSearch_SAA;
        private ToolStripTextBox toolStripTextBoxSearch_SAA;
        private ToolStripButton toolStripButtonImage_SAA;
        private Button buttonReference_SAA;
        private Button buttonSaveFile_SAA;
        private Button buttonAboutMe_SAA;
        private Button buttonOpenFile_SAA;
        private DataGridView dataGridViewTeachers_SAA;
        private GroupBox groupBoxResult_SAA;
        private Label labelResult_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPercent_SAA;
        private TextBox textBoxResult_SAA;
        private ToolStripButton toolStripButtonClean_SAA;
        private Button buttonGrade_SAA;
        private Button buttonDone_SAA;
        private ToolTip toolTip_SAA;
        private DataGridViewTextBoxColumn Students_SAA;
        private DataGridViewTextBoxColumn Grade_SAA;
        private DataGridViewTextBoxColumn Note_SAA;
        private DataGridViewTextBoxColumn Teacher;
    }
}
