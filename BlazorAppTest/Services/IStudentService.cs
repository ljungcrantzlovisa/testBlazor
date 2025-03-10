namespace BlazorAppTest.Services;

public interface IStudentService
{
    event Action OnChange;
    List<Student> GetStudents();
    void AddStudent(Student student);
}
