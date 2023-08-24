namespace ProgramW21
{
    public class Statistics
    {
        public float Max { get; private set; }
        public float Min { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }
        public char AverageGrade
        {
            get
            {
                switch (this.Average)
                {
                    case var Average when Average >= 80:
                        return 'A';
                    case var Average when Average >= 60:
                        return 'B';
                    case var Average when Average >= 40:
                        return 'C';
                    case var Average when Average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public float Sum { get; private set; }
        public int Count { get; private set; }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;

        }


        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Max = Math.Max(grade, this.Max);
            this.Min = Math.Min(grade, this.Min);
        }
    }
}
