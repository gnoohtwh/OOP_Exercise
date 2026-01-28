public abstract class Employee 
{
    public string id;
    public string name;

    public Employee(string id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public abstract double CalSalary();
}

