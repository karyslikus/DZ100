class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Настройка пульта управления ---");
        
        RemoteControl remote = new RemoteControl();
        Light light = new Light();
        Stereo stereo = new Stereo();

        Console.WriteLine("Программируем кнопку на включение света...");
        remote.SetCommand(new LightOnCommand(light));
        remote.PressButton();
        
        Console.WriteLine("Программируем кнопку на включение стереосистемы...");
        remote.SetCommand(new StereoOnWithCDCommand(stereo));
        remote.PressButton();
        
        Console.WriteLine("Программируем кнопку на выключение света...");
        remote.SetCommand(new LightOffCommand(light));
        remote.PressButton();
    }
}