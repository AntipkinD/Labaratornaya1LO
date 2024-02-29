using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя сотрудника ");
        string name = Console.ReadLine();
        Console.Write("Введите ID ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите смена ");
        int shift = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ставку оклада ");
        double hrate = Convert.ToDouble(Console.ReadLine());

        Employee Sasha = new ProductionWorker(name, id, shift, hrate);
        Sasha.Get();

        ShiftSupervisor Alec = new("Алек", 52, 43433, 654);
        Alec.Get();

    }
}
class Employee
{
    internal string Name { get; set; }
    internal int ID { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public virtual void Get()
    {
        Console.Write($"Сотрудник {ID} по имени {Name}");
    }
}
class ProductionWorker : Employee
{
    internal int Shift { get; set; }
    internal double HRate { get; set; }

    public ProductionWorker(string name, int id, int shift, double hrate) : base(name, id)
    {
        Shift = shift;
        HRate = hrate;
    }

    public override void Get()
    {
        base.Get();
        Console.Write($" смена {Shift} со ставкой оклада {HRate}");
    }
}
class ShiftSupervisor : Employee
{
    internal int YearSalary { get; set; }
    internal int YearBonus { get; set; }

    public ShiftSupervisor(string name, int id, int yearsalary, int yearbonus) : base(name, id)
    {
        YearSalary = yearsalary;
        YearBonus = yearbonus;
    }

    public override void Get()
    {
        Console.WriteLine();
        Console.WriteLine($"Супервайзер {ID} по имени {Name} с годовым окладом {YearSalary}, и премией {YearBonus}");
    }
}