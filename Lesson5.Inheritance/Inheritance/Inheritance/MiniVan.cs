namespace Inheritance;

//C# Множине наслідування не підтримується
// Truck - має бути ін

public class MiniVan : Car//, Truck
{

    public void TestMethod()
    {
        Speed = 90;
        //потрібно робити public або protected
        //currSpeed = 76; // Error: currSpeed is private in Car
    }
}
