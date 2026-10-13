public class Faculty : AcademicUnit
{
    private readonly List<Course> _courses = new();
    public IReadOnlyList<Course> Courses => _courses;

    public Faculty(string name) : base(name) { }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public override double GetAverageGrade()
    {
        return _courses.Count == 0 ? 0 : _courses.Average(c => c.GetAverageGrade());
    }

    public override void Display(int depth = 0)
    {
        base.Display(depth);
        foreach (var course in _courses)
        {
            course.Display(depth + 1);
        }
    }
}

