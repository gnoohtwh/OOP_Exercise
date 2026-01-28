using System.Security.Cryptography.X509Certificates;
using System.Text;

public class OfficialEmployee : Employee
{
    public double salaryCoef;
    public OfficialEmployee(string id, string name, double salaryCoef) : base (id,name)
    {
        this.salaryCoef = salaryCoef;
        
    }
    public override double CalSalary()
    {
        return salaryCoef * 2100000;
    }


}