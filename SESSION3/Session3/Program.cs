/*Một lớp vector 2D có các thông tin: toạ độ x, toạ độ y (double)
Hãy bổ sung với Vector class các phương thức sau đây:
- 3 dạng constructor (no params, with params and copy constructor)
- Sử dụng method dạng có parameters để cho phép cộng nhiều vector lại với nhau
- Sử dụng overloading method để cho phép nhân 2 vector hoặc nhân vector với 1 số
- Bổ sung thêm các method sau: Tính module của vector, kiểm tra 2 vector cùng phương/hướng/vector,tịnh tiến vector theo số bước nhảy được chỉ định
- Trong hàm main tạo collection các vector và kiểm tra các phương thức được yêu cầu ở trên
*/
using System.Numerics;

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
        Vector2D v2d1 = new Vector2D(1,2);
        Vector2D v2d2 = new Vector2D(3,4);

        double res1= v2d1.Multiply(v2d1,v2d2);
        Console.WriteLine(res1);

        Vector2D res2 = v2d1.Multiply(v2d1,2);
        Console.WriteLine(res2);

        Vector2D res3 = v2d1.SumV(v2d1,v2d2);
        Console.WriteLine(res3);

        double module = v2d1.Module(v2d1);
        Console.WriteLine(module);

        v2d1.sameDirect(v2d1,v2d2);

        Vector2D forwV = v2d1.forw(v2d1,v2d2);
        Console.WriteLine(forwV);

    }
}

public abstract class Shape{
    public abstract double p();
    public abstract double S();
        
    }
public class Rec : Shape
{
    public double a,b;
    public Rec(double _a, double _b)
    {
        a = _a;
        b = _b;
    }
    public override double p()
    {
        return 2 *(a+b);
    }
    public override double S()
    {
        return a *b;
    }
}
public class Round: Shape
{
    public double r;
    public Round(double _r)
    {
        r = _r;
    }
    public override double p()
    {
        return 2*r*Math.PI;
    }
    public override double S()
    {
        return Math.PI * r * r;
    }
}

