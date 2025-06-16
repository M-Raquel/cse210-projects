using System.Drawing;

public abstract class Shape
{
    //private string _color;


    //automatically creates the get/set. It's not truly a method, rather a property. A fancy attribute in other words.
    public string Color { get; set; }


    public Shape(string color)
    {
        Color = color;
    }

    public abstract double GetArea();
        //if area is abstarct it means it has no body. Makes all of the children classes required to have this class
   
}