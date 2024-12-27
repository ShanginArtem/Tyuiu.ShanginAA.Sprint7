namespace Tyuiu.ShanginAA.Sprint7.Project.V3
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
            labelAbout_SAA = new Label();
            buttonOK_SAA = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelAbout_SAA
            // 
            labelAbout_SAA.AutoSize = true;
            labelAbout_SAA.Location = new Point(268, 60);
            labelAbout_SAA.Name = "labelAbout_SAA";
            labelAbout_SAA.Size = new Size(0, 15);
            labelAbout_SAA.TabIndex = 0;
            // 
            // buttonOK_SAA
            // 
            buttonOK_SAA.Location = new Point(531, 349);
            buttonOK_SAA.Name = "buttonOK_SAA";
            buttonOK_SAA.Size = new Size(84, 36);
            buttonOK_SAA.TabIndex = 2;
            buttonOK_SAA.Text = "ОК";
            buttonOK_SAA.UseVisualStyleBackColor = true;
            buttonOK_SAA.Click += buttonOK_SAA_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Шангин_А_А_;
            pictureBox1.Location = new Point(331, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(303, 105);
            label1.TabIndex = 4;
            label1.Text = "Разработчик: Шангин А.А.\r\nГруппа ИСПб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024";
            label1.Click += this.buttonOK_SAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 397);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_SAA);
            Controls.Add(labelAbout_SAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_SAA;
        private Button buttonOK_SAA;
        private PictureBox pictureBox1;
        private Label label1;
    }
}