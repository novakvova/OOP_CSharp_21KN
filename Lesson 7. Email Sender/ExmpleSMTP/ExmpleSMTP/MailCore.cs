namespace ExmpleSMTP;

// Конфігурація пошти
public class MailCore
{
    // Хто надсилає листа
    public static string From { get; set; } = "chinazes85@ukr.net";
    // Назва сервера на ukr.net
    public static string SmtpServer { get; set; } = "smtp.ukr.net";
    // Порт через який ми будемо працювати на ukr.net
    public static int SmtpPort { get; set; } = 2525;
    // Ім'я користувача для авторизації
    public static string UserName { get; set; } = "chinazes85@ukr.net";
    // Пароль для доступу до пошти ukr.net
    public static string Password { get; set; } = "hijbD9HNFC5eBfNI";
}
