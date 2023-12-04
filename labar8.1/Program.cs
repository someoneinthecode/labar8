class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть тип графіка (Line/Bar/Pie):");
        string chartType = Console.ReadLine();

        Console.WriteLine("Введіть дані для візуалізації (розділені пробілом):");
        string[] dataInput = Console.ReadLine().Split(' ');

        List<int> data = new List<int>();
        foreach (var point in dataInput)
        {
            if (int.TryParse(point, out int value))
            {
                data.Add(value);
            }
        }

        GraphFactory factory = null;

        // Вибір фабрики відповідно до типу графіка
        switch (chartType.ToLower())
        {
            case "line":
                factory = new LineChartFactory();
                break;
            case "bar":
                factory = new BarChartFactory();
                break;
            case "pie":
                factory = new PieChartFactory();
                break;
            default:
                Console.WriteLine("Непідтримуваний тип графіка.");
                break;
        }

        // Створення та відображення графіка
        if (factory != null)
        {
            Chart chart = factory.CreateChart();
            chart.Draw(data);
        }

        Console.ReadLine();
    }
}
