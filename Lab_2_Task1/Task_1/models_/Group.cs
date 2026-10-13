public class Group : AcademicUnit
{
    private readonly List<Student> _students = new();
    public IReadOnlyList<Student> Students => _students;

    public Group(string name) : base(name) { }

    public void Add(Student student)
    {
        _students.Add(student);
    }

    public override double GetAverageGrade()
    {
        return _students.Count == 0 ? 0 : _students.Average(s => s.GetAverageGrade());
    }

    public override void Display(int depth = 0)
    {
        base.Display(depth);
        foreach (var student in _students)
        {
            student.Display(depth + 1);
        }
    }
}
