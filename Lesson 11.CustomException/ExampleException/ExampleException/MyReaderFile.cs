namespace ExampleException;

public class MyReaderFile
{
    //ім'я файлу який буде читати
    private string _fileName;
    //Кількість рядків у файлі
    private List<string> _lines;

    public void ReadLines(string fileName)
    {
        _lines = new List<string>();
        _fileName = fileName;
        //Якщо файл не існує
        if(!File.Exists(_fileName))
        {
            throw new MyReaderFileException("Файл не знайдено");
        }

        //Вміст усього файлу
        var allLines = File.ReadAllLines(_fileName);
    }
}
