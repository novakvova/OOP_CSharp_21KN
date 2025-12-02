namespace MyFilesWpf.Models;

public class CityModel
{
    /// <summary>
    /// Назва
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Фото
    /// </summary>
    public string Image { get; set; } = string.Empty;
    /// <summary>
    /// Кількість населення
    /// </summary>
    public int Population { get; set; }
    /// <summary>
    /// Площа міста
    /// </summary>
    public double Area { get; set; }

}
