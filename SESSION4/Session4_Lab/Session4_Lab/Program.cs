namespace Session4_Lab;

class Program
{
    static void Main(string[] args)
    {
        // // Vector2d
        // Console.WriteLine("Vector2D");
        // Vector2D v1 = new Vector2D(1,2);
        // Vector2D v2 = new Vector2D(2,3);

        // double res1 = v1.Module(v1);
        // Console.WriteLine($"Module cua Vecto 1: {res1}");

        // double res2 = v1.Mul2V(v1,v2);
        // Console.WriteLine($"Tich vo huong cua Vecto 1: {res2}");


        // Vector2D res3 = v1.Subt2V(v1,v2);
        // Console.WriteLine($"{res3.x} {res3.y}");

        // Vector2D res4 = v1.Sum2V(v1,v2);
        // Console.WriteLine($"{res4.x} {res4.y}");

        // //Vector3D
        // Console.WriteLine("Vector3D");
        // Vector3D v3 = new Vector3D(1,2,3);
        // Vector3D v4 = new Vector3D(2,3,4);

        // double result1 = v3.Module(v3);
        // Console.WriteLine($"Module cua Vecto 3: {result1}");

        // double result2 = v3.Mul2V(v3,v4);
        // Console.WriteLine($"Tich vo huong cua Vecto 3 va Vecto 4: {result2}");


        // Vector3D result3 = v3.Subt2V(v3,v4);
        // Console.WriteLine($"{res3.x} {res3.y}");

        // Vector3D result4 = v3.Sum2V(v3,v3);
        // Console.WriteLine($"{res4.x} {res4.y}");

        // Interface 
        // Vector2D
        Console.WriteLine("IVector2D");
        IVector2D iv1 = new IVector2D(-1,1);
        IVector2D iv2 = new IVector2D(4,8);

        IVector2D ires1 = iv1.Sum2V(iv1,iv2);
        Console.WriteLine($"{ires1.x} {ires1.y}");

        IVector2D ires2 = iv1.Subt2V(iv1,iv2);
        Console.WriteLine($"{ires2.x} {ires2.y}");
        

        double imod = iv1.Module(iv1);
        Console.WriteLine(imod);

        double imul = iv1.Mul2V(iv1,iv2);
        Console.WriteLine(imul);

        // Vector3D
        Console.WriteLine("IVector3D");
        IVector3D iv3 = new IVector3D(-1,1,1);
        IVector3D iv4 = new IVector3D(4,8,2);

        IVector3D ires3 = iv3.Sum2V(iv3,iv4);
        Console.WriteLine($"{ires3.x} {ires3.y} {ires3.z}");

        IVector3D ires4 = iv3.Subt2V(iv3,iv4);
        Console.WriteLine($"{ires4.x} {ires4.y} {ires4.z}");
        

        double imod1 = iv3.Module(iv3);
        Console.WriteLine(imod1);

        double imul1 = iv3.Mul2V(iv3,iv4);
        Console.WriteLine(imul);

    }
}
