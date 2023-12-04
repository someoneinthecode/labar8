public class SmartphoneFactory : ProductFactory
{
    public override Screen CreateScreen()
    {
        return new OLED();
    }

    public override Processor CreateProcessor()
    {
        return new SnapdragonProcessor();
    }

    public override Camera CreateCamera()
    {
        return new DualCamera();
    }
}