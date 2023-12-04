public class BarChart : Chart
{
    public override void Draw(List<int> data)
    {
        Console.WriteLine("Відображення стовпчикового графіка з даними:");
        foreach (var point in data)
        {
            Console.Write(new string('*', point));
            Console.WriteLine();
        }
    }
}