public class PieChart : Chart
{
    public override void Draw(List<int> data)
    {
        Console.WriteLine("Відображення кругової діаграми з даними:");
        int total = data.Sum();
        foreach (var point in data)
        {
            double percentage = (double)point / total * 100;
            Console.WriteLine($"Сектор: {percentage:F2}%");
        }
    }
}
