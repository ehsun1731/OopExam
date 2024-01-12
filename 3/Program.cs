var iranCar = new IranCar { Name="pride", Days = 4 };
var foreignCar = new ForeignCar { Name= "Benz" ,Days = 4 };

Console.WriteLine("Iran Car :");
iranCar.CalculatePrice();

Console.WriteLine("\nForeign Car :");
foreignCar.CalculatePrice();
