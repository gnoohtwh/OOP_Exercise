public abstract class AVector<T>
{
    // To access inside of Every method (which means using effectively params) -> follow this structure of code
    public abstract AVector<T> Sum2V(T v1, T v2);
    public abstract AVector<T> Subt2V(T v1, T v2);
    public abstract double Mul2V(T v1, T v2);
    public abstract double Module(T v);

}