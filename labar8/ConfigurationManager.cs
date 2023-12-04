using System;

public sealed class ConfigurationManager
{
    // Єдиний екземпляр конфігураційного менеджера
    private static readonly ConfigurationManager instance = new ConfigurationManager();

    // Конфігураційні налаштування
    private string logMode;
    private string databaseConnection;

    // Приватний конструктор для заборони створення екземплярів поза класом
    private ConfigurationManager()
    {
        // Ініціалізація дефолтних значень
        logMode = "Debug";
        databaseConnection = "DefaultConnection";
    }

    // Властивість для доступу до єдиного екземпляра
    public static ConfigurationManager Instance
    {
        get { return instance; }
    }

    // Метод для отримання значення режиму логування
    public string GetLogMode()
    {
        return logMode;
    }

    // Метод для отримання значення підключення до бази даних
    public string GetDatabaseConnection()
    {
        return databaseConnection;
    }

    // Метод для зміни режиму логування
    public void SetLogMode(string mode)
    {
        logMode = mode;
    }

    // Метод для зміни підключення до бази даних
    public void SetDatabaseConnection(string connection)
    {
        databaseConnection = connection;
    }
}