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
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(35);
            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(50, statistics.Max);
        }

        [Test]
        public void AddGradeStatisticsMinCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(40);
            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(30, statistics.Min);
        }

        [Test]
        public void AddGradeStatisticsAverageCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(40);
            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(40, statistics.Average);
        }

        [Test]
        public void AddGradeStatisticsAverageWhenUnevenCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(50);
            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(Math.Round(43.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void AddGradeStatisticsSumCheck()
        {
            // Arrange
            var employee = new Employee("S", "M");

            // Act
            employee.AddGrade(50);
            employee.AddGrade(30);
            employee.AddGrade(50);
            var statistics = employee.GetStatistics();

            // Assert
            Assert.AreEqual(130, statistics.Sum);
        }
    }
}