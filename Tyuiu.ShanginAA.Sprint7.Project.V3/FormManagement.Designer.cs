namespace Tyuiu.ShanginAA.Sprint7.Project.V3
{
    partial class FormManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagement));
            textBoxManagement_SAA = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxManagement_SAA
            // 
            textBoxManagement_SAA.Dock = DockStyle.Fill;
            textBoxManagement_SAA.Location = new Point(0, 0);
            textBoxManagement_SAA.Multiline = true;
            textBoxManagement_SAA.Name = "textBoxManagement_SAA";
            textBoxManagement_SAA.ScrollBars = ScrollBars.Vertical;
            textBoxManagement_SAA.Size = new Size(818, 450);
            textBoxManagement_SAA.TabIndex = 0;
            textBoxManagement_SAA.TextChanged += textBoxManagement_SAA_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(795, 345);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(label1);
            Controls.Add(textBoxManagement_SAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormManagement";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxManagement_SAA;
        private Label label1;
    }
}