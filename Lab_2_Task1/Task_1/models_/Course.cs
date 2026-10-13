public class Course : AcademicUnit
{
    private readonly List<StreamOfStudents> _streams = new();
    public IReadOnlyList<StreamOfStudents> Streams => _streams;

    public Course(string name) : base(name) { }

    public void Add(StreamOfStudents stream)
    {
        _streams.Add(stream);
    }

    public override double GetAverageGrade()
    {
        return _streams.Count == 0 ? 0 : _streams.Average(s => s.GetAverageGrade());
    }

    public override void Display(int depth = 0)
    {
        base.Display(depth);
        foreach (var stream in _streams)
        {
            stream.Display(depth + 1);
        }
    }
}



