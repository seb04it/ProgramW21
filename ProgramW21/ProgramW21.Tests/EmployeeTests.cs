namespace ProgramW21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void AddGradeStatisticsMaxCheck()
        {
            // Arrange
            var employee = new EmployeeInMemory("S", "M");

            // Act
            employee.AddGrade('C');
            employee.AddGrade(10);
            employee.AddGrade(15);
            var statistics = employee.GetStatisticsForeach();

            // Assert
            Assert.AreEqual(60, statistics.Max);
        }
        [Test]
        public void AddGradeStatisticsMinCheck()
        {

            // Arrange
            var employee = new EmployeeInMemory("S", "M");

            //Act
            employee.AddGrade('E');
            employee.AddGrade(30);
            employee.AddGrade(40);
            var statistics = employee.GetStatisticsForeach();

            //Assert
            Assert.AreEqual(20, statistics.Min);
        }

        [Test]
        public void AddGradeStatisticsAverageCheck()
        {
            //Arrange
            var employee = new EmployeeInMemory("S", "M");

            //Act
            employee.AddGrade(70);
            employee.AddGrade(30);
            employee.AddGrade('E');
            var statistics = employee.GetStatisticsForeach();

            //Assert
            Assert.AreEqual(40, statistics.Average);
        }
        [Test]
        public void AddGradeStatisticsAverageWhenUnevenCheck()
        {
            //Arrange
            var employee = new EmployeeInMemory("S", "M");

            //Act
            employee.AddGrade('C');
            employee.AddGrade(30);
            employee.AddGrade(50);
            var statistics = employee.GetStatisticsForeach();

            //Assert
            Assert.AreEqual(Math.Round(46.67, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void AddGradeStatisticsSumCheck()
        {
            //Arrange
            var employee = new EmployeeInMemory("S", "M");

            //Act
            employee.AddGrade('C');
            employee.AddGrade(30);
            employee.AddGrade(20);
            var statistics = employee.GetStatisticsForeach();

            //Assert
            Assert.AreEqual(110, statistics.Sum);
        }
    }
}