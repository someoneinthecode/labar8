public class DataConverterAdapter
{
    private IDataTemplate sourceTemplate;
    private IDataTemplate targetTemplate;

    public DataConverterAdapter(IDataTemplate sourceTemplate, IDataTemplate targetTemplate)
    {
        this.sourceTemplate = sourceTemplate;
        this.targetTemplate = targetTemplate;
    }

    public void Convert(string sourceData)
    {
        Console.WriteLine($"Конвертація даних з формату {sourceTemplate.GetType().Name} до {targetTemplate.GetType().Name}");

        if (sourceTemplate is CsvDataTemplate && targetTemplate is XmlDataTemplate)
        {
            ConvertCsvToXml(sourceData);
        }
        else if (sourceTemplate is CsvDataTemplate && targetTemplate is JsonDataTemplate)
        {
            ConvertCsvToJson(sourceData);
        }
        // Додайте інші варіанти конвертації за потреби
        else
        {
            Console.WriteLine("Непідтримувана конвертація.");
        }
    }

    private void ConvertCsvToXml(string csvData)
    {
        // Логіка конвертації CSV до XML
        // В цьому прикладі, для ілюстрації, просто виводимо результат на консоль
        Console.WriteLine("Конвертація CSV до XML:");
        // Ваша логіка конвертації тут
    }

    private void ConvertCsvToJson(string csvData)
    {
        // Логіка конвертації CSV до JSON
        // В цьому прикладі, для ілюстрації, просто виводимо результат на консоль
        Console.WriteLine("Конвертація CSV до JSON:");
        // Ваша логіка конвертації тут
    }
}