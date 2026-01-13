using System.Text.RegularExpressions;

namespace Buoi2;

class Employee
{
    private string name;

    public string getName()
    {
        return name;
    }
    public string setName(string ht)
    {
        name = ht;
        return name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Group g = new Group();
        g.AddStu(new Student("001","Teof",9.9));

        // Console.WriteLine("Hello, World!");
        // Student stu1 = new Student();
        // Student stu2 = new Student("002", "teo", 3.6);

        // stu1.StuInfo();
        // stu2.StuInfo();

        // Student stu3 = stu2;

        // // stu3.stuName = "Teof"; // stu3 va stu2 deu co ten la Teof // coi lai cho nay thu

        // Student stu4 = new Student(stu2);
        // stu4.StuInfo();
        g.printStuL();

    }
}

/* ------------LAB 02----------------------
Một lớp Point gồm có 2 thuộc tính: x, y (float), là toạ độ của điểm trong hệ toạ độ Decartes.
1/ Hãy khai báo lớp Point trên
2/ Bổ sung 3 dạng constructor: không tham số, có tham số và copy constructor. ->ý nói tại 3 method với no parameters, having parameters and copy method
3/ Bổ sung phương thức ShowÌnfo để in thông tin của một Point dưới dạng: (x,y)
4/ Bổ sung các phương thức sau: tính khoảng cách giữa 2 Point, kiểm tra một Point thuộc phần tư nào, kiểm tra 2 Point có dói xứng qua trục hoành không -> đối xứng tức vuông góc với trục hoành và nối hai điểm đó sẽ tạo đoạn thẳng cắt trục hoành tại trung điẻm
5/ Trong hàm Main, tạo ra một List các Point và in ra một bộ 3 Point tạo thành 1 tam giác ( chỉ cần in một bộ ba duy nhất). Phương tháuc này là static method trong class Program ( không phải thành viên của lớp Point). Và kiểm tra các methods trong câu số 4.




*/
