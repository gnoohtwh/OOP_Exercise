public class Group
{
    private List<Student> stuList;


    public Group()
    {
        stuList = new List<Student>();

    }
    public List<Student> List { get => stuList; set => stuList = value; }

    public void AddStu(Student s)
    {
        stuList.Add(s); // Tinh chat Encapsulation
    }
    public void printStuL()
    {

        foreach (Student s in stuList)
        {
            Console.WriteLine($"{s.id} {s.stuName} {s.GPA}");
        }
    }
}