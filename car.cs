using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public string Note;


  public Car(string makeModel, int price, int miles, string note)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Note = note;
  }
  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (Price <= maxPrice && Miles >= maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "It's clobberin' time!");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "like driving a deviled egg.");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Built Ford tough.");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "ace of pace.");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.Write("Enter maximum budget price:");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.Write("Enter your desired mileage:");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach (Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}