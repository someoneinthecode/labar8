class Program
{
    static void Main()
    {
        // Отримання єдиного екземпляра ConfigurationManager
        ConfigurationManager configManager = ConfigurationManager.Instance;

        // Виведення початкових значень
        Console.WriteLine("Початкові конфігураційні налаштування:");
        Console.WriteLine($"Режим логування: {configManager.GetLogMode()}");
        Console.WriteLine($"Підключення до бази даних: {configManager.GetDatabaseConnection()}");

        // Зміна конфігураційних налаштувань через консоль
        Console.WriteLine("\nЗміна конфігураційних налаштувань через консоль:");

        Console.Write("Новий режим логування: ");
        string newLogMode = Console.ReadLine();
        configManager.SetLogMode(newLogMode);

        Console.Write("Нове підключення до бази даних: ");
        string newDatabaseConnection = Console.ReadLine();
        configManager.SetDatabaseConnection(newDatabaseConnection);

        // Виведення змінених значень
        Console.WriteLine("\nЗмінені конфігураційні налаштування:");
        Console.WriteLine($"Режим логування: {configManager.GetLogMode()}");
        Console.WriteLine($"Підключення до бази даних: {configManager.GetDatabaseConnection()}");

        Console.ReadLine();
    }
}
