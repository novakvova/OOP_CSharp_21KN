namespace Inheritance;

public class Car
{
    public readonly int maxSpeed; // in km/h
    private int currSpeed; // in km/h

    public Car(int max)
    {
        this.maxSpeed = max;
    }
    //ctor
    public Car()
    {
        maxSpeed = 55;
    }

    public int Speed 
    {
        get { return currSpeed; }

        set
        {
            currSpeed = value;
            if (currSpeed > maxSpeed) 
                currSpeed = maxSpeed;
        }
    }

}
