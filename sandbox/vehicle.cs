// Inheritance Practice
public class Vehicle
{
    //Attributes of the Parent class Vehicle.
    private int _yearManufactured;
    private string _manufacturer;
    private string _modelName;

    //A default constructor takes no parameters, we won't use it in this example

    //Constructor w/ parameters - To initialize the attributes
    public Vehicle(int yearManufactured, string manufacturer, string modelName)
    {
        _yearManufactured = yearManufactured;
        _manufacturer = manufacturer;
        _modelName = modelName;
    }

    public int GetYearManufactured()
    {
        return _yearManufactured;
    }
}

public class Car : Vehicle //Class car inherits from Vehicle, that's what : means
{
    private int _numberofDoors;

    //Alt + Z wraps the code line to a visible line of sight on a screen
    //Base automatically calls the constructor class of the parent attribute
    public Car(int yearManufactured, string manufacturer, string modelName, int _numberofDoors) : base(yearManufactured, manufacturer, modelName)
    {
        _numberofDoors = _numberofDoors;
    }
}

public class Ford : Car
{
    //Create a constructor, skiped a manufacturer because we know its ford
    public Ford(int yearManufactured, string modelName, int _numberofDoors) : base(yearManufactured, "Ford", modelName, _numberofDoors)
    {

    } 
}

public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car(2006, "Hyundai", "Sonata", 4); //Created a car object
        Ford ford1 = new Ford(2008, "F-150", 2); // A Car - Ford object. 
        Console.WriteLine(ford1.GetYearManufactured());
    }
}
