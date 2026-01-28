public class Vector2D
{
    public double x{get;set;}
    public double y {get;set;}

    public Vector2D()
    {
        x = 0;
        y = 0;
    }

    public Vector2D(double _x,double _y)
    {
        x = _x;
        y = _y;

    }
    public Vector2D(Vector2D v)
    {
        x = v.x;
        y = v.y;
    }

    public double Multiply(Vector2D v1,Vector2D v2)
    {
        return v1.x * v2.x + v1.y * v2.y;
    }
    public Vector2D Multiply(Vector2D v,double a)
    {
        return new Vector2D(v.x * a,v.y * a);
    }

    public Vector2D SumV(Vector2D v1,Vector2D v2)
    {
        return new Vector2D(v1.x + v2.x,v1.y + v2.y);
    }
    public double Module(Vector2D v)
    {
        return Math.Sqrt(v.x * v.x + v.y * v.y);
    }

    public void sameDirect(Vector2D v1,Vector2D v2)
    {
        if(v1.y != 0 && v2.y != 0)
        {
            Console.Write((v1.x/v1.y) == (v2.x/v2.y));

        }
        else
        {
            Console.WriteLine("Something went wrong");
        }
    }
    public Vector2D forw(Vector2D v,Vector2D a) // Phep tinh tien
    {
        return new Vector2D(v.x + a.x, v.y + a.y );
    }

    
}