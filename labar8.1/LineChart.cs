public class LineChart : Chart
{
    public override void Draw(List<int> data)
    {
        Console.WriteLine("Відображення лінійного графіка з даними:");
        foreach (var point in data)
        {
            Console.Write($"{point} ");
        }
        Console.WriteLine();
    }
}