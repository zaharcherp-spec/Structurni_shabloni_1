public abstract class AcademicUnit
{
    public string Name { get; init; }

    protected AcademicUnit(string name)
    {
        Name = name;
    }

    public abstract double GetAverageGrade();

    public virtual void Display(int depth = 0)
    {
        string indent = new string('-', depth * 2);
        Console.WriteLine($"{indent} {GetType().Name}: {Name} (Середній бал: {GetAverageGrade():F2})");
    }
}

