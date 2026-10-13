public class StreamOfStudents : AcademicUnit
{
    private readonly List<Group> _groups = new();
    public IReadOnlyList<Group> Groups => _groups;

    public StreamOfStudents(string name) : base(name) { }

    public void Add(Group group)
    {
        _groups.Add(group);
    }

    public override double GetAverageGrade()
    {
        return _groups.Count == 0 ? 0 : _groups.Average(g => g.GetAverageGrade());
    }

    public override void Display(int depth = 0)
    {
        base.Display(depth);
        foreach (var group in _groups)
        {
            group.Display(depth + 1);
        }
    }
}



