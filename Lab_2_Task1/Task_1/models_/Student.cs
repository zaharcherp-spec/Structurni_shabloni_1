public class Student : AcademicUnit
{
    private readonly List<int> _grades = new();
    public IReadOnlyList<int> Grades => _grades;

    public Student(string name) : base(name) { }

    public void AddGrade(int grade)
    {
        _grades.Add(grade);
    }

    public override double GetAverageGrade()
    {
        return _grades.Count == 0 ? 0 : _grades.Average();
    }
}
