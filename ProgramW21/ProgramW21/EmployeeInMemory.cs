namespace ProgramW21
{
    public class EmployeeInMemory : EmployeeBase
    {
        public List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
    }
}
