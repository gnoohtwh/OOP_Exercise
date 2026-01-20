/*Một lớp vector 2D có các thông tin: toạ độ x, toạ độ y (double)
Hãy bổ sung với Vector class các phương thức sau đây:
- 3 dạng constructor (no params, with params and copy constructor)
- Sử dụng method dạng có parameters để cho phép cộng nhiều vector lại với nhau
- Sử dụng overloading method để cho phép nhân 2 vector hoặc nhân vector với 1 số
- Bổ sung thêm các method sau: Tính module của vector, kiểm tra 2 vector cùng phương/hướng/vector,tịnh tiến vector theo số bước nhảy được chỉ định
- Trong hàm main tạo collection các vector và kiểm tra các phương thức được yêu cầu ở trên


*/
public class Human
{
    public string name{get;set;}
    public DateTime bod {get;set;}
    public bool gender{get;set;}

    public Human(string name,DateTime bod, bool gender)
    {
        this.name = name;
        this.bod = bod;
        this.gender = gender;
    }
    public string getInfo()
    {
        return $"Name:{name}, Birth: {bod}, Gender: {(gender ?"M":"F")}";
    }
}
public class Employee : Human
{
    public string Eid {get;set;}
    public double salCoef {get;set;}

    public DateTime partiCi {get;set;}
    public Employee(string name, DateTime bod,bool gender, string Eid, double salCoef,DateTime partiCi) :base(name,bod,gender)
    {
        this.Eid = Eid;
        this.salCoef = salCoef;
        this.partiCi = partiCi;
    }
    public string getInfo()
    {
        return $"id: {Eid}"+base.getInfo() + $",Salary Coef: {salCoef}, Participation date: {partiCi}";
    }
}
public class Course
{
    
}
class Student

{
    public int id {get;set;}
    public string stuName {get;set;}
    public double GPA {get;set;}
    
}
internal class Program
{
    private static void Main(string[] args)
    {
        Human man = new Human("Thu",new DateTime(),true);
        Employee manE = new Employee("Thu",new DateTime(),true,"001",4.5,new DateTime());
    }
}
