using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя сотрудника ");
        string name = Console.ReadLine();
        Console.Write("Введите ID ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер смены ");
        int shift = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ставку оклада ");
        double hrate = Convert.ToDouble(Console.ReadLine());

        Employee Sasha = new ProductionWorker(name, id, shift, hrate);
        Sasha.GetInfo();

        ShiftSupervisor Alec = new("Алек", 52, 43433, 654);
        Alec.GetInfo();

        Customer Ignat = new Customer("Игнат", "ул. Пушкина 63", "+79764352189", 76767432, false);
        Ignat.GetInfo();
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

    public virtual void GetInfo()
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

    public override void GetInfo()
    {
        base.GetInfo();
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

    public override void GetInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Супервайзер {ID} по имени {Name} с годовым окладом {YearSalary}, и премией {YearBonus}");
    }
}
class Person
{
    internal string Name { get; set; }
    internal string Adress { get; set; }
    internal string fNumber { get; set; }
    public Person(string name, string adress, string fnumber)
    {
        Name = name;
        Adress = adress;
        fNumber = fnumber;
    }
} 
class Customer : Person
{
    internal int ID { get; set; }
    internal bool Sending { get; set; }
    public Customer(string name, string adress, string fnumber, int id, bool sending) : base(name, adress, fnumber)
    {
        ID = id;
        Sending = sending;
    }
    public void GetInfo()
    {
        if (this.Sending)
        {
            Console.WriteLine($"Клиент номер {ID} {Name} по адресу {Adress} с номером {fNumber} желает получать рассылку");
        }
        else
        {
            Console.WriteLine($"Клиент номер {ID} {Name} по адресу {Adress} с номером {fNumber} не желает получать рассылку");
        }
    }
}