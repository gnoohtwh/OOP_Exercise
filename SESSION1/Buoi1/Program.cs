namespace Buoi1;

// Mot doi tuong hang hoa gom co cac thong tin: ma hang,ten hang, so luong,don gia
// Su dung struct/class de khai bao bang hang hoa noi tren 
// Xay dung cac ham toan cuc , nam truc tiep trong class program de thuc thi cac chuc nang sau day
/* Nhap thong tin mot mat hang
In thong tin mot mat hang
Bo sung mot mat hang vao danh sach hang
In thong tin toan bo hang hoa
5. De quan ly hang hoa, ngta xay dung cac chuc nang sau:
    1.Cho phep tim kiem mot mat hang theo ten
    2. Cho phep liet ke cac mat hang trong 1 khoang gia
    3. Cho phep them 1 hoac nhieu mat hang vao gio hang 
    4. Cho phep thanh toan cho don hang trong gio hang
        Hay thuc thi cac chuc nang noi tren


*/
using System.Data;

public struct HangHoa // a. Xay dung ban ghi sinh vien
{
    public string id;
    public string tenhang;
    public int soluong;
    public double dongia;

}

internal class Program
{

    static void NhapHH(out HangHoa hh)
    {
        Console.WriteLine("Nhap ma hang");
        hh.id = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Nhap ten hang");
        hh.tenhang = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Nhap so luong hang: ");
        hh.soluong = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap don gia");
        hh.dongia = Convert.ToDouble(Console.ReadLine());
    }
    static void XuatHH(HangHoa hh)
    {
        Console.WriteLine($"Ma hang: {hh.id}, ten hang: {hh.tenhang}, so luong: {hh.soluong}, don gia: {hh.dongia}");

    }
    static void productL(List<HangHoa> pl)
    {
        HangHoa hh;
        NhapHH(out hh);
        pl.Add(hh);
    }
    static void writeL(List<HangHoa> pl)
    {
        Console.WriteLine("{0,10} {1,10} {2,10} {3,10}", "id", "ten hang", "so luong", "Don gia");
        foreach (HangHoa hh in pl)
        {
            Console.WriteLine("{0,10} {1,10} {2,10} {3,10}", hh.id, hh.tenhang, hh.soluong, hh.dongia);
        }
    }
    static List<HangHoa> findProdByName(List<HangHoa> pl, string name)
    {
        List<HangHoa> tempL = new List<HangHoa>();
        foreach (HangHoa hh in pl)
        {
            if (hh.tenhang.Contains(name))
            {
                tempL.Add(hh);
            }
        }
        return tempL;
    }
    static List<HangHoa> PriceRange(List<HangHoa> pl, double min, double max)
    {
        List<HangHoa> tempL = new List<HangHoa>();
        foreach (HangHoa hh in pl)
        {
            if (hh.dongia >= min && hh.dongia <= max)
            {
                tempL.Add(hh);
            }
        }
        return tempL;
    }
    static void GioHang(List<HangHoa> cart, string nameProd, List<HangHoa> pl) // Them 1 mon hang hoa nao do vao gio hang -> chia thanh nhiu lan them vao gio
    {
        foreach (HangHoa hh in pl)
        {
            if (hh.tenhang.Contains(nameProd))
            {
                cart.Add(hh);
            }
        }
    }
    static double CartPurchasing(List<HangHoa> cart)
    {

        double sumProd = 0;
        foreach (HangHoa hh in cart)
        {

            sumProd = sumProd + hh.dongia;

        }
        return sumProd;
    }
    static void Main(string[] args)
    {
        List<HangHoa> prodL = new List<HangHoa>();
        List<HangHoa> cart = new List<HangHoa>();
        for (int i = 0; i < 2; i++)
        {
            productL(prodL);
        }

        Console.WriteLine("Nhap ten mon hang can tim: ");
        string name = Console.ReadLine();
        findProdByName(prodL, name);

        Console.WriteLine("Enter the minimum price: ");
        double min = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the maximum price: ");
        double max = Convert.ToDouble(Console.ReadLine());

        PriceRange(prodL, min, max);

        Console.WriteLine("Nhap ten 1 san pham them vao gio hang: ");
        string nameProd = Console.ReadLine();
        GioHang(cart, nameProd, prodL);
        Console.WriteLine("Tong so tien phai tra");
        Console.WriteLine(CartPurchasing(cart));
    }


}

