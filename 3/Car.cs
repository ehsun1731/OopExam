public class Car
{
    public string? Name { get; set; }
    protected decimal Price = 1000;
    public int Days { get; set; }

    public virtual void CalculatePrice()
    {
    }

}


public class IranCar : Car
{
    public override void CalculatePrice()
    {
        base.CalculatePrice();

        Console.WriteLine($"name : {Name}-->  price for {Days} days is: {Price * Days * 0.5m}");
    }
}


public class ForeignCar : Car
{
    public override void CalculatePrice()
    {
        base.CalculatePrice();
        Console.WriteLine($"name : {Name}--> price for {Days} days is: : {Price * Days} ");
    }
}