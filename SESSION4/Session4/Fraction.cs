public class Fraction
{
    public readonly int numerator;
    public readonly int denominator;

    public Fraction(int num, int den)
    {
        if(den== 0)
        {
            throw new ArgumentException("Mau so phai khac 0");
        }
        this.numerator = num;
        this.denominator = den;
    }
    public static Fraction operator +(Fraction a,Fraction b)
    {
        
        int x = a.numerator * b.denominator + b.numerator * a.denominator;
        int y = a.denominator * b.denominator;
        Fraction res = new Fraction(x,y);
        return res;
    }
    public override string ToString()
    {
        // Largest .... of numerator and denominator
        int minNum = (int)Math.Min(numerator,denominator);
        int largest = 0;
        for(int i = 1; i <= minNum;i++)
        {
            if(numerator % i ==0 && denominator % i == 0 && i > largest)
            {
                largest = i;
                
            }
        }
        return $"{numerator/largest}/{denominator/largest}";
    }

}