public interface IVector<T>
{
    double Module(T v);
    double Mul2V(T v1, T v2);
    IVector<T> Sum2V(T v1, T v2);
    IVector<T> Subt2V(T v1, T v2);
}