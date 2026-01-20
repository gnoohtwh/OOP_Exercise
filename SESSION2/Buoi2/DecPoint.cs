
public class DecPoint
{
    public float x{get;set;}
    public float y{get;set;}

    public DecPoint() // Constructor khong tham so
    {
        x = 0;
        y = 0;

    }
    public DecPoint(float _x, float _y)// Constructor co tham so
    {
        x = _x;
        y = _y;
    }
    public DecPoint(DecPoint p) // Copy constructor
    {
        x = p.x;
        y = p.y;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{x} {y}");
    }

    public double Dist2P(DecPoint p1, DecPoint p2) // Distance of 2 points
    {

        double res = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        return res;
    }

    public int QuartCheck(DecPoint p)
    {
        if (p.x > 0 && p.y > 0)
        {
            return 1;
        }
        else if (p.x < 0 && p.y > 0)
        {
            return 2;
        }
        else if (p.x < 0 && p.y < 0)
        {
            return 3;
        }
        else if (p.x > 0 && p.y < 0)
        {
            return 4;
        }
        else
        {
            return 0; // Khong thuoc goc nao
        }
    }

    public bool CheckSymmetrical(DecPoint p1, DecPoint p2)
    {
        if (p1.x == p2.y && p1.y == -p2.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}