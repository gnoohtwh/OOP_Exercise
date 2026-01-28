using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Buoi2;

/* ------------LAB 02----------------------
Một lớp Point gồm có 2 thuộc tính: x, y (float), là toạ độ của điểm trong hệ toạ độ Decartes.
1/ Hãy khai báo lớp Point trên
2/ Bổ sung 3 dạng constructor: không tham số, có tham số và copy constructor. ->ý nói tại 3 method với no parameters, having parameters and copy method
3/ Bổ sung phương thức ShowÌnfo để in thông tin của một Point dưới dạng: (x,y)
4/ Bổ sung các phương thức sau: tính khoảng cách giữa 2 Point, kiểm tra một Point thuộc phần tư nào, kiểm tra 2 Point có dói xứng qua trục hoành không -> đối xứng tức vuông góc với trục hoành và nối hai điểm đó sẽ tạo đoạn thẳng cắt trục hoành tại trung điẻm
5/ Trong hàm Main, tạo ra một List các Point và in ra một bộ 3 Point tạo thành 1 tam giác ( chỉ cần in một bộ ba duy nhất). Phương tháuc này là static method trong class Program ( không phải thành viên của lớp Point). Và kiểm tra các methods trong câu số 4.




*/


class Program
{
    static bool TriangleCheck(DecPoint p1,DecPoint p2,DecPoint p3)
    {
        double a = p1.x*(p2.y-p3.y)+p2.x*(p3.y-p1.y)+p3.x*(p1.y*p2.y);
        if(a==0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main(string[] args)
    {
        DecPoint p = new DecPoint(1, 2);
        p.ShowInfo(); // Show info

        DecPoint p2 = new DecPoint(2,3);
        DecPoint p3 = new DecPoint(5,6);
        double res = p.Dist2P(p,p2); // Tinh khoang cach giua 2 diem
        Console.Write(res);
        int quart = p.QuartCheck(p);
        if(quart == 1){
             Console.WriteLine("Goc phan tu thu nhat");
             }
        else if(quart ==2 )
        {
            Console.WriteLine("Goc phan tu thu 2");
        }
        else if(quart ==3 )
        {
            Console.WriteLine("Goc phan tu thu 3");
        }
        else if(quart ==4 )
        {
            Console.WriteLine("Goc phan tu thu 4");
        }
        else 
        {
            Console.WriteLine("Khong thuoc goc phan tu nao");
        }
        bool SymCheck = p.CheckSymmetrical(p,p2);
        Console.WriteLine(SymCheck); // Kiem tra co doi xung hay khong

        bool triangleCre = TriangleCheck(p,p3,p2);
        Console.WriteLine(triangleCre);
        if(triangleCre)
        {
            p.ShowInfo();
            p2.ShowInfo();
            p3.ShowInfo();
        }

        // bool result = p.CheckSymmetrical(p,p2);
        // List<DecPoint> pL = new List<DecPoint>();
        // pL.Add(new DecPoint());

    }
}


