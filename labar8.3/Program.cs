class Program
{
    static void Main()
    {
        // Створення шаблонів даних (прототипів)
        var csvTemplate = new CsvDataTemplate { CsvFormat = "Column1,Column2,Column3" };
        var xmlTemplate = new XmlDataTemplate { XmlFormat = "<Data><Item>Value1</Item><Item>Value2</Item></Data>" };
        var jsonTemplate = new JsonDataTemplate { JsonFormat = "{\"property1\":\"value1\",\"property2\":\"value2\"}" };

        Console.WriteLine("Виберіть формат вихідних даних (CSV/XML/JSON):");
        string sourceFormat = Console.ReadLine().ToLower();

        Console.WriteLine("Виберіть формат цільових даних (CSV/XML/JSON):");
        string targetFormat = Console.ReadLine().ToLower();

        IDataTemplate sourceTemplate = null;
        IDataTemplate targetTemplate = null;

        // Вибір прототипу відповідно до форматів
        switch (sourceFormat)
        {
            case "csv":
                sourceTemplate = csvTemplate.Clone();
                break;
            case "xml":
                sourceTemplate = xmlTemplate.Clone();
                break;
            case "json":
                sourceTemplate = jsonTemplate.Clone();
                break;
            default:
                Console.WriteLine("Непідтримуваний формат вихідних даних.");
                return;
        }

        switch (targetFormat)
        {
            case "csv":
                targetTemplate = csvTemplate.Clone();
                break;
            case "xml":
                targetTemplate = xmlTemplate.Clone();
                break;
            case "json":
                targetTemplate = jsonTemplate.Clone();
                break;
            default:
                Console.WriteLine("Непідтримуваний формат цільових даних.");
                return;
        }

        // Створення адаптера та конвертація даних
        DataConverterAdapter adapter = new DataConverterAdapter(sourceTemplate, targetTemplate);
        Console.WriteLine("Введіть вихідні дані:");
        string sourceData = Console.ReadLine();

        adapter.Convert(sourceData);

        Console.ReadLine();
    }
}
