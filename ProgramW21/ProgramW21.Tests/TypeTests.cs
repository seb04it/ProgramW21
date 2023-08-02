namespace ProgramW21.Tests
{
    public class TypeTests
    {
        [Test]
        public void EmployeeNameCheck()
        {
            // Arrange
            var employee0 = new Employee("Sadam");
            var employee1 = new Employee("Sadam");

            // Act


            // Assert
            Assert.AreEqual(employee0.Name, employee1.Name);
        }

        [Test]
        public void EmployeeDifferenceCheck()
        {
            // Arrange
            var employee0 = new Employee("Sadam");
            var employee1 = new Employee("Sadam");

            // Act


            // Assert
            Assert.AreNotEqual(employee0, employee1);
        }
    }
}
