namespace ExamplePolymorphism;

public class Bomber : Worker
{
    private int countSpam;

    public override void ViewInfo()
    {
        base.ViewInfo();
        Console.WriteLine($"Count Spam {countSpam}");
    }
}
