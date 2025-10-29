using System.Security.Cryptography;

namespace ConsoleApp1;

public class Car
{
    //Даний делегат повідомляє інформацію про автомобіль
    public delegate void DisplayInfoDelegate(string info);
    public delegate void DisplayProplemInfoDelegate(string info);
    //Поле для зберігання посилання на метод делегата
    //Повідомляє на дисплей автомобіля інформацію
    private DisplayInfoDelegate? displayInfoCallback;
    //Повідомляє на дисплей автомобіля інформацію про проблеми
    //private DisplayProplemInfoDelegate? displayProplemInfoCallback;
	public event DisplayProplemInfoDelegate? displayProplemInfoCallback;

    private string? model; //може зберігати null
	private int speed;
	private int maxSpeed;

    public Car()
    {
        maxSpeed = 200;
    }
    public Car(string? model, int maxSpeed)
	{
		this.model = model;
		this.maxSpeed = maxSpeed;
		speed = 0;
    }

	public void RegisterDisplayAuto(DisplayInfoDelegate? displayInfoCallback)
	{
        //Реєструємо метод делегата, тобто у авто є дисплей
        this.displayInfoCallback = displayInfoCallback;
    }

	//public void RegisterDisplayProplemAuto(DisplayProplemInfoDelegate? displayProplemInfoCallback)
	//{
	//	//Реєструємо метод делегата, тобто у авто є дисплей проблем
	//	this.displayProplemInfoCallback = displayProplemInfoCallback;
 //   }

    public void Run(int speed)
	{
		this.speed += speed;
		if(this.speed > 0)
		{ 
			if(displayInfoCallback != null)
			{
				displayInfoCallback($"Автомобіль {model} рухається зі швидкістю {this.speed} км/год");
            }
        }
		if(this.speed >= maxSpeed)
		{
            displayProplemInfoCallback?.Invoke($"Автомобіль {model} досяг максимальної швидкості {maxSpeed} км/год");

   //         if (displayProplemInfoCallback != null)
			//{
			//	displayProplemInfoCallback($"Автомобіль {model} перевищив максимальну швидкість {maxSpeed} км/год");
   //         }
			speed = maxSpeed;
        }
    }


    public int Speed
	{
		get { return speed; }
	}

	public string? Model
	{
		get { return model; }
		set { model = value; }
	}

}
