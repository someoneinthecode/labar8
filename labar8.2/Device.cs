public class Device
{
    public Screen Screen { get; set; }
    public Processor Processor { get; set; }
    public Camera Camera { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Технологічний продукт складається з наступних компонентів:");
        Screen.Display();
        Processor.Process();
        Camera.Capture();
    }
}