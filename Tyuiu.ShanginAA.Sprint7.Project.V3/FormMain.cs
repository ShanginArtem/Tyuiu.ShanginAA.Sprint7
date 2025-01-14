using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tyuiu.ShanginAA.Sprint7.Project.V3.Lib;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.ShanginAA.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetupChart();

        }
        DataService ds = new DataService();
        private void SetupChart()
        {
            
            chartPercent_SAA.ChartAreas.Add(new ChartArea("MainArea")); 
            chartPercent_SAA.Legends.Add(new Legend("PercentsLegend")); 
            chartPercent_SAA.Series.Add(new Series("������")
            {
                ChartType = SeriesChartType.Column, 
                XValueType = ChartValueType.Int32 
            });
        }

        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"; 
            openFileDialog.Title = "�������� ���� ��� ��������";

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        
                        var lines = new List<string>();
                        while (!reader.EndOfStream)
                        {
                            lines.Add(reader.ReadLine());
                        }

                        
                        if (lines.Count > 0)
                        {

                            
                            for (int i = 0; i < lines.Count; i++)
                            {
                                var row = lines[i].Split(';');

                                
                                dataGridViewTeachers_SAA.Rows.Add(row);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� �����: " + ex.Message);
                }
            }
        }

        private void buttonSaveFile_SAA_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "��������� ������ � ����"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        
                        foreach (DataGridViewRow row in dataGridViewTeachers_SAA.Rows)
                        {
                            
                            if (row.IsNewRow) continue;

                            var cellValues = row.Cells.Cast<DataGridViewCell>() 
                                                      .Select(cell => cell.Value?.ToString() ?? string.Empty); 
                            writer.WriteLine(string.Join(";", cellValues)); 
                        }
                    }

                    MessageBox.Show("������ ������� ��������� � ����.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� ���������� ������: " + ex.Message);
                }
            }
        }

       
        private void toolStripButtonClean_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewTeachers_SAA.Rows.Clear();
            for (int i = 1; i < dataGridViewTeachers_SAA.Rows.Count; i++)
            {
                dataGridViewTeachers_SAA.Columns.Clear();
            }
        }

       
        private void buttonPercent_SAA_Click(object sender, EventArgs e)
        {
            
            var percents = GetPercentsFromDataGridView();

            
            var percentCounts = Enumerable.Range(1, 100).ToDictionary(
                percent => percent,
                percent => percents.Count(g => g == percent)
            );

           
            chartPercent_SAA.Series["������"].Points.Clear();

           
            foreach (var percentCount in percentCounts)
            {
                chartPercent_SAA.Series["������"].Points.AddXY(percentCount.Key, percentCount.Value);
            }
        }
        private List<int> GetPercentsFromDataGridView()
        {
            var percents = new List<int>();

            foreach (DataGridViewRow row in dataGridViewTeachers_SAA.Rows)
            {
                if (row.Cells.Count > 1 && int.TryParse(row.Cells[1].Value?.ToString(), out int percent)) 
                {
                    percents.Add(percent);
                }
            }

            return percents;
        }
        private bool SearchValueInDataGridView(DataGridView dataGridView, string searchValue)
        {
            bool found = false; 

            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                
                if (row.IsNewRow) continue;

                bool rowFound = false; 

                
                foreach (DataGridViewCell cell in row.Cells)
                {
                   
                    string? cellValue = cell.Value?.ToString();

                    
                    if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        rowFound = true; 
                        break; 
                    }
                }

                if (rowFound) 
                {
                    row.Selected = true; 
                    found = true; 
                }
            }

            return found;
        }

        private void toolStripButtonImage_SAA_Click(object sender, EventArgs e)
        {
            
            string searchValue = toolStripTextBoxSearch_SAA.Text.Trim();

            
            dataGridViewTeachers_SAA.ClearSelection();

            
            if (!string.IsNullOrEmpty(searchValue))
            {
                
                bool found = SearchValueInDataGridView(dataGridViewTeachers_SAA, searchValue);

                if (found)
                {
                    MessageBox.Show("������� ���� ��� ��������� ����������.");
                }
                else
                {
                    MessageBox.Show("�������� �� �������.");
                }
            }
            else
            {
                MessageBox.Show("������� �������� ��� ������.");
            }
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "�������� ���� ��� ������� ������� ������"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string filePath = openFileDialog.FileName; 

                try
                {
                    var percents = DataService.LoadPercentsFromCsv(filePath); 
                    double averagePercent = DataService.CalculateAveragePercent(percents); 
                    textBoxResult_SAA.Text = averagePercent.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� ������: " + ex.Message); 
                }
            }
        }


        private void buttonAboutMe_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonReference_SAA_Click(object sender, EventArgs e)
        {
            FormManagement formException = new FormManagement();
            formException.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void chartPercent_SAA_Click(object sender, EventArgs e)
        {

        }
    }
}
