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
            
            chartGrade_SAA.ChartAreas.Add(new ChartArea("MainArea")); 
            chartGrade_SAA.Legends.Add(new Legend("GradesLegend")); 
            chartGrade_SAA.Series.Add(new Series("Оценки")
            {
                ChartType = SeriesChartType.Column, 
                XValueType = ChartValueType.Int32 
            });
        }

        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"; 
            openFileDialog.Title = "Выберите файл для загрузки";

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

                                
                                dataGridViewStudents_SAA.Rows.Add(row);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке файла: " + ex.Message);
                }
            }
        }

        private void buttonSaveFile_SAA_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Сохранить данные в файл"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    
                    using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                    {
                        
                        foreach (DataGridViewRow row in dataGridViewStudents_SAA.Rows)
                        {
                            
                            if (row.IsNewRow) continue;

                            var cellValues = row.Cells.Cast<DataGridViewCell>() 
                                                      .Select(cell => cell.Value?.ToString() ?? string.Empty); 
                            writer.WriteLine(string.Join(";", cellValues)); 
                        }
                    }

                    MessageBox.Show("Данные успешно сохранены в файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
                }
            }
        }

       
        private void toolStripButtonClean_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewStudents_SAA.Rows.Clear();
            for (int i = 1; i < dataGridViewStudents_SAA.Rows.Count; i++)
            {
                dataGridViewStudents_SAA.Columns.Clear();
            }
        }

       
        private void buttonGrade_SAA_Click(object sender, EventArgs e)
        {
            
            var grades = GetGradesFromDataGridView();

            
            var gradeCounts = Enumerable.Range(1, 5).ToDictionary(
                grade => grade,
                grade => grades.Count(g => g == grade)
            );

           
            chartGrade_SAA.Series["Оценки"].Points.Clear();

           
            foreach (var gradeCount in gradeCounts)
            {
                chartGrade_SAA.Series["Оценки"].Points.AddXY(gradeCount.Key, gradeCount.Value);
            }
        }
        private List<int> GetGradesFromDataGridView()
        {
            var grades = new List<int>();

            foreach (DataGridViewRow row in dataGridViewStudents_SAA.Rows)
            {
                if (row.Cells.Count > 1 && int.TryParse(row.Cells[1].Value?.ToString(), out int grade)) // существует ли второй столбец, Если значение ячейки можно преобразовать в целое число (оценка), то оно добавляется в список
                {
                    grades.Add(grade);
                }
            }

            return grades;
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

            
            dataGridViewStudents_SAA.ClearSelection();

            
            if (!string.IsNullOrEmpty(searchValue))
            {
                
                bool found = SearchValueInDataGridView(dataGridViewStudents_SAA, searchValue);

                if (found)
                {
                    MessageBox.Show("Найдено одно или несколько совпадений.");
                }
                else
                {
                    MessageBox.Show("Значение не найдено.");
                }
            }
            else
            {
                MessageBox.Show("Введите значение для поиска.");
            }
        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Выберите файл для расчета средней оценки"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                string filePath = openFileDialog.FileName; 

                try
                {
                    var grades = DataService.LoadGradesFromCsv(filePath); 
                    double averageGrade = DataService.CalculateAverageGrade(grades); 
                    textBoxResult_SAA.Text = averageGrade.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message); 
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

        private void chartGrade_SAA_Click(object sender, EventArgs e)
        {

        }
    }
}
