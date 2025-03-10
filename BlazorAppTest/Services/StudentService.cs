namespace BlazorAppTest.Services;

public class StudentService : IStudentService
{
    private readonly List<Student> students = new();
    public event Action? OnChange;

    public List<Student> GetStudents() => students;

    public void AddStudent(Student student)
    {
        students.Add(student);
        OnChange?.Invoke();
    }
}
