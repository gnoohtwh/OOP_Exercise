using System.Collections;
using System.ComponentModel.Design.Serialization;

public class Student
{
    public string id;
    public string stuName;
    public double GPA;

    // Cach de tao ra property
    public string Id { get => id; set=> id  = value;} // Day la property -.-
    public string StuName {get => stuName; set => stuName = value;}
    public double _GPA { get => GPA; set => GPA = value;}

    public Student()
    {
        id= "000";
        stuName = "Nope";
        GPA = 0;
    }
    public Student(string _id, string _stuName, double _GPA)
    {
        id = _id;
        stuName = _stuName;
        GPA = _GPA;
    }
    public void StuInfo()
    {
        Console.WriteLine($"Student {id} name {stuName} grade {GPA}");
    }

    public Student(Student origin)
    {
        id = origin.id;
        stuName = origin.stuName;
        GPA = origin.GPA;
    }

}