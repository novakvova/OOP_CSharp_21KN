using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

try
{
    Console.WriteLine("Скільки Вам рочків?");
    Console.Write("->_");
    string text = Console.ReadLine();
    int age = int.Parse(text);
    if(age <= 0)
    {
        throw new Exception("Ви ще не родилися :(. Як Ви можете писати");
    }
    Console.WriteLine($"Ваш вік {age}");
}
catch(FormatException fex)
{
    Console.WriteLine("Дані було введено не вірно {0}", fex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("У нас проблеми Хюстон {0}", ex.Message);
}
