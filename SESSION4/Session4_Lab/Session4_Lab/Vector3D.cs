using System.Numerics;

public class Vector3D : AVector<Vector3D>

{
    public double x;
    public double y;
    public double z;

    public Vector3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public override Vector3D Sum2V(Vector3D v1, Vector3D v2)
    {
        Vector3D res =new Vector3D(v1.x +v2.x,v1.y+v2.y,v1.z+v2.z);
        return res;
    }

    public override Vector3D Subt2V(Vector3D v1, Vector3D v2)
    {
        Vector3D res =new Vector3D(v1.x -v2.x,v1.y-v2.y,v1.z-v2.z);
        return res;
    }

    public override double Mul2V(Vector3D v1, Vector3D v2)
    {
        return v1.x *v2.x + v1.y * v2.y +v1.z *v2.z;
    }

    public override double Module(Vector3D v)
    {
        return Math.Sqrt(v.x *v.x + v.y *v.y + v.z *v.z);
    }

    
}