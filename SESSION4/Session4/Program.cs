namespace Session4;

class Program
{
    static void Main(string[] args)
    {
        // Employee e1 = new OfficialEmployee("001","Teof",5.5); // abstract class cannot be called to become an instance
        // Employee e2 = new TempEmployee("002","Tef",14);

        // List<IDevice> devices = new List<IDevice>();
        // devices.Add(new Computer());
        // devices.Add(new SmartPhone());
        // Random rand =new Random();
        // for(int i = 0; i < 10; i++)
        // {
        //     IDevice d = devices[rand.Next(0,2)];
        //     d.ConnectInternet();
        //     d.PlugAndPlay();
        // }

        Fraction a = new Fraction(6,9);
        Fraction b = new Fraction(18,12);
        Fraction s  = a + b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(s);
    }
}

/*
Lab4:
Một abstract class AVector có các abstrac method sau: cộng, trừ, tích vô hướng 2 vector; Tính Module Vector (Tất cả đều là abstract). Class Vector2D và Vector3D kế thức từ AVector và triển khai tất cả các abstract method của AVector, trong đó Vector2D có toạ độ x,y kiểu float,Vector3D có toạ độ x,y,z kiểu float. Trong hàm main, tạo một list AVector chứa ngẫu nhiên các vector dạng 2D hoặc 3D; Gọi tất cả các method của AVector cho list nói trên

Lab5:
Tương tự bài Lab4 thay vì sử dụng AVector thì sử dụng IVector. Ngoài ra IVector còn thực thi các Interface bổ sung IClonable, IComparable 

*/
