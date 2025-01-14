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
            buttonPercent_SAA = new Button();
            buttonDone_SAA = new Button();
            textBoxResult_SAA = new TextBox();
            labelResult_SAA = new Label();
            panelLeft_SAA = new Panel();
            buttonAboutMe_SAA = new Button();
            buttonReference_SAA = new Button();
            panelTop_SAA = new Panel();
            groupBoxFile_SAA = new GroupBox();
            buttonOpenFile_SAA = new Button();
            buttonSaveFile_SAA = new Button();
            toolStripSettings_SAA = new ToolStrip();
            toolStripLabelSearch_SAA = new ToolStripLabel();
            toolStripTextBoxSearch_SAA = new ToolStripTextBox();
            toolStripButtonImage_SAA = new ToolStripButton();
            toolStripButtonClean_SAA = new ToolStripButton();
            dataGridViewTeachers_SAA = new DataGridView();
            panelRight_SAA = new Panel();
            chartPercent_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter2 = new Splitter();
            backgroundWorker_SAA = new System.ComponentModel.BackgroundWorker();
            toolTip_SAA = new ToolTip(components);
            miniToolStrip = new ToolStrip();
            Teachers_SAA = new DataGridViewTextBoxColumn();
            Percent_SAA = new DataGridViewTextBoxColumn();
            Subject_SAA = new DataGridViewTextBoxColumn();
            Auditory = new DataGridViewTextBoxColumn();
            panelLeft_SAA.SuspendLayout();
            panelTop_SAA.SuspendLayout();
            groupBoxFile_SAA.SuspendLayout();
            toolStripSettings_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_SAA).BeginInit();
            panelRight_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPercent_SAA).BeginInit();
            SuspendLayout();
            // 
            // buttonPercent_SAA
            // 
            buttonPercent_SAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPercent_SAA.BackColor = Color.FromArgb(122, 158, 126);
            buttonPercent_SAA.Location = new Point(4, 310);
            buttonPercent_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonPercent_SAA.Name = "buttonPercent_SAA";
            buttonPercent_SAA.Size = new Size(394, 108);
            buttonPercent_SAA.TabIndex = 2;
            buttonPercent_SAA.Text = "Процент зачетов";
            toolTip_SAA.SetToolTip(buttonPercent_SAA, "Вывод статистики по процентам учащихся, получивших зачет у преподавателя");
            buttonPercent_SAA.UseVisualStyleBackColor = false;
            buttonPercent_SAA.Click += buttonPercent_SAA_Click;
            // 
            // buttonDone_SAA
            // 
            buttonDone_SAA.Location = new Point(58, 186);
            buttonDone_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonDone_SAA.Name = "buttonDone_SAA";
            buttonDone_SAA.Size = new Size(89, 22);
            buttonDone_SAA.TabIndex = 2;
            buttonDone_SAA.Text = "Выполнить";
            toolTip_SAA.SetToolTip(buttonDone_SAA, "Подсчитать средний процент учащихся, получивших зачет у преподавателя\r\n");
            buttonDone_SAA.UseVisualStyleBackColor = true;
            buttonDone_SAA.Click += buttonDone_SAA_Click;
            // 
            // textBoxResult_SAA
            // 
            textBoxResult_SAA.Location = new Point(49, 159);
            textBoxResult_SAA.Margin = new Padding(3, 2, 3, 2);
            textBoxResult_SAA.Name = "textBoxResult_SAA";
            textBoxResult_SAA.ReadOnly = true;
            textBoxResult_SAA.Size = new Size(110, 23);
            textBoxResult_SAA.TabIndex = 1;
            // 
            // labelResult_SAA
            // 
            labelResult_SAA.AutoSize = true;
            labelResult_SAA.Location = new Point(31, 142);
            labelResult_SAA.Name = "labelResult_SAA";
            labelResult_SAA.Size = new Size(152, 15);
            labelResult_SAA.TabIndex = 0;
            labelResult_SAA.Text = "Средний процент зачетов:";
            // 
            // panelLeft_SAA
            // 
            panelLeft_SAA.BackColor = Color.FromArgb(219, 194, 207);
            panelLeft_SAA.Controls.Add(buttonAboutMe_SAA);
            panelLeft_SAA.Controls.Add(buttonReference_SAA);
            panelLeft_SAA.Controls.Add(panelTop_SAA);
            panelLeft_SAA.Controls.Add(dataGridViewTeachers_SAA);
            panelLeft_SAA.Controls.Add(buttonDone_SAA);
            panelLeft_SAA.Controls.Add(labelResult_SAA);
            panelLeft_SAA.Controls.Add(textBoxResult_SAA);
            panelLeft_SAA.Dock = DockStyle.Left;
            panelLeft_SAA.Location = new Point(0, 0);
            panelLeft_SAA.Margin = new Padding(3, 2, 3, 2);
            panelLeft_SAA.Name = "panelLeft_SAA";
            panelLeft_SAA.Size = new Size(613, 420);
            panelLeft_SAA.TabIndex = 0;
            // 
            // buttonAboutMe_SAA
            // 
            buttonAboutMe_SAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAboutMe_SAA.Location = new Point(4, 375);
            buttonAboutMe_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonAboutMe_SAA.Name = "buttonAboutMe_SAA";
            buttonAboutMe_SAA.Size = new Size(209, 34);
            buttonAboutMe_SAA.TabIndex = 2;
            buttonAboutMe_SAA.Text = "О разработчике";
            toolTip_SAA.SetToolTip(buttonAboutMe_SAA, "Данные о программе");
            buttonAboutMe_SAA.UseVisualStyleBackColor = true;
            buttonAboutMe_SAA.Click += buttonAboutMe_SAA_Click;
            // 
            // buttonReference_SAA
            // 
            buttonReference_SAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReference_SAA.Location = new Point(4, 338);
            buttonReference_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonReference_SAA.Name = "buttonReference_SAA";
            buttonReference_SAA.Size = new Size(209, 33);
            buttonReference_SAA.TabIndex = 4;
            buttonReference_SAA.Text = "О программе";
            toolTip_SAA.SetToolTip(buttonReference_SAA, "Руководство пользования программой");
            buttonReference_SAA.UseVisualStyleBackColor = true;
            buttonReference_SAA.Click += buttonReference_SAA_Click;
            // 
            // panelTop_SAA
            // 
            panelTop_SAA.Controls.Add(groupBoxFile_SAA);
            panelTop_SAA.Controls.Add(toolStripSettings_SAA);
            panelTop_SAA.Location = new Point(4, 2);
            panelTop_SAA.Margin = new Padding(3, 2, 3, 2);
            panelTop_SAA.Name = "panelTop_SAA";
            panelTop_SAA.Size = new Size(209, 137);
            panelTop_SAA.TabIndex = 0;
            // 
            // groupBoxFile_SAA
            // 
            groupBoxFile_SAA.Controls.Add(buttonOpenFile_SAA);
            groupBoxFile_SAA.Controls.Add(buttonSaveFile_SAA);
            groupBoxFile_SAA.Dock = DockStyle.Fill;
            groupBoxFile_SAA.Location = new Point(43, 0);
            groupBoxFile_SAA.Name = "groupBoxFile_SAA";
            groupBoxFile_SAA.Size = new Size(166, 137);
            groupBoxFile_SAA.TabIndex = 4;
            groupBoxFile_SAA.TabStop = false;
            groupBoxFile_SAA.Text = "Файл";
            // 
            // buttonOpenFile_SAA
            // 
            buttonOpenFile_SAA.Image = Properties.Resources.uploadiconn;
            buttonOpenFile_SAA.Location = new Point(6, 21);
            buttonOpenFile_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            buttonOpenFile_SAA.Size = new Size(38, 38);
            buttonOpenFile_SAA.TabIndex = 1;
            toolTip_SAA.SetToolTip(buttonOpenFile_SAA, "Открыть файл");
            buttonOpenFile_SAA.UseVisualStyleBackColor = true;
            buttonOpenFile_SAA.Click += buttonOpenFile_SAA_Click;
            // 
            // buttonSaveFile_SAA
            // 
            buttonSaveFile_SAA.Image = Properties.Resources.downloadicon;
            buttonSaveFile_SAA.Location = new Point(49, 21);
            buttonSaveFile_SAA.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile_SAA.Name = "buttonSaveFile_SAA";
            buttonSaveFile_SAA.Size = new Size(38, 38);
            buttonSaveFile_SAA.TabIndex = 3;
            toolTip_SAA.SetToolTip(buttonSaveFile_SAA, "Сохранить файл");
            buttonSaveFile_SAA.UseVisualStyleBackColor = true;
            buttonSaveFile_SAA.Click += buttonSaveFile_SAA_Click;
            // 
            // toolStripSettings_SAA
            // 
            toolStripSettings_SAA.Dock = DockStyle.Left;
            toolStripSettings_SAA.ImageScalingSize = new Size(20, 20);
            toolStripSettings_SAA.Items.AddRange(new ToolStripItem[] { toolStripLabelSearch_SAA, toolStripTextBoxSearch_SAA, toolStripButtonImage_SAA, toolStripButtonClean_SAA });
            toolStripSettings_SAA.Location = new Point(0, 0);
            toolStripSettings_SAA.Name = "toolStripSettings_SAA";
            toolStripSettings_SAA.Size = new Size(43, 137);
            toolStripSettings_SAA.TabIndex = 0;
            toolStripSettings_SAA.Text = "toolStrip1";
            // 
            // toolStripLabelSearch_SAA
            // 
            toolStripLabelSearch_SAA.BackColor = SystemColors.HotTrack;
            toolStripLabelSearch_SAA.Name = "toolStripLabelSearch_SAA";
            toolStripLabelSearch_SAA.Size = new Size(40, 15);
            toolStripLabelSearch_SAA.Text = "Поиск";
            // 
            // toolStripTextBoxSearch_SAA
            // 
            toolStripTextBoxSearch_SAA.Name = "toolStripTextBoxSearch_SAA";
            toolStripTextBoxSearch_SAA.Size = new Size(38, 23);
            // 
            // toolStripButtonImage_SAA
            // 
            toolStripButtonImage_SAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonImage_SAA.Image = Properties.Resources.searchiconn;
            toolStripButtonImage_SAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonImage_SAA.Name = "toolStripButtonImage_SAA";
            toolStripButtonImage_SAA.Size = new Size(40, 24);
            toolStripButtonImage_SAA.ToolTipText = "Произовести поиск по таблице ";
            toolStripButtonImage_SAA.Click += toolStripButtonImage_SAA_Click;
            // 
            // toolStripButtonClean_SAA
            // 
            toolStripButtonClean_SAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClean_SAA.Image = Properties.Resources.clear1;
            toolStripButtonClean_SAA.ImageTransparentColor = Color.Magenta;
            toolStripButtonClean_SAA.Name = "toolStripButtonClean_SAA";
            toolStripButtonClean_SAA.Size = new Size(40, 24);
            toolStripButtonClean_SAA.ToolTipText = "Очистить таблицу";
            toolStripButtonClean_SAA.Click += toolStripButtonClean_SAA_Click;
            // 
            // dataGridViewTeachers_SAA
            // 
            dataGridViewTeachers_SAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTeachers_SAA.BackgroundColor = Color.FromArgb(179, 239, 178);
            dataGridViewTeachers_SAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers_SAA.Columns.AddRange(new DataGridViewColumn[] { Teachers_SAA, Percent_SAA, Subject_SAA, Auditory });
            dataGridViewTeachers_SAA.Location = new Point(219, 0);
            dataGridViewTeachers_SAA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTeachers_SAA.Name = "dataGridViewTeachers_SAA";
            dataGridViewTeachers_SAA.RowHeadersVisible = false;
            dataGridViewTeachers_SAA.RowHeadersWidth = 51;
            dataGridViewTeachers_SAA.Size = new Size(398, 420);
            dataGridViewTeachers_SAA.TabIndex = 0;
            // 
            // panelRight_SAA
            // 
            panelRight_SAA.BackColor = Color.FromArgb(122, 158, 126);
            panelRight_SAA.Controls.Add(buttonPercent_SAA);
            panelRight_SAA.Controls.Add(chartPercent_SAA);
            panelRight_SAA.Controls.Add(splitter2);
            panelRight_SAA.Dock = DockStyle.Fill;
            panelRight_SAA.Location = new Point(613, 0);
            panelRight_SAA.Margin = new Padding(3, 2, 3, 2);
            panelRight_SAA.Name = "panelRight_SAA";
            panelRight_SAA.Size = new Size(398, 420);
            panelRight_SAA.TabIndex = 0;
            // 
            // chartPercent_SAA
            // 
            chartPercent_SAA.BackColor = Color.FromArgb(122, 158, 126);
            chartArea1.Name = "ChartArea1";
            chartPercent_SAA.ChartAreas.Add(chartArea1);
            chartPercent_SAA.Dock = DockStyle.Top;
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
            chartPercent_SAA.Size = new Size(394, 315);
            chartPercent_SAA.TabIndex = 1;
            chartPercent_SAA.Text = "chart1";
            chartPercent_SAA.Click += chartPercent_SAA_Click;
            // 
            // splitter2
            // 
            splitter2.BackColor = SystemColors.ActiveCaptionText;
            splitter2.Location = new Point(0, 0);
            splitter2.Margin = new Padding(3, 2, 3, 2);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 420);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // toolTip_SAA
            // 
            toolTip_SAA.Tag = "";
            toolTip_SAA.ToolTipTitle = "Подсказка";
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "Выбор нового элемента";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(28, 104);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(91, 142);
            miniToolStrip.TabIndex = 0;
            // 
            // Teachers_SAA
            // 
            Teachers_SAA.HeaderText = "ФИО Преподавателя";
            Teachers_SAA.MinimumWidth = 6;
            Teachers_SAA.Name = "Teachers_SAA";
            Teachers_SAA.Width = 154;
            // 
            // Percent_SAA
            // 
            Percent_SAA.HeaderText = "Процент зачетов";
            Percent_SAA.MinimumWidth = 6;
            Percent_SAA.Name = "Percent_SAA";
            Percent_SAA.Width = 70;
            // 
            // Subject_SAA
            // 
            Subject_SAA.HeaderText = "Предмет";
            Subject_SAA.MinimumWidth = 6;
            Subject_SAA.Name = "Subject_SAA";
            Subject_SAA.Width = 83;
            // 
            // Auditory
            // 
            Auditory.HeaderText = "Номер аудитории";
            Auditory.MinimumWidth = 6;
            Auditory.Name = "Auditory";
            Auditory.Width = 70;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1011, 420);
            Controls.Add(panelRight_SAA);
            Controls.Add(panelLeft_SAA);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Журнал успеваемости у преподавателей";
            Load += FormMain_Load;
            panelLeft_SAA.ResumeLayout(false);
            panelLeft_SAA.PerformLayout();
            panelTop_SAA.ResumeLayout(false);
            panelTop_SAA.PerformLayout();
            groupBoxFile_SAA.ResumeLayout(false);
            toolStripSettings_SAA.ResumeLayout(false);
            toolStripSettings_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_SAA).EndInit();
            panelRight_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPercent_SAA).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLeft_SAA;
        private Panel panelRight_SAA;
        private Splitter splitter2;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SAA;
        private DataGridView dataGridViewTeachers_SAA;
        private Label labelResult_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPercent_SAA;
        private TextBox textBoxResult_SAA;
        private Button buttonPercent_SAA;
        private Button buttonDone_SAA;
        private ToolTip toolTip_SAA;
        private Panel panelTop_SAA;
        private Button buttonSaveFile_SAA;
        private Button buttonOpenFile_SAA;
        private ToolStrip toolStripSettings_SAA;
        private ToolStripLabel toolStripLabelSearch_SAA;
        private ToolStripTextBox toolStripTextBoxSearch_SAA;
        private ToolStripButton toolStripButtonImage_SAA;
        private ToolStripButton toolStripButtonClean_SAA;
        private ToolStrip miniToolStrip;
        private Button buttonAboutMe_SAA;
        private Button buttonReference_SAA;
        private GroupBox groupBoxFile_SAA;
        private DataGridViewTextBoxColumn Teachers_SAA;
        private DataGridViewTextBoxColumn Percent_SAA;
        private DataGridViewTextBoxColumn Subject_SAA;
        private DataGridViewTextBoxColumn Auditory;
    }
}
