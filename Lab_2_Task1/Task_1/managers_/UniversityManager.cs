public class UniversityManager
{
    private readonly List<Faculty> _faculties = new();

    public void AddFaculty(string name)
    {
        _faculties.Add(new Faculty(name));
    }

    public void AddCourse(string facultyName, string courseName)
    {
        var faculty = _faculties.FirstOrDefault(f => f.Name == facultyName);
        faculty?.Add(new Course(courseName));
    }

    public void AddStream(string courseName, string streamName)
    {
        var course = _faculties.SelectMany(f => f.Courses).FirstOrDefault(c => c.Name == courseName);
        course?.Add(new StreamOfStudents(streamName));
    }

    public void AddGroup(string streamName, string groupName)
    {
        var stream = _faculties.SelectMany(f => f.Courses).SelectMany(c => c.Streams).FirstOrDefault(s => s.Name == streamName);
        stream?.Add(new Group(groupName));
    }

    public void AddStudent(string groupName, string studentName)
    {
        var group = _faculties.SelectMany(f => f.Courses).SelectMany(c => c.Streams).SelectMany(s => s.Groups).FirstOrDefault(g => g.Name == groupName);
        group?.Add(new Student(studentName));
    }

    public void AddGradeToStudent(string studentName, int grade)
    {
        var student = _faculties.SelectMany(f => f.Courses)
                                .SelectMany(c => c.Streams)
                                .SelectMany(s => s.Groups)
                                .SelectMany(g => g.Students)
                                .FirstOrDefault(s => s.Name == studentName);
        student?.AddGrade(grade);
    }

    public void DisplayUniversity()
    {
        foreach (var faculty in _faculties)
        {
            faculty.Display();
        }
    }
}

