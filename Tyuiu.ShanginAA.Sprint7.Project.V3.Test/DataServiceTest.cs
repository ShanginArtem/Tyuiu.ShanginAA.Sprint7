using Tyuiu.ShanginAA.Sprint7.Project.V3.Lib;

namespace Tyuiu.ShanginAA.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalcAveragePercents()
        {

            var Percents = new List<int> { 1, 2, 3, 4, 5 };
            var res = DataService.CalculateAveragePercent(Percents);
            double wait = 3;
            Assert.AreEqual(wait, res);


        }
    }
}