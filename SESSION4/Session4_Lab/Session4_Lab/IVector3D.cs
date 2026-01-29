public class IVector3D : IVector<IVector3D>
{
    public double x {get;set;}
    public double y {get;set;}
    public double z {get;set;}

    public IVector3D(double x, double y,double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public double Module(IVector3D v)
    {
        return Math.Sqrt(v.x * v.x +v.y *v.y + v.z *v.z );
    }

    public double Mul2V(IVector3D v1, IVector3D v2)
    {
        return v1.x * v2.x + v1.y *v2.y + v1.z * v2.z;
    }

    public IVector3D Subt2V(IVector3D v1, IVector3D v2)
    {
        IVector3D res = new IVector3D(v1.x - v2.x,v2.y -v1.y,v1.z -v2.z);
        return res;
    }

    public IVector3D Sum2V(IVector3D v1, IVector3D v2)
    {
        IVector3D res = new IVector3D(v1.x + v2.x,v2.y+ v1.y,v1.z +v2.z);
        return res;
    }
    IVector<IVector3D> IVector<IVector3D>.Sum2V(IVector3D v1, IVector3D v2)
    {
        return Sum2V(v1, v2);
    }

    IVector<IVector3D> IVector<IVector3D>.Subt2V(IVector3D v1, IVector3D v2)
    {
        return Subt2V(v1,v2);
    }
}