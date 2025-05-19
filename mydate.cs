public class MyDate
{
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    // 建構子：可輸入年、月、日
    public MyDate(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    // 建構子過載：不輸入年，預設為 0
    public MyDate(int month, int day)
    {
        Year = 0;
        Month = month;
        Day = day;
    }

    public override string ToString()
    {
        return $"{Year}/{Month}/{Day}";
    }
}
public class Customer
{
    public string Name { get; set; }
    public MyDate BirthDate { get; set; }

    // 建構子
    public Customer(string name, MyDate birthDate)
    {
        Name = name;
        BirthDate = birthDate;
    }

    public override string ToString()
    {
        return $"Customer: {Name}, BirthDate: {BirthDate}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 有輸入年份
        MyDate date1 = new MyDate(1990, 5, 15);
        Customer cust1 = new Customer("Alice", date1);
        Console.WriteLine(cust1);

        // 沒有輸入年份（預設為0）
        MyDate date2 = new MyDate(6, 20);
        Customer cust2 = new Customer("Bob", date2);
        Console.WriteLine(cust2);
    }
}

