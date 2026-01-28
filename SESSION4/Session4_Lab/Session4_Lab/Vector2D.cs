public class Vector2D : AVector<Vector2D>
{
    public double x;
    public double y;


    public Vector2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public override double Module(Vector2D v) 
    {
        return Math.Sqrt(x*x + y*y);
    }

    public override double Mul2V(Vector2D v1,Vector2D v2)
    {
        return v1.x * v2.x + v1.y *v2.y;
    }

    public override Vector2D Subt2V(Vector2D v1, Vector2D v2)
    {
        Vector2D res = new Vector2D(v1.x - v2.x, v1.y - v2.y);
        return res;
    }
    public override Vector2D Sum2V(Vector2D v1, Vector2D v2)
    {
        Vector2D res = new Vector2D(v1.x + v2.x, v1.y + v2.y);
        return res;
    }
}