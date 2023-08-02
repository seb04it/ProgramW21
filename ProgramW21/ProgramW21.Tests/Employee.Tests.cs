namespace ProgramW21.Tests
{
    public class Tests
    {
        [Test]
        public void AddGradeAddingSumCheck()
        {
            // Arrange
            Employee employee0 = new Employee("Seba", "M", 18);

            // Act
            employee0.AddGrade(5);
            employee0.AddGrade(6);

            // Assert
            Assert.AreEqual(employee0.Score, 11);
        }

        [Test]
        public void AddGradeAddAndSubSumCheck()
        {
            // Arrange
            Employee employee0 = new Employee("Seba", "M", 18);

            // Act
            employee0.AddGrade(5);
            employee0.AddGrade(6);
            employee0.AddGrade(-6);

            // Assert
            Assert.AreEqual(employee0.Score, 5);
        }

        [Test]
        public void AddGradeSubSumCheck()
        {
            // Arrange
            Employee employee0 = new Employee("Seba", "M", 18);

            // Act
            employee0.AddGrade(-5);
            employee0.AddGrade(-6);

            // Assert
            Assert.AreNotEqual(employee0.Score, 11);
        }
    }
}