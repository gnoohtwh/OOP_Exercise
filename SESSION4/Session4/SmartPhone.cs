public class SmartPhone : IDevice
{
    public void ConnectInternet()
    {
        Console.WriteLine("Connect over 4G");
    }

    public void PlugAndPlay()
    {
        Console.WriteLine("Peripheral is regconized");
    }
}