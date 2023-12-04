class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть тип продукту (Smartphone/Notebook/Tablet):");
        string productType = Console.ReadLine();

        ProductFactory factory = null;

        // Вибір фабрики відповідно до типу продукту
        switch (productType.ToLower())
        {
            case "smartphone":
                factory = new SmartphoneFactory();
                break;
            // Додайте аналогічні варіанти для інших типів продуктів
            default:
                Console.WriteLine("Непідтримуваний тип продукту.");
                break;
        }

        // Створення та відображення технологічного продукту
        if (factory != null)
        {
            Device device = new Device
            {
                Screen = factory.CreateScreen(),
                Processor = factory.CreateProcessor(),
                Camera = factory.CreateCamera()
            };

            device.DisplayInfo();
        }

        Console.ReadLine();
    }
}
