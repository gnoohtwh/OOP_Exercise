public class IVector2D : IVector<IVector2D>
{
    public double x{get;set;}
    public double y{get;set;}
    public IVector2D(double x, double y )
    {
        this.x = x;
        this.y = y;
    }

    public  IVector2D Sum2V(IVector2D v1, IVector2D v2)
    {
        IVector2D res = new IVector2D(v1.x+ v2.x, v1.y + v2.y);
        return res;
    }
    public  IVector2D Subt2V(IVector2D v1, IVector2D v2)
    {
        IVector2D res = new IVector2D(v1.x- v2.x, v1.y - v2.y);
        return res; 
    }
    public  double Module(IVector2D v)
    {
        return Math.Sqrt(v.x *v.x + v.y *v.y);
    }
    public  double Mul2V(IVector2D v1, IVector2D v2)
    {
        return v1.x *v2.x + v1.y *v2.y;
    }

    IVector<IVector2D> IVector<IVector2D>.Sum2V(IVector2D v1, IVector2D v2)
    {
        return Sum2V(v1, v2);
    }

    IVector<IVector2D> IVector<IVector2D>.Subt2V(IVector2D v1, IVector2D v2)
    {
        return Subt2V(v1,v2);
    }
}
