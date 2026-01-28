namespace Session4_Lab;

class Program
{
    static void Main(string[] args)
    {
        // Vector2d
        Console.WriteLine("Vector2D");
        Vector2D v1 = new Vector2D(1,2);
        Vector2D v2 = new Vector2D(2,3);

        double res1 = v1.Module(v1);
        Console.WriteLine($"Module cua Vecto 1: {res1}");

        double res2 = v1.Mul2V(v1,v2);
        Console.WriteLine($"Tich vo huong cua Vecto 1: {res2}");


        Vector2D res3 = v1.Subt2V(v1,v2);
        Console.WriteLine($"{res3.x} {res3.y}");

        Vector2D res4 = v1.Sum2V(v1,v2);
        Console.WriteLine($"{res4.x} {res4.y}");

        //Vector3D
        Console.WriteLine("Vector3D");
        Vector3D v3 = new Vector3D(1,2,3);
        Vector3D v4 = new Vector3D(2,3,4);

        double result1 = v3.Module(v3);
        Console.WriteLine($"Module cua Vecto 3: {result1}");

        double result2 = v3.Mul2V(v3,v4);
        Console.WriteLine($"Tich vo huong cua Vecto 3 va Vecto 4: {result2}");


        Vector3D result3 = v3.Subt2V(v3,v4);
        Console.WriteLine($"{res3.x} {res3.y}");

        Vector3D result4 = v3.Sum2V(v3,v3);
        Console.WriteLine($"{res4.x} {res4.y}");
    }
}
