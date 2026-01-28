public class TempEmployee : Employee
{
    public int workingDays;

    public TempEmployee(string id,string name, int workingDays): base(id,name)
    {
        this.workingDays = workingDays;
    }
    public override double CalSalary()
    {
        return workingDays * 350000;
    }
}