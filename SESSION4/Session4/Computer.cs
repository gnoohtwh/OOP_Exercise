public class Computer : IDevice
{
    public void ConnectInternet()
    {
        Console.WriteLine("Connect via LAN");
    }

    public void PlugAndPlay()
    {
        Console.WriteLine("Looking driver");
    }
}