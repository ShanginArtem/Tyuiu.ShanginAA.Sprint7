using System.Text;

namespace Tyuiu.ShanginAA.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        public static List<int> LoadPercentsFromCsv(string filePath)
        {
            var percents = new List<int>();

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var columns = line.Split(';');
                        if (columns.Length > 1 && int.TryParse(columns[1], out int percent))
                        {
                            percents.Add(percent);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении файла: " + ex.Message);
            }

            return percents;
        }

        public static double CalculateAveragePercent(List<int> percents)
        {
            if (percents == null || percents.Count == 0)
                throw new ArgumentException("Список оценок пуст или не задан.");

            // Подсчитываем сумму оценок
            int total = 0;
            foreach (var percent in percents)
            {
                total += percent;
            }

            // Возвращаем среднее арифметическое
            return Math.Round((double)total / percents.Count, 3);
        }
    }
}
