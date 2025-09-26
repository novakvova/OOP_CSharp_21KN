namespace ExmpleSMTP;

public class Message
{
    // Тема листа
    public string Subject { get; set; } = string.Empty;
    // Вмісе листа
    public string Body { get; set; } = string.Empty;
    // Кому надсилаємо листа
    public string To { get; set; } = string.Empty;
}

