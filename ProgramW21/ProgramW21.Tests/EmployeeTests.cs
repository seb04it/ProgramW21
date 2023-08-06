namespace ProgramW21.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void AddGradeStatisticsMaxCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade('C');
            employee.AddGrade(30);
            employee.AddGrade(50);
            var statistics = employee.GetStatisticsForeach();

            // Assert
            Assert.AreEqual(60, statistics.Max);
        }

        [Test]
        public void AddGradeStatisticsMinCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade('C');
            employee.AddGrade(30);
            employee.AddGrade(20);
            var statistics = employee.GetStatisticsForeach();

            // Assert
            Assert.AreEqual(20, statistics.Min);
        }

        [Test]
        public void AddGradeStatisticsAverageCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade('C');
            employee.AddGrade(40);
            var statistics = employee.GetStatisticsForeach();

            // Assert
            Assert.AreEqual(50, statistics.Average);
        }

        [Test]
        public void AddGradeStatisticsAverageWhenUnevenCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade('C');
            employee.AddGrade(30);
            employee.AddGrade(50);
            var statistics = employee.GetStatisticsForeach();

            // Assert
            Assert.AreEqual(Math.Round(46.67, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void AddGradeStatisticsSumCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade('C');
            employee.AddGrade(30);
            employee.AddGrade(20);
            var statistics = employee.GetStatisticsForeach();

            // Assert
            Assert.AreEqual(110, statistics.Sum);
        }
    }
}