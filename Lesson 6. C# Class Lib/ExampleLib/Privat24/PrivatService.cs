namespace Privat24;

public class PrivatService
{
    private string url = "https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5";

    public string GetJsonValuta()
    {
        //Створюю клієнта для відправки запиту - по мережі
        HttpClient client = new HttpClient();
        //Відправляю запит на Privat24
        var response = client.GetStringAsync(url).Result;
        return response;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Це є найпростіший сервіс для привату :)");
    }
}
